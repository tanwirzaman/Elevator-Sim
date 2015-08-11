using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ElevatorSim
{
    

    public partial class ElevatorSimForm : Form
    {

        Elevator elevator;
        Controller controller;

        public ElevatorSimForm()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);  
        }

        private void ElevatorSimForm_Load(object sender, EventArgs e)
        {
            elevator= new Elevator();
            controller = new Controller(elevator);
            
            elevator.IsMoving = false;
            elevator.CurrentFloor = 1;
            lblElevStatus.Text = "Stopped";
            lblElevCurrFloor.Text = elevator.CurrentFloor.ToString();
            
        }

        private void btnElev1_Click(object sender, EventArgs e)
        {
            controller.GoToFloor(1);
            timer.Enabled = true;
        }

        private void btnElev2_Click(object sender, EventArgs e)
        {
            controller.GoToFloor(2);
            timer.Enabled = true;
        }

        private void btnElev3_Click(object sender, EventArgs e)
        {
            controller.GoToFloor(3);
            timer.Enabled = true;
        }

        private void btnElev4_Click(object sender, EventArgs e)
        {
            controller.GoToFloor(4);
            timer.Enabled = true;
        }

        private void btnElev5_Click(object sender, EventArgs e)
        {
            controller.GoToFloor(5);
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
             
           
            if (controller.PrimaryStack.Count == 0)
            {
                if (controller.SecondaryStack.Count != 0)
                {
                    controller.GotoSecondary();
                    
                }
                else
                {
                    lblElevStatus.Text = "Stopped";
                    timer.Enabled = false;
                    elevator.IsMoving = false;
                    elevator.IsBraking = false;
                    return;
                }
            }
            if (elevator.IsBraking)
            {
                elevator.IsBraking = false;
                return;
            }
            if (controller.PrimaryStack.Peek() > elevator.CurrentFloor)
                elevator.MovingUP = true;
            else
                elevator.MovingUP = false;
            int floorToReach = controller.PrimaryStack.Peek();

            if(elevator.MovingUP)
                lblElevStatus.Text = "Moving UP";
            else
                lblElevStatus.Text = "Moving DOWN";
           
            label11.Text = "" + controller.PrimaryStack.Peek();
            
            
            if (floorToReach != elevator.CurrentFloor && elevator.MovingUP && controller.PrimaryStack.Count != 0)
            {
                elevator.CurrentFloor++;
                if (elevator.CurrentFloor == controller.PrimaryStack.Peek())
                {
                    controller.PrimaryStack.Pop();
                    lblElevStatus.Text = "Stopped";
                    elevator.IsBraking = true;
                    
                }
                //if(elevator.CurrentFloor <= 5)
                lblElevCurrFloor.Text = "" + elevator.CurrentFloor;
            }
            if (floorToReach != elevator.CurrentFloor && !elevator.MovingUP && controller.PrimaryStack.Count != 0)
            {
                elevator.CurrentFloor--;
                if (elevator.CurrentFloor == controller.PrimaryStack.Peek())
                {
                    controller.PrimaryStack.Pop();
                    lblElevStatus.Text = "Stopped";
                    elevator.IsBraking = true;
                    
                }
                //if (elevator.CurrentFloor  >=1)
                lblElevCurrFloor.Text = "" + elevator.CurrentFloor;
            }
            
        }

        private void btnOut1up_Click(object sender, EventArgs e)
        {
            elevator.OutSwitch = true;
            elevator.UpSwitch = false;
            controller.GoToFloor(1);
            timer.Enabled = true;
        }

        private void btnOut2up_Click(object sender, EventArgs e)
        {
            elevator.OutSwitch = true;
            elevator.UpSwitch = true;
            controller.GoToFloor(2);
            timer.Enabled = true;
        }

        private void btnOut3up_Click(object sender, EventArgs e)
        {
            elevator.OutSwitch = true;
            elevator.UpSwitch = true;
            controller.GoToFloor(3);
            timer.Enabled = true;
        }

        private void btnOut4up_Click(object sender, EventArgs e)
        {

            elevator.OutSwitch = true;
            elevator.UpSwitch = true;
            controller.GoToFloor(4);
            timer.Enabled = true;
        }

        private void btnOut2down_Click(object sender, EventArgs e)
        {
            elevator.OutSwitch = true;
            elevator.UpSwitch = false;
            controller.GoToFloor(2);
            timer.Enabled = true;
        }

        private void btnOut3down_Click(object sender, EventArgs e)
        {
            elevator.OutSwitch = true;
            elevator.UpSwitch = false;
            controller.GoToFloor(3);
            timer.Enabled = true;
        }

        private void btnOut4down_Click(object sender, EventArgs e)
        {
            elevator.OutSwitch = true;
            elevator.UpSwitch = false;
            controller.GoToFloor(4);
            timer.Enabled = true;
        }

        private void btnOut5down_Click(object sender, EventArgs e)
        {
            elevator.OutSwitch = true;
            elevator.UpSwitch = false;
            controller.GoToFloor(5);
            timer.Enabled = true;
        }

        
    }
}

