#ifndef ARDUINO_SENSORMOTORLAB_STEPPERMOTOR_H
#define ARDUINO_SENSORMOTORLAB_STEPPERMOTOR_H

#include "Motor.h"

/*
Represents a stepper motor.
*/
class StepperMotor : public Motor {
  public:
    /*
    Initializes the motor. 
    Parameters:
      pinIds: 
          The ids of the pins allocated to this motor. The motor can use these pins as
          it wishes. This method will return false if too few or too many pins are allocated
          to the motor.
      interruptIds: 
          The interrupt ids allocated to the motor. Can be null. This method will return 
          false if too few or too many interrupts are allocated to the motor.
      errorMessage:
          If initialization is unsuccessful, errorMessage should be set to an explanatory
          message that will be displayed to the user.
    Return Value: True if initialization is successful and False otherwise.
    */
    virtual boolean initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[], String* errorMessage);
    
    /*
    Returns the maximum speed, in revolutions per minute, of which the motor is capable. If
    the motor is not capable of continuous rotation, this will return 0.
    */
    virtual int getMaxSpeedRPM();
    
    /*
    Returns the motor's current speed, in revolutions per minute. Positive values denote counterclockwise
    rotation and negative values denote clockwise rotation. If the motor is not capable of continuous rotation, 
    this will return 0.
    */
    virtual int getSpeedRPM();
    
    /*
    Sets the motor's speed, in revolutions per minute. If the motor is not capable of continuous rotation, 
    this function will have no effect.
    Parameters:
      rpm: 
          The desired speed in revolutions per minute. Positive values denote counterclockwise
          rotation and negative values denote clockwise rotation. If the desired speed exceeds 
          the maximum allowable (either positive or negative) then the maximum will be used instead.
    */
    virtual void setSpeedRPM(int rpm);
    
    /*
    Causes the motor to rotate a specified number of degrees, and then stop. It this function is called
    while the speed is non-zero, the motor will first come to a stop, and then move the specified number
    of degrees.
    Parameters:
      deg: 
          The number of degrees the motor is to rotate. Positive values denote counterclockwise
          rotation and negative values denote clockwise rotation.
    */
    virtual void rotateDegrees(int deg);
    
    /*
    Allows the motor code to do any processing it needs to do, such as reading pins and updating internal
    variables. This method will be called once on every iteration of the main Arduino loop.
    Return Value: True if processing was successful and False otherwise.
    Parameters:
      errorMessage:
          If an error occurs, errorMessage should be set to an explanatory message that will be displayed to the user.
    */
    virtual boolean doProcessing(String* errorMessage); 
};

#endif /* ARDUINO_SENSORMOTORLAB_STEPPERMOTOR_H */



