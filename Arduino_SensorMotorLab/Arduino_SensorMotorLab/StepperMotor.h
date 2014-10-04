#ifndef ARDUINO_SENSORMOTORLAB_STEPPERMOTOR_H
#define ARDUINO_SENSORMOTORLAB_STEPPERMOTOR_H

#include "Motor.h"

/*
Represents a stepper motor.
*/
class StepperMotor : public Motor {
  public:

    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);

    virtual int getMaxSpeed();

    virtual int getSpeed();

    virtual void setSpeed(int rpm);

    virtual void setAngle(int deg);

    virtual void doProcessing();
    
    virtual PeripheralType getPeripheralType() { return STEPPER_MOTOR; }
    
  private:
    // If you want, you can put variables here so that you can remember data from one call to the next.
    byte testVar;
};

#endif /* ARDUINO_SENSORMOTORLAB_STEPPERMOTOR_H */



