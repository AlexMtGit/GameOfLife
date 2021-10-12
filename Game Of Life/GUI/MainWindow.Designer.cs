
using System;

namespace Game_Of_Life
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.BoardPictureBox = new System.Windows.Forms.PictureBox();
            this.CellSizePixels = new System.Windows.Forms.NumericUpDown();
            this.CellSizeLabel = new System.Windows.Forms.Label();
            this.RandomButton = new System.Windows.Forms.Button();
            this.PlayStopCheckbox = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BoardFoldCheckBox = new System.Windows.Forms.CheckBox();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.DelayMs = new System.Windows.Forms.NumericUpDown();
            this.LivingCellsLabel = new System.Windows.Forms.Label();
            this.LivingCellsPercentage = new System.Windows.Forms.NumericUpDown();
            this.GliderButton = new System.Windows.Forms.Button();
            this.RowButton = new System.Windows.Forms.Button();
            this.SpaceshipButton = new System.Windows.Forms.Button();
            this.GlidderGunButton = new System.Windows.Forms.Button();
            this.Period15Button = new System.Windows.Forms.Button();
            this.PulsarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizePixels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivingCellsPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // BoardPictureBox
            // 
            this.BoardPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardPictureBox.Location = new System.Drawing.Point(12, 33);
            this.BoardPictureBox.Name = "BoardPictureBox";
            this.BoardPictureBox.Size = new System.Drawing.Size(1126, 405);
            this.BoardPictureBox.TabIndex = 0;
            this.BoardPictureBox.TabStop = false;
            this.BoardPictureBox.SizeChanged += new System.EventHandler(this.BoardPictureBoxChangeSize);
            // 
            // CellSizePixels
            // 
            this.CellSizePixels.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellSizePixels.Location = new System.Drawing.Point(268, 9);
            this.CellSizePixels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CellSizePixels.Name = "CellSizePixels";
            this.CellSizePixels.Size = new System.Drawing.Size(40, 21);
            this.CellSizePixels.TabIndex = 1;
            this.CellSizePixels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CellSizePixels.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CellSizePixels.ValueChanged += new System.EventHandler(this.CellSizePixelsChanged);
            // 
            // CellSizeLabel
            // 
            this.CellSizeLabel.AutoSize = true;
            this.CellSizeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CellSizeLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellSizeLabel.Location = new System.Drawing.Point(176, 11);
            this.CellSizeLabel.Name = "CellSizeLabel";
            this.CellSizeLabel.Size = new System.Drawing.Size(86, 16);
            this.CellSizeLabel.TabIndex = 8;
            this.CellSizeLabel.Text = "Cell Size (px):";
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(626, 7);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(68, 23);
            this.RandomButton.TabIndex = 5;
            this.RandomButton.Text = "Random";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // PlayStopCheckbox
            // 
            this.PlayStopCheckbox.AutoSize = true;
            this.PlayStopCheckbox.Checked = true;
            this.PlayStopCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlayStopCheckbox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayStopCheckbox.Location = new System.Drawing.Point(570, 9);
            this.PlayStopCheckbox.Name = "PlayStopCheckbox";
            this.PlayStopCheckbox.Size = new System.Drawing.Size(50, 20);
            this.PlayStopCheckbox.TabIndex = 6;
            this.PlayStopCheckbox.Text = "Play";
            this.PlayStopCheckbox.UseVisualStyleBackColor = true;
            this.PlayStopCheckbox.CheckedChanged += new System.EventHandler(this.PlayStopChanged);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BoardFoldCheckBox
            // 
            this.BoardFoldCheckBox.AutoSize = true;
            this.BoardFoldCheckBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoardFoldCheckBox.Location = new System.Drawing.Point(476, 9);
            this.BoardFoldCheckBox.Name = "BoardFoldCheckBox";
            this.BoardFoldCheckBox.Size = new System.Drawing.Size(88, 20);
            this.BoardFoldCheckBox.TabIndex = 7;
            this.BoardFoldCheckBox.Text = "Board Fold";
            this.BoardFoldCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BoardFoldCheckBox.UseVisualStyleBackColor = true;
            this.BoardFoldCheckBox.CheckedChanged += new System.EventHandler(this.BoardFoldChanged);
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelayLabel.Location = new System.Drawing.Point(327, 10);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(73, 16);
            this.DelayLabel.TabIndex = 8;
            this.DelayLabel.Text = "Delay (ms):";
            // 
            // DelayMs
            // 
            this.DelayMs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelayMs.Location = new System.Drawing.Point(406, 9);
            this.DelayMs.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.DelayMs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DelayMs.Name = "DelayMs";
            this.DelayMs.Size = new System.Drawing.Size(53, 21);
            this.DelayMs.TabIndex = 9;
            this.DelayMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DelayMs.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.DelayMs.ValueChanged += new System.EventHandler(this.DelayMsChanged);
            // 
            // LivingCellsLabel
            // 
            this.LivingCellsLabel.AutoSize = true;
            this.LivingCellsLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LivingCellsLabel.Location = new System.Drawing.Point(12, 11);
            this.LivingCellsLabel.Name = "LivingCellsLabel";
            this.LivingCellsLabel.Size = new System.Drawing.Size(102, 16);
            this.LivingCellsLabel.TabIndex = 10;
            this.LivingCellsLabel.Text = "Living Cells (%):";
            // 
            // LivingCellsPercentage
            // 
            this.LivingCellsPercentage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LivingCellsPercentage.Location = new System.Drawing.Point(120, 8);
            this.LivingCellsPercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LivingCellsPercentage.Name = "LivingCellsPercentage";
            this.LivingCellsPercentage.Size = new System.Drawing.Size(40, 21);
            this.LivingCellsPercentage.TabIndex = 11;
            this.LivingCellsPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LivingCellsPercentage.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LivingCellsPercentage.ValueChanged += new System.EventHandler(this.LivingCellsPercentageChanged);
            // 
            // GliderButton
            // 
            this.GliderButton.Location = new System.Drawing.Point(700, 7);
            this.GliderButton.Name = "GliderButton";
            this.GliderButton.Size = new System.Drawing.Size(56, 23);
            this.GliderButton.TabIndex = 12;
            this.GliderButton.Text = "Glider";
            this.GliderButton.UseVisualStyleBackColor = true;
            this.GliderButton.Click += new System.EventHandler(this.GliderButton_Click);
            // 
            // RowButton
            // 
            this.RowButton.Location = new System.Drawing.Point(837, 8);
            this.RowButton.Name = "RowButton";
            this.RowButton.Size = new System.Drawing.Size(56, 23);
            this.RowButton.TabIndex = 12;
            this.RowButton.Text = "Row";
            this.RowButton.UseVisualStyleBackColor = true;
            this.RowButton.Click += new System.EventHandler(this.RowButton_Click);
            // 
            // SpaceshipButton
            // 
            this.SpaceshipButton.Location = new System.Drawing.Point(762, 7);
            this.SpaceshipButton.Name = "SpaceshipButton";
            this.SpaceshipButton.Size = new System.Drawing.Size(69, 23);
            this.SpaceshipButton.TabIndex = 13;
            this.SpaceshipButton.Text = "Spaceship";
            this.SpaceshipButton.UseVisualStyleBackColor = true;
            this.SpaceshipButton.Click += new System.EventHandler(this.SpaceshipButton_Click);
            // 
            // GlidderGunButton
            // 
            this.GlidderGunButton.Location = new System.Drawing.Point(899, 8);
            this.GlidderGunButton.Name = "GlidderGunButton";
            this.GlidderGunButton.Size = new System.Drawing.Size(74, 23);
            this.GlidderGunButton.TabIndex = 14;
            this.GlidderGunButton.Text = "Glider Gun";
            this.GlidderGunButton.UseVisualStyleBackColor = true;
            this.GlidderGunButton.Click += new System.EventHandler(this.GliderGunButton_Click);
            // 
            // Period15Button
            // 
            this.Period15Button.Location = new System.Drawing.Point(979, 8);
            this.Period15Button.Name = "Period15Button";
            this.Period15Button.Size = new System.Drawing.Size(74, 23);
            this.Period15Button.TabIndex = 15;
            this.Period15Button.Text = "Period 15";
            this.Period15Button.UseVisualStyleBackColor = true;
            this.Period15Button.Click += new System.EventHandler(this.Period15Button_Click);
            // 
            // PulsarButton
            // 
            this.PulsarButton.Location = new System.Drawing.Point(1059, 8);
            this.PulsarButton.Name = "PulsarButton";
            this.PulsarButton.Size = new System.Drawing.Size(74, 23);
            this.PulsarButton.TabIndex = 16;
            this.PulsarButton.Text = "Pulsar";
            this.PulsarButton.UseVisualStyleBackColor = true;
            this.PulsarButton.Click += new System.EventHandler(this.PulsarButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.PulsarButton);
            this.Controls.Add(this.Period15Button);
            this.Controls.Add(this.GlidderGunButton);
            this.Controls.Add(this.SpaceshipButton);
            this.Controls.Add(this.RowButton);
            this.Controls.Add(this.GliderButton);
            this.Controls.Add(this.LivingCellsPercentage);
            this.Controls.Add(this.LivingCellsLabel);
            this.Controls.Add(this.DelayMs);
            this.Controls.Add(this.DelayLabel);
            this.Controls.Add(this.BoardFoldCheckBox);
            this.Controls.Add(this.PlayStopCheckbox);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.CellSizeLabel);
            this.Controls.Add(this.CellSizePixels);
            this.Controls.Add(this.BoardPictureBox);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.BoardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellSizePixels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivingCellsPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoardPictureBox;
        private System.Windows.Forms.NumericUpDown CellSizePixels;
        private System.Windows.Forms.Label CellSizeLabel;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.CheckBox PlayStopCheckbox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox BoardFoldCheckBox;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.NumericUpDown DelayMs;
        private System.Windows.Forms.Label LivingCellsLabel;
        private System.Windows.Forms.NumericUpDown LivingCellsPercentage;
        private System.Windows.Forms.Button GliderButton;
        private System.Windows.Forms.Button RowButton;
        private System.Windows.Forms.Button SpaceshipButton;
        private System.Windows.Forms.Button GlidderGunButton;
        private System.Windows.Forms.Button Period15Button;
        private System.Windows.Forms.Button PulsarButton;
    }
}

