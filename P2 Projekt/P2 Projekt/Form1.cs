using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Threading;
=======
using System.Timers;
>>>>>>> origin/Test_branch

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
            ThreadStart childref = new ThreadStart(BeepSound);
            Thread NT = new Thread(childref);
            StartBeepThreads();
            //MessageBox.Show("Dette er en test!");
        }

        public void StartBeepThreads()
        {
            ThreadStart childref = new ThreadStart(BeepSound);
            List<Thread> BeepThreads = new List<Thread>();
            for (int i = 0; i < 100; i++)
            {
                BeepThreads.Add(new Thread(childref));
            }
            foreach (Thread thr in BeepThreads)
            {
                thr.Start();
                
            }

        }

        public void BeepSound()
        {
            
            Console.Beep();
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
