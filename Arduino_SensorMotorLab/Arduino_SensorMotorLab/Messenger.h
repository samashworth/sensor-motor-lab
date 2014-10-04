#ifndef ARDUINO_SENSORMOTORLAB_MESSENGER_H
#define ARDUINO_SENSORMOTORLAB_MESSENGER_H

#include <Arduino.h>

class Messenger {
  public:
    static void reportError(String message);
};



#endif /* ARDUINO_SENSORMOTORLAB_MESSENGER_H */