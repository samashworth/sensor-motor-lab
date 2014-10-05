#ifndef ARDUINO_SENSORMOTORLAB_MESSAGE_H
#define ARDUINO_SENSORMOTORLAB_MESSAGE_H

#include "Misc.h"

#define PAYLOAD_LENGTH 4

union MessagePayload {
  int payloadInt;
  float payloadFloat;
  byte payloadByte[PAYLOAD_LENGTH];
};

class Message {
  public:
    MessageType messageType;
    MotorType motorType;
    SensorType sensorType;
    MessagePayload messagePayload;
};

#endif /* ARDUINO_SENSORMOTORLAB_MESSAGE_H */
