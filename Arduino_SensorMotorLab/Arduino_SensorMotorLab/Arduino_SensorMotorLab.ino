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
#include <Servo.h>

#include "Messenger.h"
#include "Misc.h"
#include "Button.h"
#include "SensorMotorBinding.h"

// Motors
#define MOTOR_COUNT 4
DCMotor dcMotor;
RCServoMotor rcServoMotor;
StepperMotor stepperMotor;
DummyMotor dummyMotor;
Motor* motors[] = { &dcMotor, &rcServoMotor, &stepperMotor, &dummyMotor };

// Sensors
#define SENSOR_COUNT 5
ForceSensor forceSensor;
Potentiometer potentiometer;
SonarSensor sonarSensor;
Thermistor thermistor;
DummySensor dummySensor;
Sensor* sensors[] = { &forceSensor, &potentiometer, &sonarSensor, &thermistor, &dummySensor };
  
// Button
Button button;

// Other objects
Message message;
SensorMotorBinding sensorMotorBindings[MOTOR_COUNT];

long lastSensorPollTime;
int sensorPollingInterval_ms = 1000; // milliseconds

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
	
	// Dummy motor initialization
	pinIds[0] = 4;
	pinIds[1] = 5;
	dummyMotor.initialize(2, pinIds, 0, interruptIds);
	
	// Dummy sensor initialization
	pinIds[0] = 6;
	pinIds[1] = 8;
	dummySensor.initialize(2, pinIds, 0, interruptIds);
  
  // Setup the sensor/motor bindings.
  for (int i = 0; i < MOTOR_COUNT && i < SENSOR_COUNT; i++) {
    SensorMotorBinding* sensorMotorBinding = &sensorMotorBindings[i];
    sensorMotorBinding->sensorIndex = i;
    sensorMotorBinding->motorIndex = i;
    if (motors[i]->getPeripheralType() == RC_SERVO_MOTOR)
      sensorMotorBinding->motorFunction = POSITION;
    else
      sensorMotorBinding->motorFunction = SPEED;
    sensorMotorBinding->isSuppressed = false;
    sensorMotorBinding->direction = CCW;
  }
}

void loop() {
	// Let each motor/sensor do its work.
	for (int i = 0; i < MOTOR_COUNT; i++)
    motors[i]->doProcessing();
  for (int i = 0; i < SENSOR_COUNT; i++)
    sensors[i]->doProcessing();
	
  // On an interval, read the sensors and return the data to the client.  
  long currentTime = millis();
  if (currentTime - lastSensorPollTime > sensorPollingInterval_ms)
  {
    for (int i = 0; i < SENSOR_COUNT; i++) {
      float reading = sensors[i]->getReading();
      message.messageType = READING;
      message.peripheralType = sensors[i]->getPeripheralType();
      message.payload = reading;
      Messenger::send(message);
    }
  }
	
	Sensor* sensor;
  Motor* motor;
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
  int angle = 360 * reading / MAX_RELATIVE_READING;
  if (sensorMotorBinding->direction == CW)
    angle *= -1;
  return angle;
}
