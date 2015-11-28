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
        List<Label> LabelsAttributes; 

        public MainForm()
        {
            InitializeComponent();
            LabelsAttributes = new List<Label> { Lbl1, Lbl2, Lbl3, Lbl4, Lbl5, Lbl6, Lbl7, Lbl8, Lbl9, Lbl10, Lbl11, Lbl12, Lbl13 };                     
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            EhRobot Robot = new EhRobot(100);
            for (int i = 0; i < LabelsAttributes.Count; i++)
            {
                LabelsAttributes[i].Text = Robot.AttributeValue(i).ToString();
            } 
        }
    }
}
