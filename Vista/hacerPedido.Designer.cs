namespace WindowsFormsApp2.Vista
{
    partial class hacerPedido
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
            this.cajaIdCliente = new System.Windows.Forms.TextBox();
            this.cajaIdCajero = new System.Windows.Forms.TextBox();
            this.cajaIdArticulo = new System.Windows.Forms.TextBox();
            this.cajaaCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cajaCon = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaIdCliente
            // 
            this.cajaIdCliente.Location = new System.Drawing.Point(25, 53);
            this.cajaIdCliente.Name = "cajaIdCliente";
            this.cajaIdCliente.Size = new System.Drawing.Size(100, 20);
            this.cajaIdCliente.TabIndex = 0;
            // 
            // cajaIdCajero
            // 
            this.cajaIdCajero.Location = new System.Drawing.Point(25, 125);
            this.cajaIdCajero.Name = "cajaIdCajero";
            this.cajaIdCajero.Size = new System.Drawing.Size(100, 20);
            this.cajaIdCajero.TabIndex = 1;
            // 
            // cajaIdArticulo
            // 
            this.cajaIdArticulo.Location = new System.Drawing.Point(25, 192);
            this.cajaIdArticulo.Name = "cajaIdArticulo";
            this.cajaIdArticulo.Size = new System.Drawing.Size(100, 20);
            this.cajaIdArticulo.TabIndex = 2;
            // 
            // cajaaCantidad
            // 
            this.cajaaCantidad.Location = new System.Drawing.Point(25, 261);
            this.cajaaCantidad.Name = "cajaaCantidad";
            this.cajaaCantidad.Size = new System.Drawing.Size(100, 20);
            this.cajaaCantidad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id del cajero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "id del articulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad de articulo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tabla Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tabla Cajero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tabla Articulo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(316, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 46);
            this.button4.TabIndex = 11;
            this.button4.Text = "Realizar Pedido";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cajaCon
            // 
            this.cajaCon.Location = new System.Drawing.Point(246, 131);
            this.cajaCon.Name = "cajaCon";
            this.cajaCon.Size = new System.Drawing.Size(297, 20);
            this.cajaCon.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(272, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 34);
            this.button5.TabIndex = 13;
            this.button5.Text = "Tabla Pedido";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(395, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 34);
            this.button6.TabIndex = 14;
            this.button6.Text = "Tabla Factura";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hacerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cajaCon);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cajaaCantidad);
            this.Controls.Add(this.cajaIdArticulo);
            this.Controls.Add(this.cajaIdCajero);
            this.Controls.Add(this.cajaIdCliente);
            this.Name = "hacerPedido";
            this.Text = "hacerPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaIdCliente;
        private System.Windows.Forms.TextBox cajaIdCajero;
        private System.Windows.Forms.TextBox cajaIdArticulo;
        private System.Windows.Forms.TextBox cajaaCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox cajaCon;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}