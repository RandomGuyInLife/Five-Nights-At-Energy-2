using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNAE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey) {
                fullscreen(TopMost);
            } else if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        public void fullscreen(bool a)
        {
            if (a)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.StartButton.Enabled = false;
            this.StartButton.Visible = false;
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null; //Replace with a option background
            this.StartButton.Enabled = false;
            this.StartButton.Visible = false;
        }
    }
}
