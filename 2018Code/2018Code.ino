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
bool intake_on;

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

  intake_on = false;
}

void loop() {
  // put your main code here, to run repeatedly:
  comm.update();

  if(comm.getFailures() > 6){
    //default values if the communications fail
    data = default_data;
  }

  driveLB.write(data.driveLB);
  driveLF.write(data.driveLF);
  driveRB.write(data.driveRB);
  driveRF.write(data.driveRF);


  //intake stuff
  intakeLeft.setState(data.intakePistons);
  intakeRight.setState(data.intakePistons);
  if(data.intakeMotor && !intake_on){ //toggle intake motor
    intake.write(100); //half speed or something equivalent
    intake_on = true;
  }
  else if(data.intakeMotor && intake_on){
    intake.write(90);
    intake_on = false;
  }

  //pulley motor
  pulleyPiston.setState(data.pulleyPiston);
  if(data.pulleyMotor){
    pulley.write(100); //half speed or something equivalent
  }
  else{
    pulley.write(90);
  }

  //ramp pistons
  rampLeft.setState(data.rampPistons);
  rampLeftMiddle.setState(data.rampPistons);
  rampRightMiddle.setState(data.rampPistons);
  rampRight.setState(data.rampPistons);

  //simon says pistons
  simonLeftFront.setState(data.simon_left_front);
  simonLeftBack.setState(data.simon_left_back);
  simonRightFront.setState(data.simon_right_front);
  simonRightBack.setState(data.simon_right_back);
  
}
