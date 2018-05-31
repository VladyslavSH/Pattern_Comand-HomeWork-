using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Devices
{
    public class GarageDoor
    {
        public void Open()
        {
            Console.WriteLine("Garage door is open");
        }
        public void Close()
        {
            Console.WriteLine("Garage door is close");
        }
        public void Stop()
        {
            Console.WriteLine("Garage door is stop");
        }
        public void LightOn()
        {
            Console.WriteLine("Light in garage is on");
        }
        public void LightOff()
        {
            Console.WriteLine("Light in garage is off");
        }

    }
}
