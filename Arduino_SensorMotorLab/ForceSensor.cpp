#include "ForceSensor.h"

/*
Initializes the sensor. 
Parameters:
  pinIds: 
      The ids of the pins allocated to this sensor. The sensor can use these pins as
      it wishes. This method will return false if too few or too many pins are allocated
      to the sensor.
  interruptIds: 
      The interrupt ids allocated to the sensor. Can be null. This method will return 
      false if too few or too many interrupts are allocated to the sensor.
  errorMessage:
      If initialization is unsuccessful, errorMessage should be set to an explanatory
      message that will be displayed to the user.
Return Value: True if initialization is successful and False otherwise.
*/
boolean ForceSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[], String* errorMessage)
{
  // TODO @Sowmya: Implement this.
  return false;
}

/*
Returns the current reading from the sensor.
*/
int ForceSensor::getReading()
{
  // TODO @Sowmya: Implement this.
  return 0;
}

/*
Returns info about the readings produced by this sensor. This includes the units of the readings,
the minimum and maximum possible readings, and the scale factor that a consumer of the readings should apply
to the readings.
*/
SensorReadingInfo ForceSensor::getSensorReadingInfo() 
{
  // TODO @Sowmya: Implement this.
  SensorReadingInfo sensorReadingInfo;
  sensorReadingInfo.units = "";
  sensorReadingInfo.minReading = 0;
  sensorReadingInfo.maxReading = 0;
  sensorReadingInfo.scaleFactor = 0;
  
  return sensorReadingInfo;
}

/*
Allows the sensor code to do any processing it needs to do, such as reading pins and updating internal
variables. This method will be called once on every iteration of the main Arduino loop.
Return Value: True if processing was successful and False otherwise.
Parameters:
  errorMessage:
      If an error occurs, errorMessage should be set to an explanatory message that will be displayed to the user.
*/
boolean ForceSensor::doProcessing(String* errorMessage)
{
  // TODO @Sowmya: Implement this.
  return false;
}

