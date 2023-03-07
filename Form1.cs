using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_slit_mover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MotorControl.Connent();

            if (MotorControl.IsMotorConnected)
            {
                LbConnection.Text = "Connected";
                TbDebugConsole.Enabled = false;
            }
            else
            {
                LbConnection.Text = "Not Connected";
            }
            LbCurrentX.Text= "0";
            LbCurrentY.Text = "0";
            LbCurrentZ.Text = "0";
            LbCurrentSwivel.Text = "0";
            LbCurrentPivot.Text = "0";
            LbCurrentTilt.Text = "0";

            //update pos every 100ms
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //LbCurrentX.Text = MotorControl.GetPosition(MotorControl.Direction.X).ToString();
            //LbCurrentY.Text = MotorControl.GetPosition(MotorControl.Direction.Y).ToString();
            //LbCurrentZ.Text = MotorControl.GetPosition(MotorControl.Direction.Z).ToString();
            //LbCurrentSwivel.Text = MotorControl.GetPosition(MotorControl.Direction.Swivel).ToString();
            //LbCurrentPivot.Text = MotorControl.GetPosition(MotorControl.Direction.Pivot).ToString();
            //LbCurrentTilt.Text = MotorControl.GetPosition(MotorControl.Direction.Tilt).ToString();
        }

        private void btInitMotor_Click(object sender, EventArgs e)
        {
            TbDebugConsole.AppendText("btInitMotorClick\r\n");
            MotorControl.Connent();

            if (MotorControl.IsMotorConnected)
            {
                LbConnection.Text = "Connected";
                TbDebugConsole.Enabled = false;
            }
            else
            {
                LbConnection.Text = "Not Connected";
            }
        }

        private void BtMoveMotor_Click(object sender, EventArgs e)
        {
            TbDebugConsole.AppendText("move motor click\r\n");
            if (MotorControl.IsMotorConnected)
            {
                double x = double.Parse(NudX.Text);
                double y = double.Parse(NudY.Text);
                double z = double.Parse(NudZ.Text);
                double swivel = double.Parse(NudS.Text);
                double pivot = double.Parse(NudP.Text);
                double tilt = double.Parse(NudT.Text);

                MotorControl.MoveTranslation(x, y, z);
                MotorControl.MoveRotation(swivel, tilt, pivot);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LbCurrentX_Click(object sender, EventArgs e)
        {

        }


        private void TbDebugConsole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
