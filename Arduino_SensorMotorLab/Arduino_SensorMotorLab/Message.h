#ifndef ARDUINO_SENSORMOTORLAB_MESSAGE_H
#define ARDUINO_SENSORMOTORLAB_MESSAGE_H

#include "Misc.h"

class Message {
  public:
    MessageType messageType;
    PeripheralType peripheralType;
    float payload;
};

#endif /* ARDUINO_SENSORMOTORLAB_MESSAGE_H */
