#ifndef SINGLE_PISTON_H
#define SINGLE_PISTON_H_

#include <Arduino.h>

class SinglePiston{
  public:
  SinglePiston(int address);
  SinglePiston(int address, int new_state);
  int getState();
  int setState(int new_state);
  int switchState();  
  
  private:
  int pin_address;
  int current_state;
};

#endif
