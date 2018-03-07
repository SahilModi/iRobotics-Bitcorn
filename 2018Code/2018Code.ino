#include "Config.h"
#include "DoublePiston.h"
#include "SinglePiston.h"
#include "Comm.h"
#include "CommData.h"

#include<Servo.h>

DoublePiston pulleyPiston(PULLEY_PISTON);

DoublePiston intakeLeft(INTAKE_LEFT);
DoublePiston intakeRight(INTAKE_RIGHT);

DoublePiston rampLeft(RAMP_LEFT);
DoublePiston rampLeftMiddle(RAMP_LEFT_MIDDLE);
DoublePiston rampRightMiddle(RAMP_RIGHT_MIDDLE);
DoublePiston rampRight(RAMP_RIGHT);

DoublePiston simonLeftFront(SS_LEFT_FRONT);
DoublePiston simonLeftBack(SS_LEFT_BACK);
DoublePiston simonRightFront(SS_RIGHT_FRONT);
DoublePiston simonRightBack(SS_RIGHT_BACK);

CommData data;
CommData default_data;
Comm comm(&data, 9600);

Servo driveLB;
Servo driveLF;
Servo driveRB;
Servo driveRF;
Servo pulley;
Servo intake;

bool intake_on = false;
bool intake_pistons_trigger = false; //Allows for execution on button RELEASE instead of button push
bool intake_motor_trigger = false;

bool pulley_piston_trigger = false;

bool ramp_pistons_trigger = false;

#define SIMON_SAYS_DELAY 400

void setup() {
  driveLB.attach(DRIVE_LEFT_BACK);
  driveLF.attach(DRIVE_LEFT_FRONT);
  driveRB.attach(DRIVE_RIGHT_BACK);
  driveRF.attach(DRIVE_RIGHT_FRONT);
  pulley.attach(PULLEY_MOTOR);
  intake.attach(INTAKE_MOTOR);

  pinMode(INTAKE_LEFT, OUTPUT);
  pinMode(INTAKE_RIGHT, OUTPUT);
  pinMode(PULLEY_PISTON, OUTPUT);
  
  pinMode(RAMP_LEFT, OUTPUT);
  pinMode(RAMP_LEFT_MIDDLE, OUTPUT);
  pinMode(RAMP_RIGHT_MIDDLE, OUTPUT);
  pinMode(RAMP_RIGHT, OUTPUT);
  
  pinMode(SS_LEFT_FRONT, OUTPUT);
  pinMode(SS_LEFT_BACK, OUTPUT);
  pinMode(SS_RIGHT_FRONT, OUTPUT);
  pinMode(SS_RIGHT_BACK, OUTPUT);
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


  //========================intake========================
  if(data.intakePistons && !intake_pistons_trigger){
    intake_pistons_trigger = true;
  }
  else if(!data.intakePistons && intake_pistons_trigger){
    intakeLeft.switchState();
    intakeRight.switchState();
    intake_pistons_trigger = false;
  }
  if(data.intakeMotor && !intake_motor_trigger){
    intake_motor_trigger = false;
  }
  else if(!data.intakeMotor && intake_motor_trigger){ 
    //toggle intake motor
    if(!intake_on){
      intake.write(150); //faster than half speed
      intake_on = true;
    }
    else{
      intake.write(90);
      intake_on = false;
    }
    intake_motor_trigger = false;
  }

  
  //========================pulley========================
  if(data.pulleyPiston && !pulley_piston_trigger){
    pulley_piston_trigger = true;
  }
  else if(!data.pulleyPiston && pulley_piston_trigger){
    pulleyPiston.switchState();
    pulley_piston_trigger = false;
  }
  if(data.pulleyMotor){
    pulley.write(120); //less than half speed
  }
  else{
    pulley.write(90); //stop
  }
  

  //========================ramp pistons========================
  if(data.rampPistons && !ramp_pistons_trigger){
    ramp_pistons_trigger = true;
  }
  else if(!data.rampPistons && ramp_pistons_trigger){
    rampLeft.switchState();
    rampLeftMiddle.switchState();
    rampRight.switchState();
    rampRightMiddle.switchState();
    ramp_pistons_trigger = false;
  }
  

  //========================simon says pistons========================
  if(data.simon_left_back){
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
