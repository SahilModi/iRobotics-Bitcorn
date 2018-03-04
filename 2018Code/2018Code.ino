#include "Config.h"
#include "DoublePiston.h"
#include "SinglePiston.h"

#include<Servo.h>

DoublePiston intakeLeft(INTAKE_LEFT);
DoublePiston intakeRight(INTAKE_RIGHT);

Servo driveLB;
Servo driveLF;
Servo driveRB;
Servo driveRF;

void setup() {
  driveLB.attach(DRIVE_LEFT_BACK);
  driveLF.attach(DRIVE_LEFT_FRONT);
  driveRB.attach(DRIVE_RIGHT_BACK);
  driveRF.attach(DRIVE_RIGHT_FRONT);
  
}

void loop() {
  // put your main code here, to run repeatedly:

}
