﻿namespace ExempleSouris
{
    partial class FormDessin
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
            this.SuspendLayout();
            // 
            // FormDessin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FormDessin";
            this.Text = "Dessin";
            this.Load += new System.EventHandler(this.FormDessin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDessin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDessin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDessin_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

