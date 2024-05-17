using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Conway_s_Game_of_Life;

namespace Conway_s_Game_of_Life
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        // This sets the text box for the clock value to the trackbar's value when scrolled.
        private void clockSpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            clockSpeedBox.Text = clockSpeedTrackBar.Value.ToString();
        }

        // This sets the text box for the x value to the trackbar's value when scrolled.
        private void xTrackBar_Scroll(object sender, EventArgs e)
        {
            xInputBox.Text = xTrackBar.Value.ToString(); 
        }

        // This sets the text box for the y value to the trackbar's value when scrolled.
        private void yTrackBar_Scroll(object sender, EventArgs e)
        {
            yInputBox.Text = yTrackBar.Value.ToString();
        }

        // This sets the trackbar for the clock value to the trackbar's value when scrolled.
        private void clockSpeedBox_TextChanged(object sender, EventArgs e)
        {
            BoxTextChanged(clockSpeedBox, clockSpeedTrackBar, 10);
        }

        // This sets the trackbar for the x value to the trackbar's value when scrolled.
        private void xInputBox_TextChanged(object sender, EventArgs e)
        {
            BoxTextChanged(xInputBox, xTrackBar, 1);
        }

        // This sets the trackbar for the y value to the trackbar's value when scrolled.
        private void yInputBox_TextChanged(object sender, EventArgs e)
        {
            BoxTextChanged(yInputBox, yTrackBar, 1);
        }

        // This handles key inputs for when text boxes are updated. It disallows non-integers.
        private void keyInputted(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        // When a text box is changed this makes sure the value is not out of bounds.
        private void BoxTextChanged(TextBox textBox, TrackBar trackBar, int modifier)
        {
            int integerValue; 
            try
            {
                integerValue = Convert.ToInt32(textBox.Text);
                trackBar.Value = integerValue;
            }
            catch (Exception)
            {
                if (textBox.Text == "")
                {
                    trackBar.Value = trackBar.Minimum;
                }
                else
                {
                    trackBar.Value = trackBar.Maximum;
                }
                textBox.Text = trackBar.Value.ToString();
            }
        }

        // This changes the global variables to equal what the settings say.
        private void updateButton_Click(object sender, EventArgs e)
        {
            Globals.change = true;
            Globals.width = xTrackBar.Value;
            Globals.height = yTrackBar.Value;
            Globals.clockSpeed = clockSpeedTrackBar.Value * 10;

            if (torusButton.Checked)
            {
                Globals.planeType = 0;
            }
            else if (kleinButton.Checked)
            {
                Globals.planeType = 1;
            }

            if (blackButton.Checked)
            {
                Globals.currentColour = 1;
            }
            else if (blueButton.Checked)
            {
                Globals.currentColour = 2;
            }
            else if (redButton.Checked)
            {
                Globals.currentColour = 3;
            }
        }
    }
}
