using FASTECH;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_slit_mover
{
    public static class MotorControl
    {
        public enum Direction
        {
            X, Y, Z,
            Tilt, Pivot, Swivel
        }
        public static bool IsMotorConnected
        {
            private set; get;
        }

        public static string[] AvailablePorts
        {
            get
            {
                return SerialPort.GetPortNames();
            }
        }
        public static byte PortNumber
        {
            private set; get;
        }

        static MotorControl()
        {
            //chekc ports
            Connent();
            IsMotorConnected = false;
            //check connection with motors            
        }


        public static void Connent()
        {
            String[] availPorts = SerialPort.GetPortNames(); ;
            for (int i = 0; i < availPorts.Length; i++) {
                byte portNum = byte.Parse(availPorts[i].Substring(3));
                bool isConnected = false;
                CancellationTokenSource cancleToken = new CancellationTokenSource();
                
                Task<Boolean> runFasconnetWithTimeOut = new Task<Boolean>(() =>
                {
                    Debug.WriteLine($"Connection try to {portNum}"); 
                    return EziMOTIONPlusRLib.FAS_Connect(portNum, 115200) != 0;
                });

                Stopwatch sw = Stopwatch.StartNew();

                if (runFasconnetWithTimeOut.Wait(5000))
                {
                    isConnected = runFasconnetWithTimeOut.Result;
                }                

                if (isConnected)
                {
                    //connect!
                    IsMotorConnected = true;
                    PortNumber = portNum;
                    Debug.WriteLine("Connection complete");
                    // connected.
                    int NumberOfMotors = 0;

                    for (byte j = 0; j < EziMOTIONPlusRLib.MAX_SLAVE_NUMS; j++)
                    {
                        if (EziMOTIONPlusRLib.FAS_IsSlaveExist(portNum, j) != 0)
                        {
                            NumberOfMotors += 1;
                        }
                    }

                    if (NumberOfMotors == 0)
                    {
                        Debug.WriteLine($"[Servo Motor] Connected, but motor is not found: Check the Power Supply");
                        return;
                    }

                    if (NumberOfMotors != 0)
                    {
                        IsMotorConnected = true;
                        Debug.WriteLine($"[Servo Motor] {NumberOfMotors}EA Connected");
                    }
                    continue;
                }
            }

            if (!IsMotorConnected)
            {
                Debug.WriteLine("Connection Failed");
            }
        }

        public static bool MoveRotation(double z, double y, double x)
        {
            if (!IsMotorConnected)
            {
                return false;
            }
            
            if (!Move(z, Direction.Swivel))
            {
                return false;
            }

            if (!Move(y, Direction.Tilt))
            {
                return false;
            }
            if (!Move(z, Direction.Z))
            {
                return false;
            }

            return false;
        }
        public static bool MoveTranslation(double x, double y, double z)
        {
            if (!Move(x, Direction.X))
            {
                return false;
            }
            if (!Move(y, Direction.Y))
            {
                return false;
            }
            if (!Move(z, Direction.Z)) {
                return false;
                    }
            return true;
        }

        public static bool Move(double delta, Direction direction)
        {
            if (!IsMotorConnected) { return false; }
            double pulse = 0;
            uint driveSpeed = 0;
            byte[] slaveNumber = new byte[1];
            
            switch (direction)
            {
                case Direction.X:
                    pulse = delta * 3226;
                    driveSpeed = 10_000;
                    slaveNumber[0] = 0;
                    break;
                case Direction.Y:
                    pulse = delta * 81939;
                    driveSpeed = 150_000;
                    slaveNumber[1] = 1;
                    break;
                case Direction.Z:
                    //no implementation
                    return true;
                    break;
                case Direction.Tilt:
                    driveSpeed = 50_000;
                    pulse = delta * 56222;
                    slaveNumber[2] = 2;
                    break;
                case Direction.Pivot:
                    driveSpeed = 50_000;
                    pulse = delta * 6795;
                    slaveNumber[3] = 3;
                    break;
                case Direction.Swivel:
                    driveSpeed = 15_000;
                    pulse = delta * 5022;
                    slaveNumber[4] = 4;
                    break;
            }
            int nRtn;
            int[] pulses = new int[1];
            pulses[0] = (int)Math.Ceiling(pulse);
            
            nRtn = EziMOTIONPlusRLib.FAS_MoveLinearIncPos(PortNumber, 5, slaveNumber, pulses, driveSpeed, 100); // 가감속 시간 100
            if (nRtn != EziMOTIONPlusRLib.FMM_OK)
            {
                Debug.WriteLine($"Error Code: {nRtn} during Multi-Axis Drive");
            }

            return true;
        }
        public static void Stop()
        {
            int nRtn;

            if (IsMotorConnected == false)
                return;

            nRtn = EziMOTIONPlusRLib.FAS_AllMoveStop(PortNumber);
            if (nRtn != EziMOTIONPlusRLib.FMM_OK)
            {
                Debug.WriteLine($"Error Code: {nRtn} during All stop");
            }
        }

    }
}
