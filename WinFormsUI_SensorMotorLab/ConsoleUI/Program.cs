using Communication;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static bool isQuiet = true;

        static void Main(string[] args)
        {
            try
            {
                string comPortName = ConfigurationManager.AppSettings["COMPortName"];
                using (Messenger messenger = new Messenger(comPortName))
                {
                    messenger.MessageReceived += messenger_MessageReceived;
                    while (true)
                    {
                        try
                        {
                            string command = Console.ReadLine().Trim();
                            if (command == "quit" || command == "exit")
                            {
                                break;
                            }
                            else if (command == "quiet")
                            {
                                isQuiet = !isQuiet;
                            }
                            else
                            {
                                Message message = new Message();
                                string[] commandParts =
                                    (from c in command.Split(',')
                                     select c.Trim().ToLower()).ToArray();
                                message.MessageType = messageTypeNameToType(commandParts[0]);
                                if (message.MessageType == MessageType.ANGLE_SET || message.MessageType == MessageType.SPEED_SET)
                                {
                                    message.MotorType = motorNameToType(commandParts[1]);
                                    message.Payload = short.Parse(commandParts[2]);
                                }
                                else if (message.MessageType == MessageType.SENSOR_MOTOR_BINDING_SET)
                                {
                                    message.MotorType = motorNameToType(commandParts[1]);
                                    message.SensorType = sensorNameToType(commandParts[2]);
                                    byte[] payload = new byte[2];
                                    payload[0] = (byte)(MotorFunction)Enum.Parse(typeof(MotorFunction), commandParts[3], true);
                                    payload[1] = (byte)(Direction)Enum.Parse(typeof(Direction), commandParts[4], true);
                                    message.Payload = payload;
                                }
                                messenger.Send(message);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Press return to exit...");
                Console.ReadLine();
            }
        }

        private static void messenger_MessageReceived(MessageReceivedEventArgs eventArgs, object sender)
        {
            Message message = eventArgs.Message;
            if (message.MessageType == MessageType.ERROR_GET)
            {
                Console.WriteLine("{0}\t{1}", message.MessageType, (string)message.Payload);
            }
            else if (message.MessageType == MessageType.STRING_GET)
            {
                string payload = (string)message.Payload;
                if ((payload.Contains("setSpeed") || payload.Contains("setAngle") || payload.Contains("Binding")) ||
                    ((payload.Contains("bindingSuppressed") || payload.Contains("getRelativeReading")) && !isQuiet))
                {
                    Console.WriteLine("{0}\t{1}", message.MessageType, (string)message.Payload);
                }
            }
            else if (!isQuiet)
            {
                if (message.MessageType == MessageType.ANGLE_GET || message.MessageType == MessageType.SPEED_GET)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", message.MessageType, message.MotorType, (short)message.Payload);
                }
                else if (message.MessageType == MessageType.READING_GET)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", message.MessageType, message.SensorType, (float)message.Payload);
                }
            }
        }

        private static MessageType messageTypeNameToType(string name)
        {
            MessageType messageType = default(MessageType);
            switch (name)
            {
                case "speed":
                    messageType = MessageType.SPEED_SET;
                    break;
                case "angle":
                    messageType = MessageType.ANGLE_SET;
                    break;
                case "binding":
                    messageType = MessageType.SENSOR_MOTOR_BINDING_SET;
                    break;
            }
            return messageType;
        }

        private static MotorType motorNameToType(string name)
        {
            MotorType motorType = default(MotorType);
            switch (name)
            {
                case "dc":
                    motorType = MotorType.DC_MOTOR;
                    break;
                case "servo":
                    motorType = MotorType.RC_SERVO_MOTOR;
                    break;
                case "stepper":
                    motorType = MotorType.STEPPER_MOTOR;
                    break;
                case "dummy":
                    motorType = MotorType.DUMMY_MOTOR;
                    break;
            }
            return motorType;
        }

        private static SensorType sensorNameToType(string name)
        {
            SensorType sensorType = default(SensorType);
            switch (name)
            {
                case "force":
                    sensorType = SensorType.FORCE_SENSOR;
                    break;
                case "pot":
                    sensorType = SensorType.POTENTIOMETER;
                    break;
                case "sonar":
                    sensorType = SensorType.SONAR_SENSOR;
                    break;
                case "thermistor":
                    sensorType = SensorType.THERMISTOR;
                    break;
                case "dummy":
                    sensorType = SensorType.DUMMY_SENSOR;
                    break;
            }
            return sensorType;
        }
    }
}
