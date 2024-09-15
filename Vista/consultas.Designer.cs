namespace WindowsFormsApp2.Vista
{
    partial class consultas
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
            this.showList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showList
            // 
            this.showList.FormattingEnabled = true;
            this.showList.Location = new System.Drawing.Point(60, 56);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(631, 21);
            this.showList.TabIndex = 0;
            this.showList.SelectedIndexChanged += new System.EventHandler(this.showList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cantidad de unidades vendidas de Arroz Tio Pelón";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "total de ventas por sucursal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "total de ventas por cajero";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 68);
            this.button4.TabIndex = 4;
            this.button4.Text = "top 5 de clientes que más han comprado";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(476, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 68);
            this.button5.TabIndex = 5;
            this.button5.Text = "top 5 de artículos más vendidos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(317, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 66);
            this.button6.TabIndex = 6;
            this.button6.Text = "ventas que hubieron en Noviembre 2022";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(317, 209);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 71);
            this.button7.TabIndex = 7;
            this.button7.Text = "top 3 artículos menos vendidos, junto con lo que han generado en ventas cada uno";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(618, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 74);
            this.button8.TabIndex = 8;
            this.button8.Text = "cantidad de artículos que tiene cada proveedor";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(474, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 65);
            this.button9.TabIndex = 9;
            this.button9.Text = "Mostrar todas las facturas";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(618, 112);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(119, 62);
            this.button10.TabIndex = 10;
            this.button10.Text = "Mostrar el artículo con menos reserva en inventario.";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione una consulta, y esta se mostrará en la lista desplegable";
            // 
            // consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showList);
            this.Name = "consultas";
            this.Text = "consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox showList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
    }
}