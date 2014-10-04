/* 
	Editor: http://www.visualmicro.com
	        visual micro and the arduino ide ignore this code during compilation. this code is automatically maintained by visualmicro, manual changes to this file will be overwritten
	        the contents of the Visual Micro sketch sub folder can be deleted prior to publishing a project
	        all non-arduino files created by visual micro and all visual studio project or solution files can be freely deleted and are not required to compile a sketch (do not delete your own code!).
	        note: debugger breakpoints are stored in '.sln' or '.asln' files, knowledge of last uploaded breakpoints is stored in the upload.vmps.xml file. Both files are required to continue a previous debug session without needing to compile and upload again
	
	Hardware: Arduino Uno, Platform=avr, Package=arduino
*/

#define __AVR_ATmega328p__
#define __AVR_ATmega328P__
#define ARDUINO 101
#define ARDUINO_MAIN
#define F_CPU 16000000L
#define __AVR__
#define __cplusplus
extern "C" void __cxa_pure_virtual() {;}

//
//
int convertRelativeReadingToSpeed(byte reading, Motor* motor, SensorMotorBinding* sensorMotorBinding);
int convertRelativeReadingToAngle(byte reading, Motor* motor, SensorMotorBinding* sensorMotorBinding);

#include "C:\Program Files (x86)\Arduino\hardware\arduino\variants\standard\pins_arduino.h" 
#include "C:\Program Files (x86)\Arduino\hardware\arduino\cores\arduino\arduino.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Arduino_SensorMotorLab.ino"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Button.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Button.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\DCMotor.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\DCMotor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\DummyMotor.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\DummyMotor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\DummySensor.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\DummySensor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\ForceSensor.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\ForceSensor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Message.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Messenger.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Messenger.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Misc.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Motor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\MotorInfo.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Potentiometer.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Potentiometer.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\RCServoMotor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Sensor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\SensorInfo.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\SensorMotorBinding.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\SonarSensor.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\SonarSensor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\StepperMotor.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\StepperMotor.h"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Thermistor.cpp"
#include "C:\Users\sam\Documents\GitHub\sensor-motor-lab\Arduino_SensorMotorLab\Arduino_SensorMotorLab\Thermistor.h"
