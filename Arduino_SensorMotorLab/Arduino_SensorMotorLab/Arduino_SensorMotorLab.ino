#include <Servo.h>
#include <Arduino.h>

#include "Motor.h"
#include "DCMotor.h"
#include "RCServoMotor.h"
#include "StepperMotor.h"
#include "DummyMotor.h"

#include "Sensor.h"
#include "ForceSensor.h"
#include "Potentiometer.h"
#include "SonarSensor.h"
#include "Thermistor.h"
#include "DummySensor.h"

#include "Messenger.h"
#include "Misc.h"
#include "Button.h"
#include "SensorMotorBinding.h"

// Motors
#define MOTOR_COUNT 4
//#define MOTOR_COUNT 1
DCMotor dcMotor;
RCServoMotor rcServoMotor;
StepperMotor stepperMotor;
DummyMotor dummyMotor;
Motor* motors[] = { &dcMotor, &rcServoMotor, &stepperMotor, &dummyMotor };
//Motor* motors[] = { &dummyMotor };

// Sensors
#define SENSOR_COUNT 5
//#define SENSOR_COUNT 1
ForceSensor forceSensor;
Potentiometer potentiometer;
SonarSensor sonarSensor;
Thermistor thermistor;
DummySensor dummySensor;
Sensor* sensors[] = { &forceSensor, &potentiometer, &sonarSensor, &thermistor, &dummySensor };
//Sensor* sensors[] = { &dummySensor };
  
// Bindings between sensors and motors.
SensorMotorBinding sensorMotorBindings[MOTOR_COUNT];
  
// Button
Button button;

// Other objects
Message message;

long lastPollTime = 0;
long pollingInterval_ms = 2000; // milliseconds

long lastRelativeReadingReportTime = 0;
long relativeReadingReportInterval = 1000;

#define MAX_RELATIVE_READING 255


void setup() { 
  // Initiate communications with client.
  Messenger::initialize();
  
	// Declare variables that we'll use to initialize the motors and sensors.
	int pinIds[5];
	int interruptIds[2];
	
	// TODO @Sam: Find out how many pins each sensor needs and decide which pins will be given
	// to which sensors.
	// TODO @Sam: Initialize all sensors and motors.
	
      //motor- 2 A, 2int(D2-3), 1dig
        Messenger::printMessage("Initialize DC Motor", true);
        pinIds[0] = 2;
        pinIds[1] = 3;
        pinIds[2] = A3;
        pinIds[3] = A4;
        pinIds[4] = 8;
        interruptIds[0] = 2;
        interruptIds[1] = 3;
        sonarSensor.initialize(5, pinIds, 0, interruptIds);
      
        Messenger::printMessage("Initialize Sonar", true);
        pinIds[0] = A1;
        sonarSensor.initialize(1, pinIds, 0, interruptIds);
        
        Messenger::printMessage("Initialize Servo", true);
        pinIds[0] = 10;
        rcServoMotor.initialize(1, pinIds, 0, interruptIds);
        
        Messenger::printMessage("Initialize Thermistor", true);
        pinIds[0] = A2;
        thermistor.initialize(1, pinIds, 0, interruptIds);
        
        Messenger::printMessage("Initialize Stepper Motor", true);
        pinIds[0] = 11;
        stepperMotor.initialize(1, pinIds, 0, interruptIds);   
        
	// Dummy motor initialization
        Messenger::printMessage("Initialize dummy motor", true);
	pinIds[0] = 4;
	pinIds[1] = 5;
	dummyMotor.initialize(2, pinIds, 0, interruptIds);
        
        Messenger::printMessage("Initialize Force Sensor", true);
        pinIds[0] = 0;
        forceSensor.initialize(1,pinIds,0,interruptIds);
	
	// Dummy sensor initialization
	Messenger::printMessage("Initialize dummy sensor", true);
	pinIds[0] = 6;
	pinIds[1] = 8;
	dummySensor.initialize(2, pinIds, 0, interruptIds);
  
  // Setup the sensor/motor bindings.
  Messenger::printMessage("Initialize sensor motor bindings", true);
  for (int i = 0; i < MOTOR_COUNT && i < SENSOR_COUNT; i++) {
    SensorMotorBinding* sensorMotorBinding = &sensorMotorBindings[i];
    sensorMotorBinding->sensorIndex = i;
    sensorMotorBinding->motorIndex = i;
    if (motors[i]->getMotorType() == RC_SERVO_MOTOR)
      sensorMotorBinding->motorFunction = ANGLE;
    else
      sensorMotorBinding->motorFunction = SPEED;
    sensorMotorBinding->isSuppressed = true;
    sensorMotorBinding->direction = CCW;
  }
}

