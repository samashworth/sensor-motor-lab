#include "SonarSensor.h"
#include "Misc.h"

void SonarSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
	// TODO @Roger: Implement this.
}

float SonarSensor::getReading()
{
	// TODO @Roger: Implement this.
	return 0.0;
}

byte SonarSensor::getRelativeReading()
{
	// TODO @Roger: Implement this.
	return 0;
}

SensorInfo SonarSensor::getSensorInfo()
{
	// TODO @Roger: Implement this.
	SensorInfo SensorInfo;
	SensorInfo.units = METER;
	SensorInfo.minReading = 0;
	SensorInfo.maxReading = 0;
	
	return SensorInfo;
}

void SonarSensor::doProcessing()
{
	// TODO @Roger: Implement this.
}

