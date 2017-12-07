namespace StopWatchApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.resetButton = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.hundredsLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.minutesLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.learningBox = new System.Windows.Forms.GroupBox();
            this.colourLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.debugLabel2 = new System.Windows.Forms.Label();
            this.debugLabel1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.learningBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(138, 166);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(80, 42);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startStopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStopButton.ForeColor = System.Drawing.Color.White;
            this.startStopButton.Location = new System.Drawing.Point(48, 166);
            this.startStopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(80, 42);
            this.startStopButton.TabIndex = 6;
            this.startStopButton.Text = "Start";
            this.startStopButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // hundredsLabel
            // 
            this.hundredsLabel.BackColor = System.Drawing.Color.White;
            this.hundredsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundredsLabel.ForeColor = System.Drawing.Color.Black;
            this.hundredsLabel.Location = new System.Drawing.Point(173, 82);
            this.hundredsLabel.Name = "hundredsLabel";
            this.hundredsLabel.Size = new System.Drawing.Size(59, 55);
            this.hundredsLabel.TabIndex = 5;
            this.hundredsLabel.Text = ":00";
            this.hundredsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // secondsLabel
            // 
            this.secondsLabel.BackColor = System.Drawing.Color.White;
            this.secondsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.ForeColor = System.Drawing.Color.Black;
            this.secondsLabel.Location = new System.Drawing.Point(102, 82);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(59, 55);
            this.secondsLabel.TabIndex = 4;
            this.secondsLabel.Text = ":00";
            this.secondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countTimer
            // 
            this.countTimer.Interval = 10;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // minutesLabel
            // 
            this.minutesLabel.BackColor = System.Drawing.Color.White;
            this.minutesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLabel.ForeColor = System.Drawing.Color.Black;
            this.minutesLabel.Location = new System.Drawing.Point(32, 82);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(59, 55);
            this.minutesLabel.TabIndex = 8;
            this.minutesLabel.Text = "00";
            this.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(439, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 41);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // learningBox
            // 
            this.learningBox.Controls.Add(this.colourLabel);
            this.learningBox.Controls.Add(this.counterLabel);
            this.learningBox.Controls.Add(this.debugLabel2);
            this.learningBox.Controls.Add(this.debugLabel1);
            this.learningBox.ForeColor = System.Drawing.Color.White;
            this.learningBox.Location = new System.Drawing.Point(285, 51);
            this.learningBox.Name = "learningBox";
            this.learningBox.Size = new System.Drawing.Size(190, 176);
            this.learningBox.TabIndex = 11;
            this.learningBox.TabStop = false;
            this.learningBox.Text = "Learning Area";
            // 
            // colourLabel
            // 
            this.colourLabel.BackColor = System.Drawing.Color.Black;
            this.colourLabel.Location = new System.Drawing.Point(120, 106);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(33, 23);
            this.colourLabel.TabIndex = 3;
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(117, 57);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(16, 17);
            this.counterLabel.TabIndex = 2;
            this.counterLabel.Text = "0";
            // 
            // debugLabel2
            // 
            this.debugLabel2.AutoSize = true;
            this.debugLabel2.Location = new System.Drawing.Point(31, 106);
            this.debugLabel2.Name = "debugLabel2";
            this.debugLabel2.Size = new System.Drawing.Size(51, 17);
            this.debugLabel2.TabIndex = 1;
            this.debugLabel2.Text = "colour:";
            // 
            // debugLabel1
            // 
            this.debugLabel1.AutoSize = true;
            this.debugLabel1.Location = new System.Drawing.Point(31, 57);
            this.debugLabel1.Name = "debugLabel1";
            this.debugLabel1.Size = new System.Drawing.Size(51, 17);
            this.debugLabel1.TabIndex = 0;
            this.debugLabel1.Text = "count: ";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-1, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(560, 44);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Amazing RAMS Timer";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(488, 239);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.learningBox);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.hundredsLabel);
            this.Controls.Add(this.secondsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stop Watch";
            this.learningBox.ResumeLayout(false);
            this.learningBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Label hundredsLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox learningBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label debugLabel2;
        private System.Windows.Forms.Label debugLabel1;
    }
}

