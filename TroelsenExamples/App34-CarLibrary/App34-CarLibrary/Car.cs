using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App34_CarLibrary
{
    //Represents engine state
    public enum EngineState { EngineAlive, EngineDead };

    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState engineState = EngineState.EngineAlive;

        public EngineState EngineState
        {
            get { return engineState; }
        }

        public abstract void TurboBoost();

        public Car() { }

        public Car (string name, int cspeed, int mspeed)
        {
            PetName = name;
            CurrentSpeed = cspeed;
            MaxSpeed = mspeed;
        }

    }
}
