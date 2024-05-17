using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Conway_s_Game_of_Life
{
    public partial class BlueprintConfigForm : Form
    {
        public BlueprintConfigForm()
        {
            InitializeComponent();
        }

        // This sets the width and height of the blueprint to be a standard 25x25 grid.
        static int X = 25;
        static int Y = 25;

        int[,] colourBoard = new int[X, Y];
        // Colour the numbers are represented by: gray, white, black, blue, red
        //                                         -1     0      1      2    3

        // This defines multiple variables that are used throughout.
        static double widthScalar;
        static double heightScalar;
        static double scalar;
        static int scalarAsInt;
        int currentColour = 1;

        private void BlueprintConfigForm_Shown(object sender, EventArgs e)
        {
            BlueprintConfigForm_ResizeEnd(sender, e);
        }

        // When the grid is clicked, the corresponding tile is changed to the selected colour or back to white.
        private void BlueprintConfigForm_Click(object sender, EventArgs e)
        {
            // I draw the tile I click on here instead of calling the draw function as it is more efficient to only update the pixels I effect.
            Graphics Gr = CreateGraphics();

            int mouseX = PointToClient(Cursor.Position).X;
            int mouseY = PointToClient(Cursor.Position).Y;

            int gridX = mouseX / scalarAsInt;
            int gridY = (mouseY - 180) / scalarAsInt;

            try
            {
                int x = Convert.ToInt32(scalarAsInt * gridX);
                int y = Convert.ToInt32(scalarAsInt * gridY + 180);

                int clickedColour = colourBoard[gridX, gridY];
                if (clickedColour == currentColour)
                {
                    colourBoard[gridX, gridY] = 0;
                    Gr.FillRectangle(Brushes.White, x, y, scalarAsInt, scalarAsInt);
                    Gr.DrawRectangle(new Pen(Brushes.Black), x, y, scalarAsInt, scalarAsInt);
                }
                else
                {
                    colourBoard[gridX, gridY] = currentColour;

                    switch (currentColour)
                    {
                        case 1:
                            {
                                Gr.FillRectangle(Brushes.Black, x, y, scalarAsInt, scalarAsInt);
                                break;
                            }
                        case 2:
                            {
                                Gr.FillRectangle(Brushes.Blue, x, y, scalarAsInt, scalarAsInt);
                                break;
                            }
                        case 3:
                            {
                                Gr.FillRectangle(Brushes.Red, x, y, scalarAsInt, scalarAsInt);
                                break;
                            }
                    }
                    Gr.DrawRectangle(new Pen(Brushes.White), x, y, scalarAsInt, scalarAsInt);
                }
            }
            catch (IndexOutOfRangeException)
            {
                // Do nothing
            }
        }

        // This draws the grid lines.
        public void InitializeGrid()
        {
            Graphics Gr = CreateGraphics();
            Gr.Clear(Color.White);
            Pen pen = new Pen(Brushes.Black);

            for (int i = 0; i < X + 1; i++)
            {
                Gr.DrawLine(pen, Convert.ToInt32(scalar * i), 180, Convert.ToInt32(scalar * i), Convert.ToInt32(Y * scalar + 180));
            }

            for (int j = 0; j < Y + 1; j++)
            {
                Gr.DrawLine(pen, 0, Convert.ToInt32(scalar * j + 180), Convert.ToInt32(X * scalar), Convert.ToInt32(scalar * j + 180));
            }
        }

        // This draws each tile's colour.
        private void DrawBoard()
        {
            Graphics Gr = CreateGraphics();
            Gr.Clear(Color.White);

            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    int x1 = Convert.ToInt32(scalar * x);
                    int y1 = Convert.ToInt32(scalar * y + 180);

                    switch (colourBoard[x, y])
                    {
                        case -1:
                            {
                                Gr.FillRectangle(Brushes.Gray, x1, y1, scalarAsInt, scalarAsInt);
                                Gr.DrawRectangle(new Pen(Brushes.White), x1, y1, scalarAsInt, scalarAsInt);
                                break;
                            }
                        case 0:
                            {
                                Gr.FillRectangle(Brushes.White, x1, y1, scalarAsInt, scalarAsInt);
                                Gr.DrawRectangle(new Pen(Brushes.Black), x1, y1, scalarAsInt, scalarAsInt);
                                break;
                            }
                        case 1:
                            {
                                Gr.FillRectangle(Brushes.Black, x1, y1, scalarAsInt, scalarAsInt);
                                Gr.DrawRectangle(new Pen(Brushes.White), x1, y1, scalarAsInt, scalarAsInt);
                                break;
                            }
                        case 2:
                            {
                                Gr.FillRectangle(Brushes.Blue, x1, y1, scalarAsInt, scalarAsInt);
                                Gr.DrawRectangle(new Pen(Brushes.White), x1, y1, scalarAsInt, scalarAsInt);
                                break;
                            }
                        case 3:
                            {
                                Gr.FillRectangle(Brushes.Red, x1, y1, scalarAsInt, scalarAsInt);
                                Gr.DrawRectangle(new Pen(Brushes.White), x1, y1, scalarAsInt, scalarAsInt);
                                break;
                            }
                    }
                }
            }
        }

        // This creates a scale that the grid should be drawn at to fill the screen, then calls for it to be redrawn.
        private void BlueprintConfigForm_ResizeEnd(object sender, EventArgs e)
        {
            widthScalar = Width / (X + 1);
            heightScalar = (Height - 205) / (Y + 2);
            scalar = 0;
            if (widthScalar < heightScalar)
            {
                scalar = widthScalar;
            }
            else
            {
                scalar = heightScalar;
            }
            scalarAsInt = Convert.ToInt32(scalar);
            DrawBoard();
        }

        // This registers when the update button is clicked and updates specific grid values based on any changed settings. Then it calls for a new scale to be made and the board to be redrawn.
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (X != xTrackBar.Value || Y != yTrackBar.Value)
            {
                X = xTrackBar.Value;
                Y = yTrackBar.Value;

                int[,] temporaryColourStorage = new int[X, Y];
                for (int x = 0; x < X; x++)
                {
                    for (int y = 0; y < Y; y++)
                    {
                        try
                        {
                            temporaryColourStorage[x, y] = colourBoard[x, y];
                        }
                        catch (IndexOutOfRangeException)
                        {
                            // Do nothing.
                        }
                    }
                }
                colourBoard = temporaryColourStorage;
            }

            if (blackButton.Checked)
            {
                currentColour = 1;
            }
            else if (blueButton.Checked)
            {
                currentColour = 2;
            }
            else if (redButton.Checked)
            {
                currentColour = 3;
            }

            BlueprintConfigForm_ResizeEnd(sender, e);
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

        // This sets the trackbar for the x value to the text box's value when scrolled.
        private void xInputBox_TextChanged(object sender, EventArgs e)
        {
            BoxTextChanged(xInputBox, xTrackBar);
        }

        // This sets the trackbar for the y value to the text box's value when scrolled.
        private void yInputBox_TextChanged(object sender, EventArgs e)
        {
            BoxTextChanged(yInputBox, yTrackBar);
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
        private void BoxTextChanged(TextBox textBox, TrackBar trackBar)
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

        // This registers the clicking of the save button which then causes the blueprint to save as the custom.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = Convert.ToString(X) + "," + Convert.ToString(Y);
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    output += "," + colourBoard[y, x];
                }
            }

            File.WriteAllText("blueprint.txt", output);
        }

        // This registers the clicking of the load button which then causes the blueprint to be loaded from the custom.
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] inputBoardAsStringArray = File.ReadAllText("blueprint.txt").Split(',');
            int[,] inputBoard = new int[Convert.ToInt32(inputBoardAsStringArray[1]), Convert.ToInt32(inputBoardAsStringArray[0])];
            Y = Convert.ToInt32(inputBoardAsStringArray[0]);
            X = Convert.ToInt32(inputBoardAsStringArray[1]);

            for (int x = 1; x < Convert.ToInt32(inputBoardAsStringArray[0]) + 1; x++)
            {
                for (int y = 1; y < Convert.ToInt32(inputBoardAsStringArray[1]) + 1; y++)
                {
                    inputBoard[y - 1, x - 1] = Convert.ToInt32(inputBoardAsStringArray[1 + y + (x - 1) * Convert.ToInt32(inputBoardAsStringArray[1])]);
                }
            }

            colourBoard = inputBoard;
            BlueprintConfigForm_ResizeEnd(sender, e);
        }
    }
}
