#ifndef COMM_DATA_H_
#define COMM_DATA_H_

struct CommData{
  byte driveLB;
  byte driveLF;
  byte driveRB;
  byte driveRF;

  int intakePistons;
  int intakeMotor;
   
  int rampPistons;
  
  int pulleyPiston;
  int pulleyMotor;

  int simon_left_front;
  int simon_left_back;
  int simon_right_front;
  int simon_right_back;

  /**
   * Default configuration
   */
  CommData() :
    driveLB(90),
    driveLF(90),
    driveRB(90),
    driveRF(90),
    intakeMotor(0),
    pulleyMotor(90),
    intakePistons(0),
    rampPistons(0),
    pulleyPiston(0),
    simon_left_front(0),
    simon_left_back(0),
    simon_right_front(0),
    simon_right_back(0)
  {}
};

#endif
