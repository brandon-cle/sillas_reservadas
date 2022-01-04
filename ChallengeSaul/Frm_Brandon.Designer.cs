
namespace ChallengeSaul
{
    partial class Frm_Brandon
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_impar_count = new System.Windows.Forms.Label();
            this.lbl_par_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_total_count = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introducir número:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lbl_total_count);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_par_count);
            this.panel1.Controls.Add(this.lbl_impar_count);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 250);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Veces en que se realizcó 3x +1:";
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(175, 109);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(75, 23);
            this.btn_exec.TabIndex = 3;
            this.btn_exec.Text = "Calcular";
            this.btn_exec.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Veces de una división entre dos:";
            // 
            // lbl_impar_count
            // 
            this.lbl_impar_count.AutoSize = true;
            this.lbl_impar_count.Location = new System.Drawing.Point(266, 17);
            this.lbl_impar_count.Name = "lbl_impar_count";
            this.lbl_impar_count.Size = new System.Drawing.Size(108, 17);
            this.lbl_impar_count.TabIndex = 2;
            this.lbl_impar_count.Text = "lbl_impar_count";
            // 
            // lbl_par_count
            // 
            this.lbl_par_count.AutoSize = true;
            this.lbl_par_count.Location = new System.Drawing.Point(266, 63);
            this.lbl_par_count.Name = "lbl_par_count";
            this.lbl_par_count.Size = new System.Drawing.Size(94, 17);
            this.lbl_par_count.TabIndex = 3;
            this.lbl_par_count.Text = "lbl_par_count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total de veces puesto en un cálculo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Abrir gráfica";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_total_count
            // 
            this.lbl_total_count.AutoSize = true;
            this.lbl_total_count.Location = new System.Drawing.Point(266, 112);
            this.lbl_total_count.Name = "lbl_total_count";
            this.lbl_total_count.Size = new System.Drawing.Size(100, 17);
            this.lbl_total_count.TabIndex = 6;
            this.lbl_total_count.Text = "lbl_total_count";
            // 
            // Frm_Brandon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 417);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Frm_Brandon";
            this.Text = "Frm_Brandon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_total_count;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_par_count;
        private System.Windows.Forms.Label lbl_impar_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exec;
    }
}