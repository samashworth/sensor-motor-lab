#include "DCMotor.h"
#include "Misc.h"

void DCMotor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  // TODO @Sonali: Implement this.
  //check pinIds again
 Position=0;
 Speed=0;
 pwm_value=0;
 speed_set=0;
 
 motor_l1=pinIds[2]; 
 motor_l2=pinIds[3];
 motor_enable=pinIds[4];
 
 c_LeftEncoderPinA=pinIds[0];
 c_LeftEncoderPinB=pinIds[1];
 c_LeftEncoderInterruptA=interruptIds[0];
 c_LeftEncoderInterruptB=interruptIds[1];
 _LeftEncoderTicks=0;
 
 pinMode(motor_enable,OUTPUT);
 pinMode(c_LeftEncoderPinA, INPUT);      // sets pin A as input
 digitalWrite(c_LeftEncoderPinA, LOW);  // turn on pullup resistors
 pinMode(c_LeftEncoderPinB, INPUT);      // sets pin B as input
 digitalWrite(c_LeftEncoderPinB, LOW);// turn on pullup resistors
 
 }

int DCMotor::getMaxSpeed()
{
  // TODO @Sonali: Implement this.  
  return 68;//verify
}

int DCMotor::getSpeed()
{ 
  int p1=0;
  int p2=0;
  Position=_LeftEncoderTicks*0.5;
  p1=_LeftEncoderTicks;
  delay(10); //changed from 100 to 10 for speed test
  p2=_LeftEncoderTicks;
  Speed=(p2-p1)*60/(720*0.01); //changed from .1 to .01 for speed test
  return Speed;
}

void DCMotor::setSpeed(int rpm)
{
  
  speed_set=rpm;
}

void DCMotor::setAngle(int deg)
{
   setSpeed(0);
   _LeftEncoderTicks=0;  
   if(deg<0)
  {
  analogWrite(motor_l1,0);
  analogWrite(motor_l2,255);
  }
  else if (deg>0)
  {
  analogWrite(motor_l1,255);
  analogWrite(motor_l2,0);
  }
  analogWrite(motor_enable,255);
  while (abs(_LeftEncoderTicks*0.5)<abs(deg));
  analogWrite(motor_enable,0);
  delay(20); //what is this for??
}

void DCMotor::doProcessing()
{ 
  Speed=getSpeed();
  if(speed_set<0)
  {
  analogWrite(motor_l1,0);
  analogWrite(motor_l2,255);
  }
  else if (speed_set>0)
  {
  analogWrite(motor_l1,255);
  analogWrite(motor_l2,0);
  }
  pwm_value=computePID(pwm_value,abs(Speed),abs(speed_set)); 
  analogWrite(motor_enable,pwm_value);

}

// Interrupt service routines for the left motor's quadrature encoder
void DCMotor::HandleLeftMotorInterruptA(){
  _LeftEncoderBSet = digitalRead(c_LeftEncoderPinB);
  _LeftEncoderASet = digitalRead(c_LeftEncoderPinA);
  
  _LeftEncoderTicks+=ParseEncoder();
  
  _LeftEncoderAPrev = _LeftEncoderASet;
  _LeftEncoderBPrev = _LeftEncoderBSet;
}

// Interrupt service routines for the right motor's quadrature encoder
void DCMotor::HandleLeftMotorInterruptB(){
  // Test transition;
  _LeftEncoderBSet = digitalRead(c_LeftEncoderPinB);
  _LeftEncoderASet = digitalRead(c_LeftEncoderPinA);
  
  _LeftEncoderTicks+=ParseEncoder();
  
  _LeftEncoderAPrev = _LeftEncoderASet;
  _LeftEncoderBPrev = _LeftEncoderBSet;
}

int DCMotor::ParseEncoder(){
  if(_LeftEncoderAPrev && _LeftEncoderBPrev){
    if(!_LeftEncoderASet && _LeftEncoderBSet) return 1;
    if(_LeftEncoderASet && !_LeftEncoderBSet) return -1;
  }else if(!_LeftEncoderAPrev && _LeftEncoderBPrev){
    if(!_LeftEncoderASet && !_LeftEncoderBSet) return 1;
    if(_LeftEncoderASet && _LeftEncoderBSet) return -1;
  }else if(!_LeftEncoderAPrev && !_LeftEncoderBPrev){
    if(_LeftEncoderASet && !_LeftEncoderBSet) return 1;
    if(!_LeftEncoderASet && _LeftEncoderBSet) return -1;
  }else if(_LeftEncoderAPrev && !_LeftEncoderBPrev){
    if(_LeftEncoderASet && _LeftEncoderBSet) return 1;
    if(!_LeftEncoderASet && !_LeftEncoderBSet) return -1;
  }
}

int DCMotor::computePID(int pwm_value, int Speed, int speed_reqd)
{  float kp=1;
  int speed_error;
  float pidterm;
  speed_error=abs(speed_reqd)-abs(Speed);
  pidterm=kp*speed_error;
  return constrain(pwm_value+int(pidterm),0,255);
}


