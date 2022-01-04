﻿
namespace ChallengeSaul.User_Control
{
    partial class uc_seat
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
            this.pbx_seat = new System.Windows.Forms.PictureBox();
            this.ckb_reserved = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_seat)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_seat
            // 
            this.pbx_seat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbx_seat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_seat.Image = global::ChallengeSaul.Properties.Resources.cinema_seat;
            this.pbx_seat.Location = new System.Drawing.Point(0, 0);
            this.pbx_seat.Name = "pbx_seat";
            this.pbx_seat.Size = new System.Drawing.Size(150, 150);
            this.pbx_seat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_seat.TabIndex = 0;
            this.pbx_seat.TabStop = false;
            this.pbx_seat.Click += new System.EventHandler(this.pbx_seat_Click);
            // 
            // ckb_reserved
            // 
            this.ckb_reserved.AutoSize = true;
            this.ckb_reserved.Location = new System.Drawing.Point(68, 60);
            this.ckb_reserved.Name = "ckb_reserved";
            this.ckb_reserved.Size = new System.Drawing.Size(18, 17);
            this.ckb_reserved.TabIndex = 1;
            this.ckb_reserved.UseVisualStyleBackColor = true;
            this.ckb_reserved.Visible = false;
            this.ckb_reserved.CheckedChanged += new System.EventHandler(this.ckb_reserved_CheckedChanged);
            // 
            // uc_seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckb_reserved);
            this.Controls.Add(this.pbx_seat);
            this.Name = "uc_seat";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_seat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_seat;
        private System.Windows.Forms.CheckBox ckb_reserved;
    }
}
