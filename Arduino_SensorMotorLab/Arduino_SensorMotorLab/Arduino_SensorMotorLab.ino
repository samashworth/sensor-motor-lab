#include <Arduino.h>

#include "Motor.h"
#include "DCMotor.h"
#include "RCServoMotor.h"
#include "StepperMotor.h"
#include "DummyMotor.h"

#include "Sensor.h"
#include "ForceSensor.h"
#include "RangeSensor.h"
#include "Thermistor.h"
#include "DummySensor.h"

#include "Misc.h"

// Motors
DCMotor dcMotor;
RCServoMotor rcServoMotor;
StepperMotor stepperMotor;
DummyMotor dummyMotor;

// Sensors
ForceSensor forceSensor;
RangeSensor rangeSensor;
Thermistor thermistor;
DummySensor dummySensor;

long lastSensorPollTime;
int sensorPollingInterval_ms = 1000; // milliseconds


void setup() {
	Serial.begin(9600);
	// Declare variables that we'll use to initialize the motors and sensors.
	int pinIds[5];
	int interruptIds[2];
	boolean initSuccess;
	
	// TODO @Sam: Find out how many pins each sensor needs and decide which pins will be given
	// to which sensors.
	// TODO @Sam: Initialize all sensors and motors.
	
	// Dummy motor initialization
	pinIds[0] = 0;
	pinIds[1] = 1;
	dummyMotor.initialize(2, pinIds, 0, interruptIds);
	
	// Dummy sensor initialization
	pinIds[0] = 2;
	pinIds[1] = 3;
	dummySensor.initialize(2, pinIds, 0, interruptIds);
}

void loop() {
	// Let each motor/sensor do its work.
	// TODO @Sam: Add other motors/sensors here.
	dummyMotor.doProcessing();
	dummySensor.doProcessing();
	
	// TODO @Sam: Only do this on an interval.
	if (false) {
		float reading = dummySensor.getReading();
		// TODO @Sam: Send reading to client.
	}
	
	// TODO @Sam: If a sensor is driving a motor, handle that here.
	if (false) {
		int relativeReading = dummySensor.getRelativeReading();
		if (true) {
			// TODO @Sam: Determine appropriate speed.
			dummyMotor.setSpeed(0);
		}
		else {
			// TODO @Sam: Determine appropriate angle.
			dummyMotor.setAngle(0);
		}
	}
	
	long currentTime = millis();
	if (currentTime - lastSensorPollTime > sensorPollingInterval_ms)
	{
		Serial.println(dummySensor.getReading());
		lastSensorPollTime = currentTime;
	}
}
