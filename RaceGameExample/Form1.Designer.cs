﻿namespace RaceGameExample {
    partial class formRaceGame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timerGameTicks = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerGameTicks
            // 
            this.timerGameTicks.Enabled = true;
            this.timerGameTicks.Interval = 1;
            this.timerGameTicks.Tick += new System.EventHandler(this.timerGameTicks_Tick);
            // 
            // formRaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 631);
            this.Name = "formRaceGame";
            this.Text = "RaceGameExample";
            this.Load += new System.EventHandler(this.formRaceGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGameTicks;
    }
}

