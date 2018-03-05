#include "Config.h"
#include "DoublePiston.h"
#include "SinglePiston.h"
#include "Comm.h"
#include "CommData.h"

#include<Servo.h>

DoublePiston intakeLeft(INTAKE_LEFT);
DoublePiston intakeRight(INTAKE_RIGHT);
CommData data;
CommData default_data;

Comm comm(&data, 9600);

Servo driveLB;
Servo driveLF;
Servo driveRB;
Servo driveRF;

void setup() {
  driveLB.attach(DRIVE_LEFT_BACK);
  driveLF.attach(DRIVE_LEFT_FRONT);
  driveRB.attach(DRIVE_RIGHT_BACK);
  driveRF.attach(DRIVE_RIGHT_FRONT);

  pinMode(INTAKE_LEFT, OUTPUT);
  pinMode(INTAKE_RIGHT, OUTPUT);
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

  intakeLeft.setState(data.intakePistons);
  intakeRight.setState(data.intakePistons);

  
}
