using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttemptZero
{

    public partial class DriverUI : Form
    {
        bool isWindowOpen;
        public DriverUI()
        {
            InitializeComponent();
        }

        private void LogOUT_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void DriverUI_Load(object sender, EventArgs e)
        {
        }

        private void DriverIsOn()
        {
            while (ChecksDriverIsOn.Visible)
            {
                isWindowOpen = true;
            }
            isWindowOpen = false;
        }

        private void gameThread()
        {
            Thread newThread = new Thread(() => DriverIsOn());
            newThread.Start();
        }
    }
}