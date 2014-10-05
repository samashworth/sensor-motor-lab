#ifndef ARDUINO_SENSORMOTORLAB_FORCESENSOR_H
#define ARDUINO_SENSORMOTORLAB_FORCESENSOR_H

#include "Sensor.h"

/*
Represents a force sensor.
*/
class ForceSensor : public Sensor {
  public:
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);
	
    virtual float getReading();
	
    virtual byte getRelativeReading();
	
    virtual SensorInfo getSensorInfo();
	
    virtual void doProcessing(); 
};

#endif /* ARDUINO_SENSORMOTORLAB_FORCESENSOR_H */


