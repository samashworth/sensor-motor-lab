#ifndef ARDUINO_SENSORMOTORLAB_DUMMYSENSOR_H
#define ARDUINO_SENSORMOTORLAB_DUMMYSENSOR_H

#include "Sensor.h"

/*
Represents a dummy sensor for use in testing.
*/
class DummySensor : public Sensor {
  public:
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);

    virtual float getReading();

    virtual byte getRelativeReading();

    virtual SensorInfo getSensorInfo();

    virtual void doProcessing();
    
  private:
		// If you want, you can put variables here so that you can remember data from one call to the next.
		byte testVar;
};

#endif /* ARDUINO_SENSORMOTORLAB_DUMMYSENSOR_H */


