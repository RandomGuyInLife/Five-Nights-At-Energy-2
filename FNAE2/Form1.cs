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
        double actualWidth, actualHeight;
        const double originalWidth = 816, originalHeight = 489;
        String curretScreen = "Main";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            actualWidth = Bounds.Width;
            actualHeight = Bounds.Height;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey) {
                Fullscreen(TopMost);
                GeneralResize();
            } else if (e.KeyCode == Keys.Escape) {
                Close();
            }
        }

        public void Change(String a)
        {
            switch (curretScreen)
            {
                case "Main":
                    StartButton.Enabled = false;
                    StartButton.Visible = false;
                    OptionsButton.Visible = false;
                    OptionsButton.Enabled = false;
                    break;
                case "Game":
                    //End stuff
                    MapImage.Visible = false;
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
                    MapImage.Visible = true;
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
            curretScreen = a;
        }

        public void Fullscreen(bool a)
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
            GeneralResize();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Change("Game");
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            Change("Options");
        }

        private void FullscreenLabel_Click(object sender, EventArgs e)
        {
            Fullscreen(TopMost);
            FullscreenLabel.Text = "Fullscreen   |   " + TopMost.ToString();
        }

        public void GeneralResize()
        {
            //TODO Make smoother duing fullscreen and non fullscreen transitions
            actualWidth = Bounds.Width;
            actualHeight = Bounds.Height;
            double heightRatio = actualHeight / originalHeight;
            double widthRatio = actualWidth / originalWidth;
            StartButton.Location = new Point((int)Math.Round(361*widthRatio), (int)Math.Round(182 * heightRatio));
            StartButton.Size = new Size((int)Math.Round(75 * widthRatio), (int)Math.Round(23 * heightRatio));
            OptionsButton.Location = new Point((int)Math.Round(361 * widthRatio), (int)Math.Round(210 * heightRatio));
            OptionsButton.Size = new Size((int)Math.Round(75 * widthRatio), (int)Math.Round(23 * heightRatio));
            SettingTitle.Location = new Point((int)Math.Round(10 * widthRatio), (int)Math.Round(9 * heightRatio));
            SettingTitle.Size = new Size((int)Math.Round(265 * widthRatio), (int)Math.Round(73 * heightRatio));
            SettingTitle.Font = new Font("Microsoft Sans Serif", ((float)actualWidth) / ((float)originalWidth), FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void ResizeEvent(object sender, EventArgs e)
        {
            GeneralResize();
            Console.WriteLine("Hi!");
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            Change("Main");
        }
    }
}
