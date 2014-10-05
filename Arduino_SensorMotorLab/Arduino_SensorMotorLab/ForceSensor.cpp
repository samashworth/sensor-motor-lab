#include "ForceSensor.h"
#include "Misc.h"

void ForceSensor::initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[])
{
  int fsrReading;     
  int fsrVoltage;     
  unsigned long fsrResistance;
  unsigned long fsrConductance; 
  long fsrForce;
}

float ForceSensor::getReading()
{
  fsrVoltage = map(fsrRead, 0, 1023, 0, 5000);
  if (fsrVoltage == 0) {
      fsrForce = 0;  
    } else {
              
      fsrResistance = 5000 - fsrVoltage;     // 5V = 5000mV
      fsrResistance *= 10000;                // 10K ohm resistor
      fsrResistance /= fsrVoltage;
      
   
      fsrConductance = 1000000;           // micromhos 
      fsrConductance /= fsrResistance;
       
        if (fsrConductance <= 1000) {
        fsrForce = fsrConductance / 80;            
      } else {
        fsrForce = fsrConductance - 1000;
        fsrForce /= 30;              
      }
    }
  return 0.0;
}

byte ForceSensor::getRelativeReading()
{
  // TODO @Sowmya: Implement this.
  return 0;
}

SensorInfo ForceSensor::getSensorInfo() 
{
  // TODO @Sowmya: Implement this.
  SensorInfo SensorInfo;
  SensorInfo.units = NEWTON;
  SensorInfo.minReading = 0;
  SensorInfo.maxReading = 0;
  
  return SensorInfo;
}

void ForceSensor::doProcessing()
{
  fsrRead = analogRead(fsrPin); 
  
}

