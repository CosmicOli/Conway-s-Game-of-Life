namespace Conway_s_Game_of_Life
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            popoutMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            blueprintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editViewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            amongusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            GenerationTimer = new System.Windows.Forms.Timer(components);
            updateTimer = new System.Windows.Forms.Timer(components);
            blueprintMouseTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { gameToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, blueprintsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(623, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            gameToolStripMenuItem.Text = "Game";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += popoutMenuToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { popoutMenuToolStripMenuItem, playPauseToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // popoutMenuToolStripMenuItem
            // 
            popoutMenuToolStripMenuItem.Name = "popoutMenuToolStripMenuItem";
            popoutMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            popoutMenuToolStripMenuItem.Text = "Popout Menu";
            popoutMenuToolStripMenuItem.Click += popoutMenuToolStripMenuItem_Click;
            // 
            // playPauseToolStripMenuItem
            // 
            playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            playPauseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            playPauseToolStripMenuItem.Text = "Play/Pause";
            playPauseToolStripMenuItem.Click += playPauseToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { debugToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // debugToolStripMenuItem
            // 
            debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            debugToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            debugToolStripMenuItem.Text = "Debug";
            debugToolStripMenuItem.Click += debugToolStripMenuItem_Click;
            // 
            // blueprintsToolStripMenuItem
            // 
            blueprintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { editViewWindowToolStripMenuItem, amongusToolStripMenuItem, gliderToolStripMenuItem, customToolStripMenuItem });
            blueprintsToolStripMenuItem.Name = "blueprintsToolStripMenuItem";
            blueprintsToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            blueprintsToolStripMenuItem.Text = "Blueprints";
            // 
            // editViewWindowToolStripMenuItem
            // 
            editViewWindowToolStripMenuItem.Name = "editViewWindowToolStripMenuItem";
            editViewWindowToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            editViewWindowToolStripMenuItem.Text = "Edit/View Window";
            editViewWindowToolStripMenuItem.Click += editViewWindowToolStripMenuItem_Click;
            // 
            // amongusToolStripMenuItem
            // 
            amongusToolStripMenuItem.Name = "amongusToolStripMenuItem";
            amongusToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            amongusToolStripMenuItem.Text = "Amongus";
            amongusToolStripMenuItem.Click += amongusToolStripMenuItem_Click;
            // 
            // gliderToolStripMenuItem
            // 
            gliderToolStripMenuItem.Name = "gliderToolStripMenuItem";
            gliderToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            gliderToolStripMenuItem.Text = "Glider";
            gliderToolStripMenuItem.Click += gliderToolStripMenuItem_Click;
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            customToolStripMenuItem.Text = "Custom";
            customToolStripMenuItem.Click += customToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // GenerationTimer
            // 
            GenerationTimer.Tick += GenerationTimer_Tick;
            // 
            // updateTimer
            // 
            updateTimer.Enabled = true;
            updateTimer.Tick += updateTimer_Tick;
            // 
            // blueprintMouseTimer
            // 
            blueprintMouseTimer.Interval = 10;
            blueprintMouseTimer.Tick += blueprintMouseTimer_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(623, 480);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "GameForm";
            Text = "Conway's Game of Life";
            Shown += GameForm_Shown;
            ResizeEnd += GameForm_ResizeEnd;
            SizeChanged += GameForm_ResizeEnd;
            Click += GameForm_Click;
            KeyDown += GameForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popoutMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer GenerationTimer;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueprintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editViewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amongusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gliderToolStripMenuItem;
        private System.Windows.Forms.Timer blueprintMouseTimer;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
