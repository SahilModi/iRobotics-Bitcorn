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
    while(packet_index == 0 && Serial.available() >= 22){
        Serial.read();
    }

    size = Serial.available();

    while(size > 0){
        if(packet_index == 0){
            if(Serial.read()==255){
                packet_index++;
            }
        }
        else if(packet_index < 9){
            _data[packet_index-1] = Serial.read();
            checkSumRX += _data[packet_index-1];
            packet_index++;
        }
        else if(packet_index == 9){
            if(Serial.read() == checkSumRX){
                packet_index++;
            }else{
                packet_index=0;
            }
            checkSumRX = 0;
        }
        else if(packet_index == 10){
            if(Serial.read() == 240){
                for(i=0; i<8; i++){
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
        // write the code below that you want to run 
        // when the robot recieves valid data of the xbox controller
        // basically all the motor control stuff

        //TODO update this
        _count_fail = 0;
        
        _data_out->driveLB = _controller[0];
        _data_out->driveLF = _controller[0];
        _data_out->driveLF = _controller[0];
        _data_out->driveLF = _controller[0];

        _data_out->intakePistons = _controller[0];
        _data_out->rampPistons = _controller[0];
        
        

        // below is the code for sending feedback to the driver station

        Serial.write(255);
        checkSumTX = 0;
        for(i=0; i<10; i++){
            Serial.write(_feedback[i]);
            checkSumTX += _feedback[i];
        }
        Serial.write(checkSumTX);
        Serial.write(254);

        read_time = millis();
    }
}

