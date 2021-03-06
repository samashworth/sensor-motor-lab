#ifndef ARDUINO_SENSORMOTORLAB_DUMMYMOTOR_H
#define ARDUINO_SENSORMOTORLAB_DUMMYMOTOR_H

#include "Motor.h"

/*
Represents a dummy motor for use in testing.
*/
class DummyMotor : public Motor {
  public:
    DummyMotor();
    
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);
	
    virtual int getMaxSpeed();
	
    virtual int getSpeed();
    
    virtual int getAngle();
	
    virtual void setSpeed(int rpm);
	
    virtual void setAngle(int deg);
	
    virtual void doProcessing();
    
    virtual MotorType getMotorType() { return DUMMY_MOTOR; }
    
  private:
    // If you want, you can put variables here so that you can remember data from one call to the next.
    int speed;
    int angle;
};

#endif /* ARDUINO_SENSORMOTORLAB_DUMMYMOTOR_H */



