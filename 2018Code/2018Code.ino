#include "Config.h"
#include "DoublePiston.h"
#include "SinglePiston.h"
#include "Comm.h"
#include "CommData.h"

#include<Servo.h>

DoublePiston simonLeftFront(SS_LEFT_FRONT);
DoublePiston simonLeftBack(SS_LEFT_BACK);
DoublePiston simonRightFront(SS_RIGHT_FRONT);
DoublePiston simonRightBack(SS_RIGHT_BACK);

CommData data;
CommData default_data;
SoftwareSerial XBee(10, 2);
Comm comm(&data, 38400, &XBee);//38400, 57600

Servo driveLB;
Servo driveLF;
Servo driveRB;
Servo driveRF;
Servo pulley;

#define SIMON_SAYS_DELAY 400

void setup() {
  driveLB.attach(DRIVE_LEFT_BACK);
  driveLF.attach(DRIVE_LEFT_FRONT);
  driveRB.attach(DRIVE_RIGHT_BACK);
  driveRF.attach(DRIVE_RIGHT_FRONT);
  pulley.attach(PULLEY_MOTOR);
  
  
  pinMode(SS_LEFT_FRONT, OUTPUT);
  pinMode(SS_LEFT_BACK, OUTPUT);
  pinMode(SS_RIGHT_FRONT, OUTPUT);
  pinMode(SS_RIGHT_BACK, OUTPUT);
  
  Serial.begin(9600);
}

/**
 * TODO:
 * Map 0-255 joystick values to 0-180 servo values (DONE)
 * Trigger code on button up (DONE)
 * Change pistons to switch state (DONE)
 * Assignment operator (NOT NEEDED)
 */

void loop() {
  comm.update();

  if(comm.getFailures() > 6){
    //default values if the communications fail
    data = default_data;
  }


  driveLB.write(data.driveLB);
  driveLF.write(data.driveLF);

  driveRB.write(data.driveRB);
  driveRF.write(data.driveRF);

  if(data.pulleyMotor){
    pulley.write(150);
  }
  else{
    pulley.write(90);
  }
  
  

  //========================simon says pistons========================
//  Serial.println(data.simon_left_back);
  if(data.simon_left_back){
//    Serial.println("In calibration");
//    int pos = 0;
//      for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
//      // in steps of 1 degree
//      driveRB.write(pos);              // tell servo to go to position in variable 'pos'
//      delay(50);                       // waits 15ms for the servo to reach the position
//    }
//    for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
//      driveRB.write(pos);              // tell servo to go to position in variable 'pos'
//      delay(50);                       // waits 15ms for the servo to reach the position
//      if(pos == 90){
//        Serial.println("Neutral");
//        delay(3000);
//      }
//    }
    simonLeftBack.setState(1);
    delay(SIMON_SAYS_DELAY); 
    simonLeftBack.setState(0);
  }
  if(data.simon_left_front){
    simonLeftFront.setState(1);
    delay(SIMON_SAYS_DELAY); 
    simonLeftFront.setState(0);
  }
  if(data.simon_right_back){
    simonRightBack.setState(1);
    delay(SIMON_SAYS_DELAY); 
    simonRightBack.setState(0);
  }
  if(data.simon_right_front){
    simonRightFront.setState(1);
    delay(SIMON_SAYS_DELAY); 
    simonRightFront.setState(0);
  }
  
}
