using System;
using System.IO.Ports;
using System.Threading;

namespace UtilityDelta.Server
{
    public class Program
    {
        public static void Main()
        {
            var serialPort = new SerialPort
            {
                BaudRate = 9600,
                PortName = "COM5"
            };

            // Set in Windows
            serialPort.Open();
            var counter = 0;
            while (serialPort.IsOpen)
            {
                // WRITE THE INCOMING BUFFER TO CONSOLE
                while (serialPort.BytesToRead > 0)
                {
                    Console.Write(Convert.ToChar(serialPort.ReadChar()));
                }
                // SEND
                serialPort.WriteLine("PC counter: " + counter++);
                Thread.Sleep(500);
            }
        }
    }
}