void loop() {  
  // Local variables.
  Sensor* sensor;
  Motor* motor;
  
	// Let each motor/sensor do its work.
	for (int i = 0; i < MOTOR_COUNT; i++)
    motors[i]->doProcessing();
  for (int i = 0; i < SENSOR_COUNT; i++)
    sensors[i]->doProcessing();
	
  // On an interval, read the sensors and motors and return the data to the client.  
  long currentTime = millis();
  if (currentTime - lastPollTime > pollingInterval_ms)
  {
    Messenger::printMessage("Polling", true);
    lastPollTime = currentTime;
    // Poll the sensors.
    Messenger::printMessage("Sensor count " + String(SENSOR_COUNT), true);
    for (int i = 0; i < SENSOR_COUNT; i++) {
      sensor = sensors[i];
      message.messageType = READING_GET;
      message.sensorType = sensor->getSensorType();
      message.messagePayload.payloadFloat = sensor->getReading();
      Messenger::send(message);
    }
    // Poll the motors.
    Messenger::printMessage("Motor count " + String(MOTOR_COUNT), true);
    for (int i = 0; i < MOTOR_COUNT; i++) {
      motor = motors[i];
      if (motor->getMotorType() != RC_SERVO_MOTOR) {
        message.messageType = SPEED_GET;
        message.motorType = motor->getMotorType();
        message.messagePayload.payloadInt = motor->getSpeed();
        Messenger::send(message);
      }      
      if (motor->getMotorType() == RC_SERVO_MOTOR ||
          motor->getMotorType() == DUMMY_MOTOR)
      {
        message.messageType = ANGLE_GET;
        message.motorType = motor->getMotorType();
        message.messagePayload.payloadInt = motor->getAngle();
        Messenger::send(message);        
      }        
    }
  }
  
  // Process commands from the UI
  if (Messenger::recieve(&message)) {
    if (message.messageType == ANGLE_SET || message.messageType == SPEED_SET) {
      // Process angle and speed commands.
      for (int i = 0; i < MOTOR_COUNT; i++) {
        if (motors[i]->getMotorType() == message.motorType) {
          sensorMotorBindings[i].isSuppressed = true;
          if (message.messageType == ANGLE_SET) {
            motors[i]->setAngle(message.messagePayload.payloadInt);
          }
          else {
            motors[i]->setSpeed(message.messagePayload.payloadInt);
          }
          break;
        }
      }
    }
    else if (message.messageType == SENSOR_MOTOR_BINDING_SET) {
      // Process sensor/motor binding commands.
      for (int i = 0; i < MOTOR_COUNT; i++) {
        if (motors[i]->getMotorType() == message.motorType) {
          SensorMotorBinding* sensorMotorBinding = &sensorMotorBindings[i];
          sensorMotorBinding->isSuppressed = false;
          sensorMotorBinding->motorFunction = (MotorFunction)message.messagePayload.payloadByte[0];
          sensorMotorBinding->direction = (Direction)message.messagePayload.payloadByte[1];
          for (int j = 0; j < SENSOR_COUNT; j++) {
            if (sensors[j]->getSensorType() == message.sensorType) {
              sensorMotorBinding->sensorIndex = j;
              break;
            }
          }        
          break;
        }
      }
    }
  }  
  
  // If the button is pressed, stop all motors
  if (button.pressOccurred()) {
    for (int i = 0; i < MOTOR_COUNT; i++) {      
      SensorMotorBinding* sensorMotorBinding = &sensorMotorBindings[i];
      Motor* motor = motors[i];
      sensorMotorBinding->isSuppressed = true;
      motor->setSpeed(0);
      message.messageType = ALL_STOP;
      Messenger::send(message);
    }      
  } 
  
  // If sensors are bound to motors, feed sensor data into the motors.
  int speed, angle;
	for (int i = 0; i < MOTOR_COUNT; i++) {    
    SensorMotorBinding* sensorMotorBinding = &sensorMotorBindings[i];
    if (!sensorMotorBinding->isSuppressed) {
      sensor = sensors[sensorMotorBinding->sensorIndex];
      motor = motors[sensorMotorBinding->motorIndex];
      byte reading = sensor->getRelativeReading();
      if (sensorMotorBinding->motorFunction == SPEED) {
        speed = convertRelativeReadingToSpeed(reading, motor, sensorMotorBinding);
        motor->setSpeed(speed);
      }
      else {
        angle = convertRelativeReadingToAngle(reading, motor, sensorMotorBinding);
        motor->setAngle(angle);
      }
    }
  }   
}

int convertRelativeReadingToSpeed(byte reading, Motor* motor, SensorMotorBinding* sensorMotorBinding) {
  int speed = motor->getMaxSpeed() * reading / MAX_RELATIVE_READING;  
  if (sensorMotorBinding->direction == CW)
    speed *= -1;
  return speed;
}

int convertRelativeReadingToAngle(byte reading, Motor* motor, SensorMotorBinding* sensorMotorBinding) {
  int angle = (int)map(reading, 0, 255, 0, 180);
  long currentTime = millis();
  if (currentTime - lastRelativeReadingReportTime > relativeReadingReportInterval) {
    lastRelativeReadingReportTime = currentTime;
    Messenger::printMessage("relative reading: " + String(reading), true);
    Messenger::printMessage("angle: " + String(angle), true);
  }    
  //if (sensorMotorBinding->direction == CW)
    //angle *= -1;
  return angle;
}
