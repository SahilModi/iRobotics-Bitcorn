#include "SinglePiston.h"

SinglePiston::SinglePiston(int address){
  pin_address = address;
  current_state = 0;
  setState(current_state);
}

SinglePiston::SinglePiston(int address, int state){
  pin_address = address;
  current_state = state;
  setState(current_state);
}

int SinglePiston::setState(int new_state){
  //TODO write set state
  if(current_state == new_state){return current_state;} //already in the set state
  
  digitalWrite(pin_address, new_state);
  current_state = new_state;
  return current_state;
}

int SinglePiston::switchState(){
  if(current_state == 0){
    return setState(1);
  }
  return setState(0);
}

int SinglePiston::getState(){
  return current_state;
}
