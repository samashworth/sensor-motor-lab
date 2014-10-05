#ifndef ARDUINO_SENSORMOTORLAB_MESSENGER_H
#define ARDUINO_SENSORMOTORLAB_MESSENGER_H

#include <Arduino.h>
#include "Message.h"

#define BUFFER_SIZE 20
#define START_CODE 0xFF
#define STOP_CODE 0xDD

class Messenger {
  public:
    static void initialize();
    static void reportError(String message);
    static void printMessage(String message, boolean onlyInDebug);
    static void send(Message message);
    static boolean recieve(Message* message);
    static boolean debugMode;
  private:
    static char buffer[];
    static int bufferPos;
};



#endif /* ARDUINO_SENSORMOTORLAB_MESSENGER_H */