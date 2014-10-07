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
    
       
  private:
		// If you want, you can put variables here so that you can remember data from one call to the next.
		void HandleLeftMotorInterruptA();
                void HandleLeftMotorInterruptB();
                int ParseEncoder();
                int computePID(int pwm_value, int Speed, int speed_reqd);
                
                int Position;
                int Speed;
                int pwm_value;
                int speed_reqd;
                
                int motor_l1;
                int motor_l2;
                int motor_enable;
                
                int c_LeftEncoderPinA;
                int c_LeftEncoderPinB;
                int c_LeftEncoderInterruptA;
                int c_LeftEncoderInterruptB;
                
                volatile bool _LeftEncoderASet;
                volatile bool _LeftEncoderBSet;
                volatile bool _LeftEncoderAPrev;
                volatile bool _LeftEncoderBPrev;
                volatile long _LeftEncoderTicks;
                
};

#endif /* ARDUINO_SENSORMOTORLAB_DCMOTOR_H */


