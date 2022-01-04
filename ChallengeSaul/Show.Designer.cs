
namespace ChallengeSaul
{
    partial class Show
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
            this.button1 = new System.Windows.Forms.Button();
            this.list_reservation = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar reservaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_reservation
            // 
            this.list_reservation.Location = new System.Drawing.Point(41, 68);
            this.list_reservation.Name = "list_reservation";
            this.list_reservation.Size = new System.Drawing.Size(723, 131);
            this.list_reservation.TabIndex = 1;
            this.list_reservation.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Se harán las reservaciones en las sillas siguientes:";
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_reservation);
            this.Controls.Add(this.button1);
            this.Name = "Show";
            this.Text = "Show";
            this.Load += new System.EventHandler(this.Show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox list_reservation;
        private System.Windows.Forms.Label label1;
    }
}