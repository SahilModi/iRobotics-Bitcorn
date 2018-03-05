#ifndef COMM_DATA_H_
#define COMM_DATA_H_

struct CommData{
  byte driveLB;
  byte driveLF;
  byte driveRB;
  byte driveRF;
  
  int rampPistons;

  /**
   * ADD MORE HERE
   */
  
  
  CommData() :
    driveLB(90),
    driveLF(90),
    driveRB(90),
    driveRF(90),
    rampPistons(0)
  {}
};

#endif
