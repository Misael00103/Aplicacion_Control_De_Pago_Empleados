namespace Aplicacion_Control_De_Pago_Empleados
{
    public partial class frmPagoEmpleados : Form
    {
        public frmPagoEmpleados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void btnProcesar_Click(object sender, EventArgs e)
		{
            //Recuperando la informacion registrada
            string empleado = txtEmpleado.Text;
            int horas = int.Parse(txtHoras.Text);
            double costo = double.Parse(txtCosto.Text);

            //Realizando calculos
            double SueldoBasico = horas * costo;
            double bonificacion = 20.0 / 100 * SueldoBasico;
            double sueldoBruto = SueldoBasico + bonificacion;
            double descuento = sueldoBruto * 12.0 / 100;
            double sueldoNeto = sueldoBruto - descuento;

            //Imprimiendo resultados

            lblMontoBruto.Text = SueldoBasico.ToString("C");
            lblMontoDescuento.Text = descuento.ToString("C");
            lblMontoNeto.Text = sueldoBruto.ToString("C");
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
            txtEmpleado.Clear();
            txtHoras.Clear();
            txtCosto.Clear();
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            lblMontoNeto.Text = "";
            txtEmpleado.Focus();
        }

		private void btnSalir_Click(object sender, EventArgs e)
		{
            DialogResult r = MessageBox.Show("Estas Seguro?",
                                             "Control de pago",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Information);
		}
	}
}
