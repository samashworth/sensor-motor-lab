#ifndef ARDUINO_SENSORMOTORLAB_DCMOTOR_H
#define ARDUINO_SENSORMOTORLAB_DCMOTOR_H

#include "Motor.h"

/*
Represents a DC motor.
*/
class DCMotor : public Motor {
  public:
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);
	
    virtual int getMaxSpeed();
	
    virtual int getSpeed();
	
    virtual void setSpeed(int rpm);
	
    virtual void setAngle(int deg);
	
    virtual void doProcessing();
    
    virtual MotorType getMotorType() { return DC_MOTOR; }
    
  private:
		// If you want, you can put variables here so that you can remember data from one call to the next.
		byte testVar;
};

#endif /* ARDUINO_SENSORMOTORLAB_DCMOTOR_H */


