#ifndef ARDUINO_SENSORMOTORLAB_SENSORREADINGINFO_H
#define ARDUINO_SENSORMOTORLAB_SENSORREADINGINFO_H

#include <Arduino.h>

/*
Provides information about the readings that come from a particular sensor.
*/
struct SensorReadingInfo {
  // The units of the readings, for example, "lbs". This string will be displayed in the UI.
  String units;
  // The maximum possible reading.
  int maxReading;
  // The minimum possible reading.
  int minReading;
  // The scale factor that should be applied to readings. For example, if scaleFactor is 4
  // then each reading should be multiplied by 10^4. If the scale factor is -2, then
  // each reading should be multiplied by 10^-2.
  int scaleFactor;
};

#endif /* ARDUINO_SENSORMOTORLAB_SENSORREADINGINFO_H */

  
