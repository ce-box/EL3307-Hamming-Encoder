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
            this.dtGV1.Location = new System.Drawing.Point(39, 70);
            this.dtGV1.Name = "dtGV1";
            this.dtGV1.RowHeadersWidth = 51;
            this.dtGV1.Size = new System.Drawing.Size(910, 207);
            this.dtGV1.TabIndex = 0;
            this.dtGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGV1_CellContentClick);
            // 
            // dtGV2
            // 
            this.dtGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGV2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGV2.ColumnHeadersHeight = 29;
            this.dtGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGV2.Location = new System.Drawing.Point(39, 337);
            this.dtGV2.Name = "dtGV2";
            this.dtGV2.RowHeadersWidth = 51;
            this.dtGV2.Size = new System.Drawing.Size(910, 207);
            this.dtGV2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(358, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entrada";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 295);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(617, 293);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Codificar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Enabled = false;
            this.btn2.Location = new System.Drawing.Point(732, 293);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Analizar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbError1
            // 
            this.lbError1.AutoSize = true;
            this.lbError1.Location = new System.Drawing.Point(39, 561);
            this.lbError1.Name = "lbError1";
            this.lbError1.Size = new System.Drawing.Size(0, 13);
            this.lbError1.TabIndex = 8;
            // 
            // lbError2
            // 
            this.lbError2.AutoSize = true;
            this.lbError2.Location = new System.Drawing.Point(231, 561);
            this.lbError2.Name = "lbError2";
            this.lbError2.Size = new System.Drawing.Size(0, 13);
            this.lbError2.TabIndex = 9;
            // 
            // lbError3
            // 
            this.lbError3.AutoSize = true;
            this.lbError3.Location = new System.Drawing.Point(421, 561);
            this.lbError3.Name = "lbError3";
            this.lbError3.Size = new System.Drawing.Size(0, 13);
            this.lbError3.TabIndex = 10;
            // 
            // lbError4
            // 
            this.lbError4.AutoSize = true;
            this.lbError4.Location = new System.Drawing.Point(660, 561);
            this.lbError4.Name = "lbError4";
            this.lbError4.Size = new System.Drawing.Size(0, 13);
            this.lbError4.TabIndex = 11;
            // 
            // checkParidad
            // 
            this.checkParidad.AutoSize = true;
            this.checkParidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkParidad.Location = new System.Drawing.Point(830, 297);
            this.checkParidad.Name = "checkParidad";
            this.checkParidad.Size = new System.Drawing.Size(104, 19);
            this.checkParidad.TabIndex = 12;
            this.checkParidad.Text = "Paridad impar";
            this.checkParidad.UseVisualStyleBackColor = true;
            // 
            // Pantalla3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
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
            this.Name = "Pantalla3";
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

