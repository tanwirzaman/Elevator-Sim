using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElevatorSim
{
    class Elevator
    {
        private int currentFloor;
        private bool isMoving;
        private bool movingUP;
        private bool upSwitch;
        private bool outSwitch;
        private bool isBraking;

        public bool IsBraking
        {
            get { return isBraking; }
            set { isBraking = value; }
        }

        public bool OutSwitch
        {
            get { return outSwitch; }
            set { outSwitch = value; }
        }

        public bool UpSwitch
        {
            get { return upSwitch; }
            set { upSwitch = value; }
        }
                     
        public int CurrentFloor
        {
            get { return currentFloor; }
            set { currentFloor = value; }
        }
        public bool IsMoving
        {
            get { return isMoving; }
            set { isMoving = value; }
        }
        public bool MovingUP
        {
            get { return movingUP; }
            set { movingUP = value; }
        }
       
        public Elevator()
        {
           
        }
        
    }
}
