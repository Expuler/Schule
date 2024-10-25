using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinäreMinute
{
    public partial class Form1 : Form
    {
        private int currentMinute = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentMinute >= 60) 
            { 
                currentMinute = 0;
            }
            currentMinute++;
            BinaryMinute(currentMinute);
           

        }
        private void BinaryMinute(int currentMinute)
        {
            label7.Text = currentMinute.ToString();
            panel6.BackColor = (currentMinute & 32) != 0 ? Color.Pink : Color.Blue;
            panel5.BackColor = (currentMinute & 16) != 0 ? Color.Pink : Color.Blue;
            panel4.BackColor = (currentMinute & 8) != 0 ? Color.Pink : Color.Blue;
            panel3.BackColor = (currentMinute & 4) != 0 ? Color.Pink : Color.Blue;
            panel2.BackColor = (currentMinute & 2) != 0 ? Color.Pink : Color.Blue;
            panel1.BackColor = (currentMinute & 1) != 0 ? Color.Pink : Color.Blue;
        }
    }
}
