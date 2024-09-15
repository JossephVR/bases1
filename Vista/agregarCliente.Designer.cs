namespace WindowsFormsApp2
{
    partial class agregarCliente
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
            this.cajaCedula = new System.Windows.Forms.TextBox();
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.cajaSexo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botnAgregar = new System.Windows.Forms.Button();
            this.cajaC = new System.Windows.Forms.TextBox();
            this.showList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cajaId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cajaCedula
            // 
            this.cajaCedula.Location = new System.Drawing.Point(11, 76);
            this.cajaCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cajaCedula.Name = "cajaCedula";
            this.cajaCedula.Size = new System.Drawing.Size(124, 20);
            this.cajaCedula.TabIndex = 0;
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(11, 127);
            this.cajaNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(124, 20);
            this.cajaNombre.TabIndex = 1;
            // 
            // cajaSexo
            // 
            this.cajaSexo.Location = new System.Drawing.Point(11, 178);
            this.cajaSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cajaSexo.Name = "cajaSexo";
            this.cajaSexo.Size = new System.Drawing.Size(124, 20);
            this.cajaSexo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo";
            // 
            // botnAgregar
            // 
            this.botnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnAgregar.Location = new System.Drawing.Point(85, 298);
            this.botnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botnAgregar.Name = "botnAgregar";
            this.botnAgregar.Size = new System.Drawing.Size(132, 69);
            this.botnAgregar.TabIndex = 6;
            this.botnAgregar.Text = "Agregar";
            this.botnAgregar.UseVisualStyleBackColor = true;
            this.botnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cajaC
            // 
            this.cajaC.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaC.Location = new System.Drawing.Point(11, 386);
            this.cajaC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cajaC.Name = "cajaC";
            this.cajaC.Size = new System.Drawing.Size(647, 33);
            this.cajaC.TabIndex = 7;
            // 
            // showList
            // 
            this.showList.FormattingEnabled = true;
            this.showList.Location = new System.Drawing.Point(182, 57);
            this.showList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(459, 21);
            this.showList.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "lista con todos los clientes";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "Refrescar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cajaId
            // 
            this.cajaId.Location = new System.Drawing.Point(11, 31);
            this.cajaId.Name = "cajaId";
            this.cajaId.Size = new System.Drawing.Size(124, 20);
            this.cajaId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "id";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(254, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 69);
            this.button2.TabIndex = 13;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(417, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 69);
            this.button3.TabIndex = 14;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Para borrar solo ingrese el Id";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(399, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Para crear no ingrese el Id (este se crea automaticamente)";
            // 
            // agregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cajaId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.cajaC);
            this.Controls.Add(this.botnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cajaSexo);
            this.Controls.Add(this.cajaNombre);
            this.Controls.Add(this.cajaCedula);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "agregarCliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaCedula;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.TextBox cajaSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botnAgregar;
        private System.Windows.Forms.TextBox cajaC;
        private System.Windows.Forms.ComboBox showList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cajaId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}