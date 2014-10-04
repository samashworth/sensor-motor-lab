#ifndef ARDUINO_SENSORMOTORLAB_SONARSENSOR_H
#define ARDUINO_SENSORMOTORLAB_SONARSENSOR_H

#include "Sensor.h"

/*
Represents a range sensor.
*/
class SonarSensor : public Sensor {
	public:
	virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);

	virtual float getReading();

	virtual byte getRelativeReading();

	virtual SensorInfo getSensorInfo();

	virtual void doProcessing();
	
	virtual PeripheralType getPeripheralType() { return SONAR_SENSOR; }
	
  private:
	// If you want, you can put variables here so that you can remember data from one call to the next.
	int sonarPin;
        int runningAverageRaw;
        int rollingAverageLength;
        int maxRange;
        int smooth[3];
};

#endif /* ARDUINO_SENSORMOTORLAB_SONARSENSOR_H */


