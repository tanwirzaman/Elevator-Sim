using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElevatorSim
{
    class Controller
    {
        private Elevator elevator;
        private Stack<Int32> primaryStack = new Stack<Int32>();
        private Stack<Int32> secondaryStack = new Stack<Int32>();

        public Stack<Int32> SecondaryStack
        {
            get { return secondaryStack; }
            set { secondaryStack = value; }
        }

        public Stack<Int32> PrimaryStack
        {
            get { return primaryStack; }
            set { primaryStack = value; }
        }

        public Controller(Elevator elev) {

            this.elevator = elev;
        }

        public void GotoSecondary()
        {
            if (this.SecondaryStack.Count != 0)
            {
                while (this.SecondaryStack.Count != 0)
                {
                    this.PrimaryStack.Push(this.SecondaryStack.Pop());
                }
                this.PrimaryStack.Reverse();
                
            }

        }

        public void GoToFloor(int floorNum)
        {
            if (floorNum == elevator.CurrentFloor)
                return;
            if (this.PrimaryStack.Count == 0)
            {
                this.PrimaryStack.Push(floorNum);
            }
            else
            {
                if(floorNum == this.PrimaryStack.Peek())
                {
                    return;
                }
            }
            if (elevator.IsMoving)
            {
                if (!elevator.OutSwitch)
                {
                    if (elevator.MovingUP && floorNum < this.PrimaryStack.Peek() && floorNum > elevator.CurrentFloor)
                    {
                        this.PrimaryStack.Push(floorNum);
                    }
                    else if (!elevator.MovingUP && floorNum > this.PrimaryStack.Peek() && floorNum < elevator.CurrentFloor)
                    {
                        this.PrimaryStack.Push(floorNum);
                    }
                    else
                    {
                        this.SecondaryStack.Push(floorNum);
                    }
                }
                else
                {
                    if (elevator.UpSwitch && elevator.MovingUP && floorNum < this.PrimaryStack.Peek() && floorNum > elevator.CurrentFloor)
                    {
                        this.PrimaryStack.Push(floorNum);
                    }
                    else if (!elevator.UpSwitch && !elevator.MovingUP && floorNum > this.PrimaryStack.Peek() && floorNum < elevator.CurrentFloor)
                    {
                        this.PrimaryStack.Push(floorNum);
                    }
                    else
                    {
                        this.SecondaryStack.Push(floorNum);
                    }
                    elevator.OutSwitch = false;
                }
            }
            else
            {
                elevator.IsMoving = true;

                if (elevator.OutSwitch)
                    elevator.OutSwitch = false;
                if (elevator.CurrentFloor < this.PrimaryStack.Peek())
                {
                    elevator.MovingUP = true;
                }
                else
                {
                    elevator.MovingUP = false;

                }
            }
           
        }
    }
}
