#ifndef ARDUINO_SENSORMOTORLAB_MESSENGER_H
#define ARDUINO_SENSORMOTORLAB_MESSENGER_H

#include <Arduino.h>
#include "Message.h"

class Messenger {
  public:
    static void initialize();
    static void reportError(String message);
    static void send(Message message);
};



#endif /* ARDUINO_SENSORMOTORLAB_MESSENGER_H */