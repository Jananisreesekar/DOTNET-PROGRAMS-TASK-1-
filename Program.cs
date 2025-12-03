using System;
namespace DeviceMonitor
{
    class TemperatureModule
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temperature Module is running");
            VibrationModule.vibrationcheck();
        }
        class VibrationModule
        {
            public static void vibrationcheck()
            {
                Console.WriteLine("Vibration Module is running");
             
            }
        }
    }
}
               

    