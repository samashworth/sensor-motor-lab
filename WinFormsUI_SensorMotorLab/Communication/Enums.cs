using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public enum Units { NEWTON, CENTIMETER, CELSIUS };

    public enum MotorType { DC_MOTOR, RC_SERVO_MOTOR, STEPPER_MOTOR, DUMMY_MOTOR };

    public enum SensorType { FORCE_SENSOR, POTENTIOMETER, SONAR_SENSOR, THERMISTOR, DUMMY_SENSOR };

    public enum MessageType { READING_GET, ANGLE_GET, ANGLE_SET, SPEED_GET, SPEED_SET, ERROR_GET, STRING_GET, SENSOR_MOTOR_BINDING_SET, ALL_STOP };

    public enum MotorFunction { SPEED, ANGLE };

    public enum Direction { CCW, CW };

    public class Namer
    {
        public static string ToShortName(MotorType t)
        {
            switch(t)
            {
                case MotorType.DC_MOTOR:
                    return "DC";
                case MotorType.RC_SERVO_MOTOR:
                    return "Servo";
                case MotorType.STEPPER_MOTOR:
                    return "Stepper";
                case MotorType.DUMMY_MOTOR:
                    return "Dummy";
                default:
                    throw new ArgumentException("Invalid motor type: " + t);
            }
        }

        public static string ToLongName(MotorType t)
        {
            switch (t)
            {
                case MotorType.DC_MOTOR:
                    return "DC Motor";
                case MotorType.RC_SERVO_MOTOR:
                    return "Servo Motor";
                case MotorType.STEPPER_MOTOR:
                    return "Stepper Motor";
                case MotorType.DUMMY_MOTOR:
                    return "Dummy Motor";
                default:
                    throw new ArgumentException("Invalid motor type: " + t);
            }
        }

        public static MotorType MotorTypeFromShortName(string n)
        {
            foreach (MotorType motorType in Enum.GetValues(typeof(MotorType)))
            {
                if (String.Equals(ToShortName(motorType), n, StringComparison.OrdinalIgnoreCase))
                {
                    return motorType;
                }
            }
            throw new ArgumentException("Invalid motor type name: " + n);
        }

        public static string ToShortName(SensorType t)
        {
            switch (t)
            {
                case SensorType.FORCE_SENSOR:
                    return "Force";
                case SensorType.POTENTIOMETER:
                    return "Pot";
                case SensorType.SONAR_SENSOR:
                    return "Sonar";
                case SensorType.THERMISTOR:
                    return "Thermistor";
                case SensorType.DUMMY_SENSOR:
                    return "Dummy";
                default:
                    throw new ArgumentException("Invalid sensor type: " + t);
            }
        }

        public static string ToLongName(SensorType t)
        {
            switch (t)
            {
                case SensorType.FORCE_SENSOR:
                    return "Force Sensor";
                case SensorType.POTENTIOMETER:
                    return "Potentiometer";
                case SensorType.SONAR_SENSOR:
                    return "Sonar Sensor";
                case SensorType.THERMISTOR:
                    return "Thermistor";
                case SensorType.DUMMY_SENSOR:
                    return "Dummy Sensor";
                default:
                    throw new ArgumentException("Invalid sensor type: " + t);
            }
        }

        public static SensorType SensorTypeFromShortName(string n)
        {
            foreach (SensorType sensorType in Enum.GetValues(typeof(SensorType)))
            {
                if (String.Equals(ToShortName(sensorType), n, StringComparison.OrdinalIgnoreCase))
                {
                    return sensorType;
                }
            }
            throw new ArgumentException("Invalid sensor type name: " + n);
        }

        public static SensorType SensorTypeFromLongName(string n)
        {
            foreach (SensorType sensorType in Enum.GetValues(typeof(SensorType)))
            {
                if (String.Equals(ToLongName(sensorType), n, StringComparison.OrdinalIgnoreCase))
                {
                    return sensorType;
                }
            }
            throw new ArgumentException("Invalid sensor type name: " + n);
        }

        public static MessageType MessageTypeFromShortName(string n)
        {
            switch (n.ToLower())
            {
                case "speed":
                    return MessageType.SPEED_SET;
                case "angle":
                    return MessageType.ANGLE_SET;
                case "binding":
                    return MessageType.SENSOR_MOTOR_BINDING_SET;
            }
            throw new ArgumentException("Invalid message type name: " + n);
        }
    }
}
