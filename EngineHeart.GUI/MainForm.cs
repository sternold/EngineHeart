using Controller;
using EngineHeart.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineHeartRobotGenerator
{
    public partial class MainForm : Form
    {
        RobotController RoboControl = new RobotController();

        Robot CurrentRobot = new Robot();

        public MainForm()
        {
            InitializeComponent();                   
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            CurrentRobot =  RoboControl.CreateRobot(TbName.Text, TbPurpose.Text, 100);
            LbAttributes.DataSource = CurrentRobot.Attributes;
            LbFeatures.DataSource = CurrentRobot.Parts;
        }
    }
}
