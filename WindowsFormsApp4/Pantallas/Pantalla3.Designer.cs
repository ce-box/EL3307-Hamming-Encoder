namespace WindowsFormsApp4
{
    partial class Pantalla3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGV1 = new System.Windows.Forms.DataGridView();
            this.dtGV2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbError1 = new System.Windows.Forms.Label();
            this.lbError2 = new System.Windows.Forms.Label();
            this.lbError3 = new System.Windows.Forms.Label();
            this.lbError4 = new System.Windows.Forms.Label();
            this.checkParidad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGV1
            // 
            this.dtGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGV1.ColumnHeadersHeight = 29;
            this.dtGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV1.Location = new System.Drawing.Point(64, 60);
            this.dtGV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGV1.Name = "dtGV1";
            this.dtGV1.RowHeadersWidth = 51;
            this.dtGV1.Size = new System.Drawing.Size(992, 208);
            this.dtGV1.TabIndex = 0;
            this.dtGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV1_CellContentClick);
            // 
            // dtGV2
            // 
            this.dtGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGV2.ColumnHeadersHeight = 29;
            this.dtGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV2.Location = new System.Drawing.Point(64, 375);
            this.dtGV2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGV2.Name = "dtGV2";
            this.dtGV2.RowHeadersWidth = 51;
            this.dtGV2.Size = new System.Drawing.Size(992, 207);
            this.dtGV2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(502, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(60, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entrada";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(151, 295);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 32);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(627, 287);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(121, 53);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Codificar";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn2.Enabled = false;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(771, 288);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(118, 53);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Analizar";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(497, 664);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbError1
            // 
            this.lbError1.AutoSize = true;
            this.lbError1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbError1.Location = new System.Drawing.Point(61, 606);
            this.lbError1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError1.Name = "lbError1";
            this.lbError1.Size = new System.Drawing.Size(0, 23);
            this.lbError1.TabIndex = 8;
            // 
            // lbError2
            // 
            this.lbError2.AutoSize = true;
            this.lbError2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbError2.Location = new System.Drawing.Point(295, 606);
            this.lbError2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError2.Name = "lbError2";
            this.lbError2.Size = new System.Drawing.Size(0, 23);
            this.lbError2.TabIndex = 9;
            // 
            // lbError3
            // 
            this.lbError3.AutoSize = true;
            this.lbError3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbError3.Location = new System.Drawing.Point(584, 606);
            this.lbError3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError3.Name = "lbError3";
            this.lbError3.Size = new System.Drawing.Size(0, 23);
            this.lbError3.TabIndex = 10;
            // 
            // lbError4
            // 
            this.lbError4.AutoSize = true;
            this.lbError4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbError4.Location = new System.Drawing.Point(906, 606);
            this.lbError4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError4.Name = "lbError4";
            this.lbError4.Size = new System.Drawing.Size(0, 23);
            this.lbError4.TabIndex = 11;
            // 
            // checkParidad
            // 
            this.checkParidad.AutoSize = true;
            this.checkParidad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkParidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkParidad.Location = new System.Drawing.Point(910, 304);
            this.checkParidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkParidad.Name = "checkParidad";
            this.checkParidad.Size = new System.Drawing.Size(146, 23);
            this.checkParidad.TabIndex = 12;
            this.checkParidad.Text = "Paridad impar";
            this.checkParidad.UseVisualStyleBackColor = true;
            // 
            // Pantalla3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1112, 774);
            this.Controls.Add(this.checkParidad);
            this.Controls.Add(this.lbError4);
            this.Controls.Add(this.lbError3);
            this.Controls.Add(this.lbError2);
            this.Controls.Add(this.lbError1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGV2);
            this.Controls.Add(this.dtGV1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pantalla3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pantalla3_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGV1;
        private System.Windows.Forms.DataGridView dtGV2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbError1;
        private System.Windows.Forms.Label lbError2;
        private System.Windows.Forms.Label lbError3;
        private System.Windows.Forms.Label lbError4;
        private System.Windows.Forms.CheckBox checkParidad;
    }
}

