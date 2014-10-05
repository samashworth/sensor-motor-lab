#ifndef ARDUINO_SENSORMOTORLAB_MOTOR_H
#define ARDUINO_SENSORMOTORLAB_MOTOR_H

#include <Arduino.h>
#include "Misc.h"

/*
Represents a motor. Provides functions for moving the motor and querying its speed.
*/
class Motor {
  public:
    /*
    Initializes the motor. 
    Parameters:
	  numPins:
		  The number of pins allocated to this motor. 
      pinIds: 
          The ids of the pins allocated to this motor. The motor can use these pins as
          it wishes.
	  numInterrupts:
	      The number of interrupts allocated to this motor.
      interruptIds: 
          The interrupt ids allocated to the motor.
    */
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);
    
    /*
    Returns the maximum speed, in revolutions per minute. This is the maximum speed we expect
	to see in the lab demonstration. It is assumed that the maximum speed is the same in either
	direction. This value will be displayed in the UI as an upper limit on the speed that can
	be set. Also, this speed will be used when using a sensor reading to set the motor speed. If
    the motor is not capable of continuous rotation, this will return 0.
    */
    virtual int getMaxSpeed();
    
    /*
    Returns the motor's current speed, in revolutions per minute. Positive values denote counterclockwise
    rotation and negative values denote clockwise rotation. If the motor is not capable of continuous rotation, 
    this will return 0. If the motor has some way of measuring its speed (e.g. an encoder) then that should
	be used to get the return value for this function. Otherwise, the motor should just return the last
	commanded speed.
    */
    virtual int getSpeed();
    
    /*
    Sets the motor's speed, in revolutions per minute. If the motor is not capable of continuous rotation, 
    this function will have no effect.
    Parameters:
      rpm: 
          The desired speed in revolutions per minute. Positive values denote counterclockwise
          rotation and negative values denote clockwise rotation. If the desired speed exceeds 
          the maximum allowable (either positive or negative) then the maximum will be used instead.
    */
    virtual void setSpeed(int rpm);
    
    /*
    Causes the motor to rotate to a specified angle, and then stop. If the motor has an internal
	concept of zero (e.g. a servo motor) then the angle should be relative to this zero position. Otherwise,
	the rotation should be relative to the current position. If this function is called
    while the speed is non-zero, the motor should first come to a stop, and then move the specified number
    of degrees.
    Parameters:
      deg: 
          The number of degrees of the desired angle. Positive values denote counterclockwise
          rotation and negative values denote clockwise rotation.
    */
    virtual void setAngle(int deg);
    
    /*
    Allows the motor code to do any processing it needs to do, such as reading pins and updating internal
    variables. This method will be called once on every iteration of the main Arduino loop.
    */
    virtual void doProcessing();
    
    /*
    Gets the peripheral type of the sensor. PeripheralType is just an enum that contains every motor type and
    sensor type, i.e.:
    enum PeripheralType { DC_MOTOR, RC_SERVO_MOTOR, STEPPER_MOTOR, FORCE_SENSOR, RANGE_SENSOR, THERMISTOR };
    */
    virtual MotorType getMotorType();
};

#endif /* ARDUINO_SENSORMOTORLAB_MOTOR_H */


