#include "Comm.h"

Comm::Comm(CommData* data, long baud_rate){
  _data_out = data;
  Serial.begin(baud_rate);
  
  memset(_controller,0,sizeof(_controller));
  memset(_feedback,0,sizeof(_feedback));
  connection = true;
  failsafe();
  read_time = millis();
  checkSumRX = 0;
  x = 0;
  packet_index = 0;
  _count_fail = 0;
}

void Comm::failsafe(){
  //TODO probs add stuff here
  _count_fail++;
}

int Comm::getFailures(){
  return _count_fail;
}

void Comm::update(){
  // this while block of code might not need the "packet_index == 0" condition
    // it causes the robot to be more tolerant of old data which can be bad
    // you might want to deleting that condition
    while(packet_index == 0 && Serial.available() >= 36){
        Serial.read();
    }

    size = Serial.available();

    while(size > 0){
        if(packet_index == 0){
            if(Serial.read()==255){
                packet_index++;
            }
        }
        else if(packet_index < 17){
            _data[packet_index-1] = Serial.read();
            checkSumRX += _data[packet_index-1];
            packet_index++;
        }
        else if(packet_index == 17){
            if(Serial.read() == 254){
                for(i=0; i<16; i++){  
                    _controller[i] = _data[i];
                }
                connection = true;
            }
            packet_index=0;
        }
        size--;
    }
    if(connection && millis() - read_time >= time_out){
        failsafe();
    }

    if(connection){
        _count_fail = 0;

        byte map_left_y = map(_controller[4], 0, 255, 0, 180);
        byte map_right_y = map(_controller[6], 0, 255, 0, 180);
        
        _data_out->driveLB = map_left_y; //left stick Y
        _data_out->driveLF = 180 - map_left_y; //left stick Y
        _data_out->driveRB = map_right_y; //right stick Y
        _data_out->driveRF = 180 - map_right_y; //right stick Y

        _data_out->intakeMotor = _controller[1] & B00000010; //right bumper (binary = 2)

        //TODO add if statement or map to something else
        _data_out->intakePistons = _controller[7]; //left trigger
        _data_out->rampPistons = _controller[8] & 1; //right trigger

        _data_out->pulleyPiston = _controller[2] & 16; //dpad left
        _data_out->pulleyMotor = _controller[2] & 8; //dpad right

        _data_out->simon_left_front = _controller[1] & 8; //Y
        _data_out->simon_left_back = _controller[1] & 16; //X
        _data_out->simon_right_front = _controller[1] & 32; //B
        _data_out->simon_right_back = _controller[1] & 64; //A
        
        
        // below is the code for sending feedback to the driver station

//        Serial.write(255);
//        checkSumTX = 0;
//        for(i=0; i<10; i++){
//            Serial.write(_feedback[i]);
//            checkSumTX += _feedback[i];
//        }
//        Serial.write(checkSumTX);
//        Serial.write(254);

        read_time = millis();
    }
}

