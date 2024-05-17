namespace Conway_s_Game_of_Life
{
    partial class SettingsForm
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
            this.edgeStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.kleinButton = new System.Windows.Forms.RadioButton();
            this.torusButton = new System.Windows.Forms.RadioButton();
            this.yTrackBar = new System.Windows.Forms.TrackBar();
            this.xTrackBar = new System.Windows.Forms.TrackBar();
            this.xInputBox = new System.Windows.Forms.TextBox();
            this.yInputBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.clockSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.clockSpeedBox = new System.Windows.Forms.TextBox();
            this.clockSpeedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.colourGroupBox = new System.Windows.Forms.GroupBox();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.blackButton = new System.Windows.Forms.RadioButton();
            this.edgeStyleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockSpeedTrackBar)).BeginInit();
            this.colourGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // edgeStyleGroupBox
            // 
            this.edgeStyleGroupBox.Controls.Add(this.kleinButton);
            this.edgeStyleGroupBox.Controls.Add(this.torusButton);
            this.edgeStyleGroupBox.Location = new System.Drawing.Point(461, 248);
            this.edgeStyleGroupBox.Name = "edgeStyleGroupBox";
            this.edgeStyleGroupBox.Size = new System.Drawing.Size(300, 114);
            this.edgeStyleGroupBox.TabIndex = 0;
            this.edgeStyleGroupBox.TabStop = false;
            this.edgeStyleGroupBox.Text = "Edge Style";
            // 
            // kleinButton
            // 
            this.kleinButton.AutoSize = true;
            this.kleinButton.Location = new System.Drawing.Point(14, 68);
            this.kleinButton.Name = "kleinButton";
            this.kleinButton.Size = new System.Drawing.Size(125, 29);
            this.kleinButton.TabIndex = 1;
            this.kleinButton.TabStop = true;
            this.kleinButton.Text = "Klein Bottle";
            this.kleinButton.UseVisualStyleBackColor = true;
            // 
            // torusButton
            // 
            this.torusButton.AutoSize = true;
            this.torusButton.Location = new System.Drawing.Point(14, 33);
            this.torusButton.Name = "torusButton";
            this.torusButton.Size = new System.Drawing.Size(79, 29);
            this.torusButton.TabIndex = 0;
            this.torusButton.TabStop = true;
            this.torusButton.Text = "Torus";
            this.torusButton.UseVisualStyleBackColor = true;
            // 
            // yTrackBar
            // 
            this.yTrackBar.Location = new System.Drawing.Point(69, 323);
            this.yTrackBar.Maximum = 100;
            this.yTrackBar.Name = "yTrackBar";
            this.yTrackBar.Size = new System.Drawing.Size(156, 69);
            this.yTrackBar.TabIndex = 1;
            this.yTrackBar.Value = 28;
            this.yTrackBar.Scroll += new System.EventHandler(this.yTrackBar_Scroll);
            // 
            // xTrackBar
            // 
            this.xTrackBar.Location = new System.Drawing.Point(69, 248);
            this.xTrackBar.Maximum = 100;
            this.xTrackBar.Name = "xTrackBar";
            this.xTrackBar.Size = new System.Drawing.Size(156, 69);
            this.xTrackBar.TabIndex = 2;
            this.xTrackBar.Value = 39;
            this.xTrackBar.Scroll += new System.EventHandler(this.xTrackBar_Scroll);
            // 
            // xInputBox
            // 
            this.xInputBox.Location = new System.Drawing.Point(230, 248);
            this.xInputBox.Name = "xInputBox";
            this.xInputBox.Size = new System.Drawing.Size(150, 31);
            this.xInputBox.TabIndex = 3;
            this.xInputBox.Text = "39";
            this.xInputBox.TextChanged += new System.EventHandler(this.xInputBox_TextChanged);
            this.xInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyInputted);
            // 
            // yInputBox
            // 
            this.yInputBox.Location = new System.Drawing.Point(230, 323);
            this.yInputBox.Name = "yInputBox";
            this.yInputBox.Size = new System.Drawing.Size(150, 31);
            this.yInputBox.TabIndex = 4;
            this.yInputBox.Text = "28";
            this.yInputBox.TextChanged += new System.EventHandler(this.yInputBox_TextChanged);
            this.yInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyInputted);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(166, 387);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 45);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(40, 330);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(22, 25);
            this.yLabel.TabIndex = 6;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(40, 255);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(23, 25);
            this.xLabel.TabIndex = 7;
            this.xLabel.Text = "X";
            // 
            // clockSpeedTrackBar
            // 
            this.clockSpeedTrackBar.Location = new System.Drawing.Point(69, 107);
            this.clockSpeedTrackBar.Maximum = 200;
            this.clockSpeedTrackBar.Minimum = 1;
            this.clockSpeedTrackBar.Name = "clockSpeedTrackBar";
            this.clockSpeedTrackBar.Size = new System.Drawing.Size(156, 69);
            this.clockSpeedTrackBar.TabIndex = 9;
            this.clockSpeedTrackBar.Value = 10;
            this.clockSpeedTrackBar.Scroll += new System.EventHandler(this.clockSpeedTrackBar_Scroll);
            // 
            // clockSpeedBox
            // 
            this.clockSpeedBox.Location = new System.Drawing.Point(230, 107);
            this.clockSpeedBox.Name = "clockSpeedBox";
            this.clockSpeedBox.Size = new System.Drawing.Size(150, 31);
            this.clockSpeedBox.TabIndex = 10;
            this.clockSpeedBox.Text = "10";
            this.clockSpeedBox.TextChanged += new System.EventHandler(this.clockSpeedBox_TextChanged);
            this.clockSpeedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyInputted);
            // 
            // clockSpeedLabel
            // 
            this.clockSpeedLabel.AutoSize = true;
            this.clockSpeedLabel.Location = new System.Drawing.Point(167, 33);
            this.clockSpeedLabel.Name = "clockSpeedLabel";
            this.clockSpeedLabel.Size = new System.Drawing.Size(110, 25);
            this.clockSpeedLabel.TabIndex = 11;
            this.clockSpeedLabel.Text = "Clock Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(40, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Note: at faster speeds this may not be accurate.";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(126, 58);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(195, 25);
            this.scaleLabel.TabIndex = 13;
            this.scaleLabel.Text = "(In 1/100s of a second)";
            // 
            // colourGroupBox
            // 
            this.colourGroupBox.Controls.Add(this.redButton);
            this.colourGroupBox.Controls.Add(this.blueButton);
            this.colourGroupBox.Controls.Add(this.blackButton);
            this.colourGroupBox.Location = new System.Drawing.Point(461, 33);
            this.colourGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colourGroupBox.Name = "colourGroupBox";
            this.colourGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colourGroupBox.Size = new System.Drawing.Size(286, 167);
            this.colourGroupBox.TabIndex = 14;
            this.colourGroupBox.TabStop = false;
            this.colourGroupBox.Text = "Colours";
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(14, 120);
            this.redButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(67, 29);
            this.redButton.TabIndex = 2;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(14, 78);
            this.blueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(70, 29);
            this.blueButton.TabIndex = 1;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // blackButton
            // 
            this.blackButton.AutoSize = true;
            this.blackButton.Checked = true;
            this.blackButton.Location = new System.Drawing.Point(14, 37);
            this.blackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(77, 29);
            this.blackButton.TabIndex = 0;
            this.blackButton.TabStop = true;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colourGroupBox);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clockSpeedLabel);
            this.Controls.Add(this.clockSpeedBox);
            this.Controls.Add(this.clockSpeedTrackBar);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.yInputBox);
            this.Controls.Add(this.xInputBox);
            this.Controls.Add(this.xTrackBar);
            this.Controls.Add(this.yTrackBar);
            this.Controls.Add(this.edgeStyleGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.edgeStyleGroupBox.ResumeLayout(false);
            this.edgeStyleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockSpeedTrackBar)).EndInit();
            this.colourGroupBox.ResumeLayout(false);
            this.colourGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox edgeStyleGroupBox;
        private System.Windows.Forms.RadioButton kleinButton;
        private System.Windows.Forms.RadioButton torusButton;
        private System.Windows.Forms.TrackBar yTrackBar;
        private System.Windows.Forms.TrackBar xTrackBar;
        private System.Windows.Forms.TextBox xInputBox;
        private System.Windows.Forms.TextBox yInputBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TrackBar clockSpeedTrackBar;
        private System.Windows.Forms.TextBox clockSpeedBox;
        private System.Windows.Forms.Label clockSpeedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.GroupBox colourGroupBox;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton blackButton;
    }
}