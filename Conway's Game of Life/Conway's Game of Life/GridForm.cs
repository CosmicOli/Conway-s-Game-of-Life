using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Conway_s_Game_of_Life
{
    public partial class GameForm : Form
    { 
        // This defines the width and height of the grid to be the preset width and height.
        static int X = Globals.width;
        static int Y = Globals.height;

        int[,] colourBoard = new int[X, Y];
        // Colour the numbers are represented by: gray, white, black, blue, red
        //                                         -1     0      1      2    3

        // This defines some variables to exist that get defined later.
        static double widthScalar;
        static double heightScalar;
        static double scalar;
        static int scalarAsInt;

        static int[,] currentBlueprint;
        static int[,] blueprintColourBoardMerged = new int[X, Y];

        public GameForm()
        {
            InitializeComponent();
        }

        // This draws the grid lines.
        public void InitializeGrid()
        {
            Graphics Gr = CreateGraphics();
            Gr.Clear(Color.White);
            Pen pen = new Pen(Brushes.Black);

            for (int i = 0; i < X + 1; i++)
            {
                Gr.DrawLine(pen, Convert.ToInt32(scalar * i), 40, Convert.ToInt32(scalar * i), Convert.ToInt32(40 + Y * scalar));
            }

            for (int j = 0; j < Y + 1; j++)
            {
                Gr.DrawLine(pen, 0, Convert.ToInt32(scalar * j + 40), Convert.ToInt32(X * scalar), Convert.ToInt32(scalar * j + 40));
            }
        }

        // This draws each tile's colour.
        public void DrawBoard()
        {
            Graphics Gr = CreateGraphics();

            InitializeGrid();

            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    int x1 = Convert.ToInt32(scalar * x);
                    int y1 = Convert.ToInt32(scalar * y + 40);

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

        // This is different to DrawBoard() as it does not redraw the grid it only updates the cells themselves.
        public void UpdateDrawnBoard(int[,] currentColourBoard, int[,] previousColourBoard)
        {
            Graphics Gr = CreateGraphics();
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    if (previousColourBoard[x, y] != currentColourBoard[x, y])
                    {
                        int x1 = Convert.ToInt32(scalar * x);
                        int y1 = Convert.ToInt32(scalar * y + 40);
                        switch (currentColourBoard[x, y])
                        {
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
                            case -1:
                                {
                                    Gr.FillRectangle(Brushes.Gray, x1, y1, scalarAsInt, scalarAsInt);
                                    Gr.DrawRectangle(new Pen(Brushes.White), x1, y1, scalarAsInt, scalarAsInt);
                                    break;
                                }
                        }
                    }
                }
            }
        }

        // This updates the backend of the board, evaluating which cells will be alive or dead after a tick.
        public void UpdateBoard(bool draw)
        {
            int[,] temporaryColourBoard = new int[X, Y];
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    int[] colourCount = new int[4];

                    Point[] pregeneratedPoints = { new Point(-1, 1), new Point(0, 1), new Point(1, 1), new Point(-1, 0), new Point(1, 0), new Point(-1, -1), new Point(0, -1), new Point(1, -1) };
                    switch (Globals.planeType)
                    {
                        case 0:
                            foreach (Point p in pregeneratedPoints)
                            {
                                int colour = colourBoard[(x + p.X + X) % X, (y + p.Y + Y) % Y];

                                UpdateCount(colourCount, colour);
                            }
                            break;

                        case 1:
                            foreach (Point p in pregeneratedPoints)
                            {
                                try
                                {
                                    int colour = colourBoard[(x + p.X + X) % X, y + p.Y];

                                    UpdateCount(colourCount, colour);
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    int colour = colourBoard[X - 1 - ((x + p.X + X) % X), (y + p.Y + Y) % Y];

                                    UpdateCount(colourCount, colour);
                                }
                            }
                            break;
                    }
                    
                    int totalCount = colourCount.Sum(); ;
                    bool alive = false;
                    if (colourBoard[x, y] != 0)
                    {
                        alive = true;
                    }

                    if (totalCount == 3 && !alive)
                    {
                        assignColour();
                    }
                    else if (totalCount < 2 || totalCount > 3)
                    {
                        temporaryColourBoard[x, y] = 0;
                    }
                    else if ((totalCount == 2 && alive) || (totalCount == 3 && alive))
                    {
                        temporaryColourBoard[x, y] = colourBoard[x, y];
                    }

                    void assignColour()
                    {
                        if (Array.FindAll(colourCount, x => x == colourCount.Max()).Length == 1)
                        {
                            switch (Array.IndexOf(colourCount, colourCount.Max()))
                            {
                                case 0:
                                    {
                                        temporaryColourBoard[x, y] = -1;
                                        break;
                                    }
                                case 1:
                                    {
                                        temporaryColourBoard[x, y] = 1;
                                        break;
                                    }
                                case 2:
                                    {
                                        temporaryColourBoard[x, y] = 2;
                                        break;
                                    }
                                case 3:
                                    {
                                        temporaryColourBoard[x, y] = 3;
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            temporaryColourBoard[x, y] = -1;
                        }
                    }
                }
            }

            if (draw)
            {
                UpdateDrawnBoard(temporaryColourBoard, colourBoard);
            }
            colourBoard = temporaryColourBoard;

            static void UpdateCount(int[] colourCount, int colour)
            {
                switch (colour)
                {
                    case -1:
                        {
                            colourCount[0]++;
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            colourCount[1]++;
                            break;
                        }
                    case 2:
                        {
                            colourCount[2]++;
                            break;
                        }
                    case 3:
                        {
                            colourCount[3]++;
                            break;
                        }
                }
            }
        }

        // This registers key inputs. 1 draws the grid, 2 fills it in, 3 will update the board by 1 tick, 0 randomly fills the grid and any other button pauses and plays the generation timer.
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '1')
            {
                InitializeGrid();
            }
            else if (e.KeyValue == '2')
            {
                DrawBoard();
            }
            else if (e.KeyValue == '3')
            {
                if (!GenerationTimer.Enabled)
                {
                    UpdateBoard(true);
                }
            }
            else if (e.KeyValue == '0')
            {
                Random random = new Random();
                for (int x = 0; x < X; x++)
                {
                    for (int y = 0; y < Y; y++)
                    {
                        bool alive = Convert.ToBoolean(random.Next(0, 2));
                        if (alive)
                        {
                            colourBoard[x, y] = random.Next(1, 4);
                        }
                        else
                        {
                            colourBoard[x, y] = 0;
                        }
                    }
                }
                DrawBoard();
            }
            else
            {
                if (GenerationTimer.Enabled)
                {
                    GenerationTimer.Enabled = false;
                }
                else if (!blueprintMouseTimer.Enabled)
                {
                    GenerationTimer.Enabled = true;
                }
            }
        }

        // This updates the board when the timer ticks.
        private void GenerationTimer_Tick(object sender, EventArgs e)
        {
            
            UpdateBoard(true);
        }

        // This plays or pauses the game.
        private void playPauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GenerationTimer.Enabled)
            {
                GenerationTimer.Enabled = false;
            }
            else if (!blueprintMouseTimer.Enabled)
            {
                GenerationTimer.Enabled = true;
            }
        }

        // This registers when the tiles are clicked and places either a tile or a blueprint.
        private void GameForm_Click(object sender, EventArgs e)
        {
            // I draw the tile I click on here instead of calling the draw function as it is more efficient to only update the pixels I effect.
            Graphics Gr = CreateGraphics();

            int mouseX = PointToClient(Cursor.Position).X;
            int mouseY = PointToClient(Cursor.Position).Y;

            int gridX = mouseX / scalarAsInt;
            int gridY = (mouseY - 40) / scalarAsInt;

            if (blueprintMouseTimer.Enabled)
            {
                int maximumX = currentBlueprint.GetLength(0);
                int maximumY = currentBlueprint.GetLength(1);

                for (int x = 0; x < maximumX; x++)
                {
                    for (int y = 0; y < maximumY; y++)
                    {
                        if (currentBlueprint[x, y] != 0)
                        {
                            switch (Globals.planeType)
                            {
                                case 0:
                                    {
                                        colourBoard[(gridX + x) % X, (gridY + y) % Y] = (Globals.currentColour + currentBlueprint[x, y] - 2) % 3 + 1;
                                        //UpdateBoard(Gr, (gridX + x) % X, (gridY + y) % Y);
                                        break;
                                    }

                                case 1:
                                    {
                                        try
                                        {
                                            colourBoard[(gridX + x) % X, gridY + y] = (Globals.currentColour + currentBlueprint[x, y] - 2) % 3 + 1;
                                            //UpdateBoard(Gr, (gridX + x) % X, gridY + y);
                                        }
                                        catch (IndexOutOfRangeException)
                                        {
                                            colourBoard[X - 1 - (gridX + x) % X, (gridY + y) % Y] = (Globals.currentColour + currentBlueprint[x, y] - 2) % 3 + 1;
                                            //UpdateBoard(Gr, X - 1 - (gridX + x) % X, (gridY + y) % Y);
                                        }
                                        break;
                                    }
                            }
                        }
                    }
                }
                blueprintMouseTimer.Enabled = false;
            }
            else
            {
                try
                {
                    int x1 = Convert.ToInt32(scalar * gridX);
                    int y1 = Convert.ToInt32(scalar * gridY + 40);

                    int clickedColour = colourBoard[gridX, gridY];
                    if (clickedColour == Globals.currentColour)
                    {
                        colourBoard[gridX, gridY] = 0;
                        Gr.FillRectangle(Brushes.White, x1, y1, scalarAsInt, scalarAsInt);
                        Gr.DrawRectangle(new Pen(Brushes.Black), x1, y1, scalarAsInt, scalarAsInt);
                    }
                    else
                    {
                        colourBoard[gridX, gridY] = Globals.currentColour;

                        switch (Globals.currentColour)
                        {
                            case 1:
                                {
                                    Gr.FillRectangle(Brushes.Black, x1, y1, scalarAsInt, scalarAsInt);
                                    break;
                                }
                            case 2:
                                {
                                    Gr.FillRectangle(Brushes.Blue, x1, y1, scalarAsInt, scalarAsInt);
                                    break;
                                }
                            case 3:
                                {
                                    Gr.FillRectangle(Brushes.Red, x1, y1, scalarAsInt, scalarAsInt);
                                    break;
                                }
                        }
                        Gr.DrawRectangle(new Pen(Brushes.White), x1, y1, scalarAsInt, scalarAsInt);
                    }
                }
                catch (Exception)
                {
                    // Do nothing
                }
            }
        }

        // This opens a settings menu.
        private void popoutMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SettingsForm>().Count() == 0)
            {
                Globals.settingsForm = new SettingsForm();
                Globals.settingsForm.Show();
            }
            else
            {
                Globals.settingsForm.Focus();  
            }
        }

        // This checks whether the settings have updated and adjusts variables accordingly.
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (Globals.change)
            {
                Globals.change = false;
                GenerationTimer.Interval = Globals.clockSpeed;

                if (X != Globals.width || Y != Globals.height)
                {
                    X = Globals.width;
                    Y = Globals.height;

                    blueprintColourBoardMerged = new int[X, Y];

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
                GameForm_ResizeEnd(sender, e);
            }
        }

        // When the screen is resized this creates a scale for the grid to fill the screen adn draws the board.
        private void GameForm_ResizeEnd(object sender, EventArgs e)
        {
            widthScalar = Width / (X + 1);
            heightScalar = (Height - 40) / (Y + 2);
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

        // This does prerequisit functions when the screen loads.
        private void GameForm_Shown(object sender, EventArgs e)
        {
            GameForm_ResizeEnd(sender, e);
        }

        // This takes a blueprint and decompiles it into a useable array.
        private void InsertBlueprint(string blueprint)
        {
            string[] blueprintAs1DArray = blueprint.Split(',');
            int[,] blueprintAs2DArray = new int[Convert.ToInt32(blueprintAs1DArray[1]), Convert.ToInt32(blueprintAs1DArray[0])];

            for (int x = 1; x < Convert.ToInt32(blueprintAs1DArray[0]) + 1; x++)
            {
                for (int y = 1; y < Convert.ToInt32(blueprintAs1DArray[1]) + 1; y++)
                {
                    blueprintAs2DArray[y - 1, x - 1] = Convert.ToInt32(blueprintAs1DArray[1 + y + (x - 1) * Convert.ToInt32(blueprintAs1DArray[1])]);
                }
            }

            currentBlueprint = blueprintAs2DArray;
            Array.Copy(colourBoard, blueprintColourBoardMerged, X * Y);
            GenerationTimer.Enabled = false;
            blueprintMouseTimer.Enabled = true;
        }

        // This creates a "shadow" of the blueprint on the screen before clicking.
        private void blueprintMouseTimer_Tick(object sender, EventArgs e)
        {
            int[,] temporaryColourBoard = new int[X, Y];
            Array.Copy(colourBoard, temporaryColourBoard, X * Y);

            int mouseX = PointToClient(Cursor.Position).X;
            int mouseY = PointToClient(Cursor.Position).Y;

            int gridX = mouseX / scalarAsInt;
            int gridY = (mouseY - 40) / scalarAsInt;

            if (gridX > X - 1)
            {
                gridX = X - 1;
            }
            else if (gridX < 0)
            {
                gridX = 0;
            }

            if (gridY > Y - 1)
            {
                gridY = Y - 1;
            }
            else if (gridY < 0)
            {
                gridY = 0;
            }

            int maximumX = currentBlueprint.GetLength(0);
            int maximumY = currentBlueprint.GetLength(1);

            for (int x = 0; x < maximumX; x++)
            {
                for (int y = 0; y < maximumY; y++)
                {
                    if (currentBlueprint[x, y] != 0)
                    {
                        switch (Globals.planeType)
                        {
                            case 0:
                                {
                                    temporaryColourBoard[(gridX + x) % X, (gridY + y) % Y] = (Globals.currentColour + currentBlueprint[x,y] - 2) % 3 + 1;
                                    break;
                                }
                            case 1:
                                {
                                    try
                                    {
                                        temporaryColourBoard[(gridX + x) % X, gridY + y] = (Globals.currentColour + currentBlueprint[x, y] - 2) % 3 + 1;
                                    }
                                    catch (IndexOutOfRangeException)
                                    {
                                        temporaryColourBoard[X - 1 - (gridX + x) % X, (gridY + y) % Y] = (Globals.currentColour + currentBlueprint[x, y] - 2) % 3 + 1;
                                    }
                                    break;
                                }
                        }
                    }
                }
            }

            UpdateDrawnBoard(temporaryColourBoard, blueprintColourBoardMerged);
            blueprintColourBoardMerged = temporaryColourBoard;
        }

        // When in debug mode, this will cause a hault.
        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // This causes a glider to be summoned.
        private void gliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertBlueprint("3,3,0,0,1,1,0,1,0,1,1");
        }

        // This causes an amoogus to be summoned.
        private void amongusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertBlueprint("5,4,0,1,1,1,1,1,0,0,1,1,1,1,0,1,1,1,0,1,0,1");
        }

        // This loads the custom blueprint file.
        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {

            InsertBlueprint(File.ReadAllText("blueprint.txt"));
        }

        // This opens the custom blueprint screen.
        private void editViewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<BlueprintConfigForm>().Count() == 0)
            {
                Globals.blueprintConfigForm = new BlueprintConfigForm();
                Globals.blueprintConfigForm.Show();
            }
            else
            {
                Globals.blueprintConfigForm.Focus();
            }
        }

        // This saves the board.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = Convert.ToString(X) + "," + Convert.ToString(Y);
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    output += "," + colourBoard[x, y];
                }
            }

            File.WriteAllText("main.txt", output);
        }

        // This loads a saved board.
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] inputBoardAsStringArray = File.ReadAllText("main.txt").Split(',');
            int[,] inputBoard = new int[Convert.ToInt32(inputBoardAsStringArray[1]), Convert.ToInt32(inputBoardAsStringArray[0])];
            Globals.height = Convert.ToInt32(inputBoardAsStringArray[0]);
            Globals.width = Convert.ToInt32(inputBoardAsStringArray[1]);
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
            GameForm_ResizeEnd(sender, e);
        }

        // This displays what the game of life is and how to use it.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conway's Game of Life works on 3 rules:\n1) If a cell has less than 2 or more than 3 neighbours it dies or remains dead.\n2) If a cell has 2 or 3 neighbours, it continues to live if already alive.\n3) If a cell has 3 neighbours and is dead, it becomes alive again.\nPushing 1 draws the grid, 2 fills it in, 3 will update the board by 1 tick, 0 randomly fills the grid and any other button pauses and plays the generation timer.\nClick the tiles to create life.");
        }
    }
}
