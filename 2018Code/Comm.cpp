#include "Comm.h"

Comm::Comm(CommData* data, long baud_rate, SoftwareSerial* ss){
  _data_out = data;
  XBee = ss;
  XBee->begin(baud_rate);
  
  memset(_controller,0,sizeof(_controller));
  memset(_feedback,0,sizeof(_feedback));
  connection = true;
  failsafe();
  read_time = millis();
  checkSumRX = 0;
  x = 0;
  packet_index = 0;
  _count_fail = 0;
  digitalWrite(30, HIGH);
}

void Comm::failsafe(){
  //TODO probs add stuff here
  connection = false;
  _count_fail++;
}

int Comm::getFailures(){
  return _count_fail;
}

void Comm::update(){
  // this while block of code might not need the "packet_index == 0" condition
    // it causes the robot to be more tolerant of old data which can be bad
    // you might want to deleting that condition

   while(packet_index == 0 && XBee->available() >= 22){
        XBee->read();
    }

//    while(packet_index == 0 && XBee->available() >= 36){
//        XBee->read();
//    }

    size = XBee->available();
//
    while(size > 0){
        if(packet_index == 0){
            if(XBee->read()==255){
                packet_index++;
            }
        }
        else if(packet_index < 9){
            _data[packet_index-1] = XBee->read();
            checkSumRX += _data[packet_index-1];
            packet_index++;
        }
        else if(packet_index == 9){
//          Serial.print("Checksum: ");
//          Serial.println(checkSumRX);
            if(XBee->read() == checkSumRX){
                packet_index++;
            }else{
                packet_index=0;
            }
            checkSumRX = 0;
        }
        else if(packet_index == 10){
            if(XBee->read() == 240){
                for(i=0; i<8; i++){
                    _controller[i] = _data[i];
                }
                connection = true;
                read_time = millis();
            }
            packet_index=0;
        }
        size--;
    }
    
    if(connection && millis() - read_time >= time_out){
        failsafe();
    }

//        Serial.println("Data: ");
//        for(int i = 0; i < 8; i++){
//          Serial.println(_controller[i], BIN);
//        }

    if(connection){
        _count_fail = 0;
//        Serial.println("Connected");
        

        byte map_left_y = map(_controller[3], 0, 200, 0, 180);
        byte map_right_y = map(_controller[5], 0, 200, 0, 180);
//        Serial.println(map_left_y);
        
        _data_out->driveLB = map_left_y; //left stick Y
        _data_out->driveLF = map_left_y; //left stick Y
        _data_out->driveRB = 180 - map_right_y; //right stick Y
        _data_out->driveRF = 180 - map_right_y; //right stick Y

//        _data_out->intakeMotor = _controller[1] & 32; //right bumper

        //TODO add if statement or map to something else
//        _data_out->intakePistons = _controller[6] & 1; //left trigger
//        _data_out->rampPistons = _controller[7] & 1; //right trigger

//        if(_controller[1] & 4){_data_out->pulleyPiston = 1;} //dpad left
//        else {_data_out->pulleyPiston = 0;}
        
        if(_controller[1] & 8){_data_out->pulleyMotor = 1;} //dpad right;
        else {_data_out->pulleyMotor = 0;}

//=====

        if(_controller[0] & 8){_data_out->simon_left_front = 1;} //Y
        else {_data_out->simon_left_front = 0;}
        
        if(_controller[0] & 4){_data_out->simon_left_back = 1;} //X
        else {_data_out->simon_left_back = 0;}
        
        if(_controller[0] & 2){_data_out->simon_right_front = 1;} //B
        else {_data_out->simon_right_front = 0;}
        
        if(_controller[0] & 1){_data_out->simon_right_back = 1;} //A
        else {_data_out->simon_left_back = 0;}
        
        
        // below is the code for sending feedback to the driver station

//        XBee->write(255);
//        checkSumTX = 0;
//        for(i=0; i<10; i++){
//            XBee->write(_feedback[i]);
//            checkSumTX += _feedback[i];
//        }
//        XBee->write(checkSumTX);
//        XBee->write(240);
    }
}

