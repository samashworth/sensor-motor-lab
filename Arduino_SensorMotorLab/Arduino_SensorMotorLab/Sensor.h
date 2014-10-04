#ifndef ARDUINO_SENSORMOTORLAB_SENSOR_H
#define ARDUINO_SENSORMOTORLAB_SENSOR_H

#include <Arduino.h>
#include "SensorInfo.h"
#include "Misc.h"

/*
Represents a sensor. Facilitates reading the sensor.
*/
class Sensor {
  public:
    /*
    Initializes the sensor. 
    Parameters:
		numPins:
			The number of pins allocated to this sensor.
		pinIds:
			The ids of the pins allocated to this sensor. The sensor can use these pins as
		it wishes.
		numInterrupts:
			The number of interrupts allocated to this sensor.
		interruptIds:
			The interrupt ids allocated to the sensor.
    */
    virtual void initialize(int numPins, int pinIds[], int numInterrupts, int interruptIds[]);
    
    /*
    Returns the current reading from the sensor, in the units measured by the sensor. For example, on a force sensor,
    this function will return a value in newtons.
    */
    virtual float getReading();
    
    /*
    Returns the current reading from the sensor, relative to the sensor's complete range. For example, if the sensor is
    a force sensor and the range of values is expected to be between 0 newtons and 700 newtons and the current reading
    of the sensor is 400 newtons, then this function will return 400 * 255 / 700 = 145.
    */
    virtual byte getRelativeReading();
    
    /*
    Returns info about the readings produced by this sensor. This includes the units of the readings and the minimum
	and maximum possible readings.
    */
    virtual SensorInfo getSensorInfo();
    
    
    /*
    Allows the sensor code to do any processing it needs to do, such as reading pins and updating internal
    variables. This method will be called once on every iteration of the main Arduino loop.
    */
    virtual void doProcessing();
    
    /*
    Gets the peripheral type of the sensor. PeripheralType is just an enum that contains every motor type and
    sensor type, i.e.:
    enum PeripheralType { DC_MOTOR, RC_SERVO_MOTOR, STEPPER_MOTOR, FORCE_SENSOR, RANGE_SENSOR, THERMISTOR };
    */
    virtual PeripheralType getPeripheralType();
};

#endif /* ARDUINO_SENSORMOTORLAB_SENSOR_H */


