#ifndef ARDUINO_SENSORMOTORLAB_SENSORMOTORBINDING_H
#define ARDUINO_SENSORMOTORLAB_SENSORMOTORBINDING_H

#include <Arduino.h>
#include "Misc.h"

struct SensorMotorBinding {
    int sensorIndex;
    int motorIndex;
    MotorFunction motorFunction;
    boolean isSuppressed;
    Direction direction;
};



#endif /* ARDUINO_SENSORMOTORLAB_SENSORMOTORBINDING_H */