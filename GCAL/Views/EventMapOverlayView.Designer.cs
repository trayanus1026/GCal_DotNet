﻿namespace GCAL.Views
{
    partial class EventMapOverlayView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EventMapOverlayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventMapOverlayView";
            this.Size = new System.Drawing.Size(543, 342);
            this.SizeChanged += new System.EventHandler(this.EventMapOverlayView_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EventMapOverlayView_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EventMapOverlayView_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
