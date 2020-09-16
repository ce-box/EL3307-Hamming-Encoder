namespace WindowsFormsApp4
{
    partial class Pantalla1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(421, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn1.FlatAppearance.BorderSize = 5;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1.Location = new System.Drawing.Point(401, 305);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(200, 80);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Convertidor";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn2.Location = new System.Drawing.Point(401, 430);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(200, 80);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Hamming Code";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pantalla1_FormClosing);
            this.Load += new System.EventHandler(this.Pantalla1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}