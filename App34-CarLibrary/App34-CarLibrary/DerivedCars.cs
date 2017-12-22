using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App34_CarLibrary
{
    public class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, int cspeed, int mspeed) : base(name, cspeed, mspeed) { }

        public override void TurboBoost()
        {
            engineState = EngineState.EngineDead;
            MessageBox.Show("MiniVan is accelerating........ and it is dead!");
        }
    }

    public class SportCar : Car
    {
        public SportCar() { }
        public SportCar(string name, int cspeed, int mspeed) : base(name, cspeed, mspeed) { }

        public override void TurboBoost()
        {
            MessageBox.Show("SportCar is accelerating........... and it is fast as a rocket now!");
        }
    }

}
