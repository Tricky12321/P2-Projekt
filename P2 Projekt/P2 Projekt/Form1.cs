using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace P2_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dette er en test!");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            ++i;
            if (i == 1)
                Console.Beep();
        }
    }
}
