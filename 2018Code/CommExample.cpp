/*
#include <Arduino.h>

#define baudrate 9600   // the baudrate for comms, has to match the baudrate of the driverstation
#define time_out 500    // the number of milliseconds to wait after recieving signal before calling failsafe

byte feedback[10];
byte controller[8];
byte data[8];

boolean connection;
byte x;
byte packet_index;
byte i;
byte size;
byte checkSumTX;    // check sum for transmitting data
byte checkSumRX;    // check sum for recieving data 
unsigned long read_time;

void setup(){
    //declare the serial port for comms
    //the paramater of the begin function is the baudrate
    Serial.begin(9600);

    // initialize the variables to 0
    memset(controller,0,sizeof(controller));
    memset(feedback,0,sizeof(feedback));
    connection = true;
//    failsafe();
    read_time = millis();
    checkSumRX = 0;
    x = 0;
    packet_index = 0;
}

void loop(){
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
            data[packet_index-1] = Serial.read();
            checkSumRX += data[packet_index-1];
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
                    controller[i] = data[i];
                }
                connection = true;
            }
            packet_index=0;
        }
        size--;
    }
    if(connection && millis() - read_time >= time_out){
//        failsafe();
    }

    if(connection){
        // write the code below that you want to run 
        // when the robot recieves valid data of the xbox controller
        // basically all the motor control stuff

        

        
        

        // below is the code for sending feedback to the driver station

        Serial.write(255);
        checkSumTX = 0;
        for(i=0; i<10; i++){
            Serial.write(feedback[i]);
            checkSumTX += feedback[i];
        }
        Serial.write(checkSumTX);
        Serial.write(254);

        read_time = millis();
    }
}

void failsafe(){
    // write the code below that you want to run
    // when the robot loses a signal here

    connection = false;
}
*/
