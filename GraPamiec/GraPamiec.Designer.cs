﻿namespace GraPamiec
{
    partial class GraPamiec
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
            this.panelGry = new System.Windows.Forms.Panel();
            this.timerPodglad = new System.Windows.Forms.Timer(this.components);
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelGry
            // 
            this.panelGry.BackColor = System.Drawing.Color.White;
            this.panelGry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGry.Location = new System.Drawing.Point(12, 12);
            this.panelGry.Name = "panelGry";
            this.panelGry.Size = new System.Drawing.Size(600, 600);
            this.panelGry.TabIndex = 0;
            // 
            // timerPodglad
            // 
            this.timerPodglad.Interval = 6000;
            this.timerPodglad.Tick += new System.EventHandler(this.timerPodglad_Tick);
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            this.timerZakrywacz.Tick += new System.EventHandler(this.timerZakrywacz_Tick);
            // 
            // GraPamiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(624, 621);
            this.Controls.Add(this.panelGry);
            this.Name = "GraPamiec";
            this.Text = "Gra Pamięć";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGry;
        private System.Windows.Forms.Timer timerPodglad;
        private System.Windows.Forms.Timer timerZakrywacz;
    }
}

