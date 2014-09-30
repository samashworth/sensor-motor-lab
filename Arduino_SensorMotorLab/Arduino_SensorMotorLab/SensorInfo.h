#ifndef ARDUINO_SENSORMOTORLAB_SENSORINFO_H
#define ARDUINO_SENSORMOTORLAB_SENSORINFO_H

#include <Arduino.h>
#include "Misc.h"

/*
Provides information about the readings that come from a particular sensor.
*/
struct SensorInfo {
  // The units of the readings. The main code will complain if a given sensor returns units that
  // aren't the expected units (e.g. the force sensor returns meters).
  Units units;
  // The maximum reading expected during the lab demonstration. This isn't necessarily the sensor's
  // maximum possible reading. This value will be used draw the plot axes in the UI. It should also
  // be one of the values that the sensor uses when computing the return value for getRelativeReading.
  int maxReading;
  // The minimum reading expected during the lab demonstration. This isn't necessarily the sensor's
  // minimum possible reading. This value will be used draw the plot axes in the UI. It should also
  // be one of the values that the sensor uses when computing the return value for getRelativeReading.
  int minReading;
};

#endif /* ARDUINO_SENSORMOTORLAB_SENSORINFO_H */

  
