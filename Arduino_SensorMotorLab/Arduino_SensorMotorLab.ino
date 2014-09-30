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

void setup() {
  // Declare variables that we'll use to initalize the motors and sensors.
  String errorMessage;
  int pinIds[5];
  int interruptIds[2];
  
  // Dummy motor initialization.
  pinIds[0] = 0;
  pinIds[1] = 1;
  dummyMotor.initialize(2, pinIds, 0, interruptIds, &errorMessage);  
  
  // Dummy sensor initialization.
  pinIds[0] = 2;
  pinIds[1] = 3;
  dummySensor.initialize(2, pinIds, 0, interruptIds, &errorMessage);
}

void loop() {
  // Let the sensors and motors do whatever processing they need to do.
  String errorMessage;
  dummyMotor.doProcessing(&errorMessage);
  dummySensor.doProcessing(&errorMessage);
}
