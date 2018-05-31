using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Devices;

namespace WindowsFormsApp1.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        GarageDoor garageDoor = null;
        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Stop();
            garageDoor.Close();
            garageDoor.LightOff();
        }

        public void Undo()
        {
            garageDoor.Stop();
            garageDoor.Open();
            garageDoor.LightOn();
        }
    }
}
