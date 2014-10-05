#include "SonarSensor.h"
#include "Misc.h"
#include "Messenger.h"

void SonarSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
        //set constants
        rollingAverageLength = 5;
        maxRange = 1200;
        smooth[rollingAverageLength];
        
        //set pins
        if (numPins != 1){
          Messenger::reportError("ERROR in Sonar Motor Sensor: Number of pins recieved is different than expected");
        }
        sonarPin = pinIds[0];
}

float SonarSensor::getReading()
{
	// Returns reading up to 67cm. Calibrated on desktop.
	return map(runningAverageRaw,0,80,0,maxRange);
}

byte SonarSensor::getRelativeReading()
{
	// Returns the averaged reading calculated in doProcessing
	return runningAverageRaw;
}

SensorInfo SonarSensor::getSensorInfo()
{
	SensorInfo SensorInfo;
	SensorInfo.units = CENTIMETER;
	SensorInfo.minReading = 0;
	SensorInfo.maxReading = 67; 
	//max reading is actually huge. We only care about the first 2 feet, or 67 cm ish. 
        //this implementation will report anything larger than 66cm as 67 cm.
	return SensorInfo;
}

void SonarSensor::doProcessing()
{
	//get current raw value, 0-1023. ceiling 45 (range we care about)      
        int rawValue = analogRead(sonarPin);
        if (rawValue > 44) rawValue = 45;
        
        
        //get rolling average and store in runningAverageRaw
        for (int i = rollingAverageLength;i>1;i--)
        {
            smooth[i-1] = smooth[i-2];
        }
        smooth[0] = rawValue; //place current value at front of list
        int subtotal = 0;
        for (int j = 0; j< (rollingAverageLength) ; j++)
        {
            subtotal += smooth[j];
        }
        runningAverageRaw = subtotal / rollingAverageLength;
        //would be nice but library probably doesn't meet class (dolan's) requirements
        //runningAverageRaw = rollingAverage(smooth,rollingAverageLength,rawValue);
}

