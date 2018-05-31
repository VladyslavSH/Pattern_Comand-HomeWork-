using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Devices;

namespace WindowsFormsApp1.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor garageDoor = null;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor; 
        }
        public void Execute()
        {
            garageDoor.Stop();
            garageDoor.Open();
            garageDoor.LightOn();
        }

        public void Undo()
        {
            garageDoor.Stop();
            garageDoor.Close();
            garageDoor.LightOff();
        }
    }
}
