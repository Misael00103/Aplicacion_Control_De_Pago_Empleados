namespace Aplicacion_Control_De_Pago_Empleados
{
    partial class frmPagoEmpleados
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagoEmpleados));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblMontoBruto = new System.Windows.Forms.Label();
			this.lblMontoDescuento = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblMontoNeto = new System.Windows.Forms.Label();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.txtHoras = new System.Windows.Forms.TextBox();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.btnProcesar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(140, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "CONTROL DE PAGO DE EMPLEADOS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "EMPLEADO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "HORAS";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(400, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "COSTO HORAS";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "MONTO BRUTO";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(168, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "MONTO DESCUENTO";
			// 
			// lblMontoBruto
			// 
			this.lblMontoBruto.AutoSize = true;
			this.lblMontoBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMontoBruto.Location = new System.Drawing.Point(29, 64);
			this.lblMontoBruto.Name = "lblMontoBruto";
			this.lblMontoBruto.Size = new System.Drawing.Size(2, 17);
			this.lblMontoBruto.TabIndex = 6;
			// 
			// lblMontoDescuento
			// 
			this.lblMontoDescuento.AutoSize = true;
			this.lblMontoDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMontoDescuento.Location = new System.Drawing.Point(168, 64);
			this.lblMontoDescuento.Name = "lblMontoDescuento";
			this.lblMontoDescuento.Size = new System.Drawing.Size(2, 17);
			this.lblMontoDescuento.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(355, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 15);
			this.label9.TabIndex = 8;
			this.label9.Text = "MONTO NETO ";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// lblMontoNeto
			// 
			this.lblMontoNeto.AutoSize = true;
			this.lblMontoNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMontoNeto.Location = new System.Drawing.Point(355, 64);
			this.lblMontoNeto.Name = "lblMontoNeto";
			this.lblMontoNeto.Size = new System.Drawing.Size(2, 17);
			this.lblMontoNeto.TabIndex = 9;
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Location = new System.Drawing.Point(123, 51);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(465, 23);
			this.txtEmpleado.TabIndex = 10;
			// 
			// txtHoras
			// 
			this.txtHoras.Location = new System.Drawing.Point(123, 87);
			this.txtHoras.Name = "txtHoras";
			this.txtHoras.Size = new System.Drawing.Size(271, 23);
			this.txtHoras.TabIndex = 11;
			// 
			// txtCosto
			// 
			this.txtCosto.Location = new System.Drawing.Point(488, 82);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(100, 23);
			this.txtCosto.TabIndex = 12;
			// 
			// btnProcesar
			// 
			this.btnProcesar.Location = new System.Drawing.Point(37, 156);
			this.btnProcesar.Name = "btnProcesar";
			this.btnProcesar.Size = new System.Drawing.Size(75, 23);
			this.btnProcesar.TabIndex = 13;
			this.btnProcesar.Text = "PROCESAR";
			this.btnProcesar.UseVisualStyleBackColor = true;
			this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(513, 156);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 14;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(37, 316);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 15;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.lblMontoBruto);
			this.groupBox1.Controls.Add(this.lblMontoDescuento);
			this.groupBox1.Controls.Add(this.lblMontoNeto);
			this.groupBox1.Location = new System.Drawing.Point(37, 185);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(551, 125);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CUADRO RESUMEN";
			// 
			// frmPagoEmpleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(613, 361);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnProcesar);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.txtHoras);
			this.Controls.Add(this.txtEmpleado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmPagoEmpleados";
			this.Text = "Control de pago empleados";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label lblMontoBruto;
		private Label lblMontoDescuento;
		private Label label9;
		private Label lblMontoNeto;
		private TextBox txtEmpleado;
		private TextBox txtHoras;
		private TextBox txtCosto;
		private Button btnProcesar;
		private Button btnLimpiar;
		private Button btnSalir;
		private GroupBox groupBox1;
	}
}