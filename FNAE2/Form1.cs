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
                Close();
            }
        }

        public void change(String a, String b)
        {
            switch (b)
            {
                case "Main":
                    StartButton.Enabled = false;
                    StartButton.Visible = false;
                    OptionsButton.Visible = false;
                    OptionsButton.Enabled = false;
                    break;
                case "Game":
                    //End stuff
                    break;
                case "Options":
                    SettingTitle.Visible = false;
                    SettingTitle.Enabled = false;
                    FullscreenLabel.Visible = false;
                    FullscreenLabel.Enabled = false;
                    BackLabel.Visible = false;
                    BackLabel.Enabled = false;
                    break;
            }
            switch (a)
            {
                case "Main":
                    BackgroundImage = Properties.Resources.Menu;
                    StartButton.Enabled = true;
                    StartButton.Visible = true;
                    OptionsButton.Visible = true;
                    OptionsButton.Enabled = true;
                    break;
                case "Game":
                    //Start stuff
                    BackgroundImage = null;
                    break;
                case "Options":
                    BackgroundImage = null; //Replace with a option background
                    SettingTitle.Visible = true;
                    SettingTitle.Enabled = true;
                    FullscreenLabel.Visible = true;
                    FullscreenLabel.Enabled = true;
                    BackLabel.Visible = true;
                    BackLabel.Enabled = true;
                    break;
                default:
                    BackgroundImage = Properties.Resources.Menu;
                    StartButton.Enabled = true;
                    StartButton.Visible = true;
                    OptionsButton.Visible = true;
                    OptionsButton.Enabled = true;
                    break;
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
            change("Game", "Main");
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            change("Options", "Main");
        }

        private void FullscreenLabel_Click(object sender, EventArgs e)
        {
            fullscreen(TopMost);
            FullscreenLabel.Text = "Fullscreen   |   " + TopMost;
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            change("Main", "Options");
        }
    }
}
