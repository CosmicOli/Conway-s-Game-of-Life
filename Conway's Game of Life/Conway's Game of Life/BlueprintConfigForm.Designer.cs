namespace Conway_s_Game_of_Life
{
    partial class BlueprintConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourGroupBox = new System.Windows.Forms.GroupBox();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.blackButton = new System.Windows.Forms.RadioButton();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.yInputBox = new System.Windows.Forms.TextBox();
            this.xInputBox = new System.Windows.Forms.TextBox();
            this.xTrackBar = new System.Windows.Forms.TrackBar();
            this.yTrackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.colourGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Save";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // colourGroupBox
            // 
            this.colourGroupBox.Controls.Add(this.redButton);
            this.colourGroupBox.Controls.Add(this.blueButton);
            this.colourGroupBox.Controls.Add(this.blackButton);
            this.colourGroupBox.Location = new System.Drawing.Point(12, 36);
            this.colourGroupBox.Name = "colourGroupBox";
            this.colourGroupBox.Size = new System.Drawing.Size(247, 120);
            this.colourGroupBox.TabIndex = 1;
            this.colourGroupBox.TabStop = false;
            this.colourGroupBox.Text = "Colours";
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(174, 30);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(67, 29);
            this.redButton.TabIndex = 2;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(98, 30);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(70, 29);
            this.blueButton.TabIndex = 1;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // blackButton
            // 
            this.blackButton.AutoSize = true;
            this.blackButton.Location = new System.Drawing.Point(15, 30);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(77, 29);
            this.blackButton.TabIndex = 0;
            this.blackButton.TabStop = true;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(265, 43);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(23, 25);
            this.xLabel.TabIndex = 14;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(265, 104);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(22, 25);
            this.yLabel.TabIndex = 13;
            this.yLabel.Text = "Y";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(653, 60);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 54);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // yInputBox
            // 
            this.yInputBox.Location = new System.Drawing.Point(465, 104);
            this.yInputBox.Name = "yInputBox";
            this.yInputBox.Size = new System.Drawing.Size(150, 31);
            this.yInputBox.TabIndex = 11;
            this.yInputBox.Text = "25";
            this.yInputBox.TextChanged += new System.EventHandler(this.yInputBox_TextChanged);
            this.yInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyInputted);
            // 
            // xInputBox
            // 
            this.xInputBox.Location = new System.Drawing.Point(465, 43);
            this.xInputBox.Name = "xInputBox";
            this.xInputBox.Size = new System.Drawing.Size(150, 31);
            this.xInputBox.TabIndex = 10;
            this.xInputBox.Text = "25";
            this.xInputBox.TextChanged += new System.EventHandler(this.xInputBox_TextChanged);
            this.xInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyInputted);
            // 
            // xTrackBar
            // 
            this.xTrackBar.Location = new System.Drawing.Point(286, 43);
            this.xTrackBar.Maximum = 100;
            this.xTrackBar.Name = "xTrackBar";
            this.xTrackBar.Size = new System.Drawing.Size(156, 69);
            this.xTrackBar.TabIndex = 9;
            this.xTrackBar.Value = 25;
            this.xTrackBar.Scroll += new System.EventHandler(this.xTrackBar_Scroll);
            // 
            // yTrackBar
            // 
            this.yTrackBar.Location = new System.Drawing.Point(286, 104);
            this.yTrackBar.Maximum = 100;
            this.yTrackBar.Name = "yTrackBar";
            this.yTrackBar.Size = new System.Drawing.Size(156, 69);
            this.yTrackBar.TabIndex = 8;
            this.yTrackBar.Value = 25;
            this.yTrackBar.Scroll += new System.EventHandler(this.yTrackBar_Scroll);
            // 
            // BlueprintConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.yInputBox);
            this.Controls.Add(this.xInputBox);
            this.Controls.Add(this.xTrackBar);
            this.Controls.Add(this.yTrackBar);
            this.Controls.Add(this.colourGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlueprintConfigForm";
            this.Text = "Blueprint Editor";
            this.Shown += new System.EventHandler(this.BlueprintConfigForm_Shown);
            this.ResizeEnd += new System.EventHandler(this.BlueprintConfigForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.BlueprintConfigForm_ResizeEnd);
            this.Click += new System.EventHandler(this.BlueprintConfigForm_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.colourGroupBox.ResumeLayout(false);
            this.colourGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.GroupBox colourGroupBox;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton blackButton;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox yInputBox;
        private System.Windows.Forms.TextBox xInputBox;
        private System.Windows.Forms.TrackBar xTrackBar;
        private System.Windows.Forms.TrackBar yTrackBar;
    }
}