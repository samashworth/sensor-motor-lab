#include "SonarSensor.h"
#include "Misc.h"

void SonarSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
	// TODO @Sonali: Implement this.
}

float SonarSensor::getReading()
{
	// TODO @Sonali: Implement this.
	return 0.0;
}

byte SonarSensor::getRelativeReading()
{
	// TODO @Sonali: Implement this.
	return 0;
}

SensorInfo SonarSensor::getSensorInfo()
{
	// TODO @Sonali: Implement this.
	SensorInfo SensorInfo;
	SensorInfo.units = METER;
	SensorInfo.minReading = 0;
	SensorInfo.maxReading = 0;
	
	return SensorInfo;
}

void SonarSensor::doProcessing()
{
	// TODO @Sonali: Implement this.
}

