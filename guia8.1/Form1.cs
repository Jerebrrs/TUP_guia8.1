using guia8._1.Models;

namespace Guia8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Cuenta> cuentas = new List<Cuenta>();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDni.Text);
            double importe = Convert.ToDouble(tbImporte.Text);

            Cuenta nuevaCuenta = new Cuenta(nombre, dni, importe);

            cuentas.Sort();
            int idx= cuentas.BinarySearch(nuevaCuenta);



            if (idx != -1)
            {
                cuentas[idx].Nombre = nuevaCuenta.Nombre;
                cuentas[idx].Importe += nuevaCuenta.Importe;
            }
            else
            {
                cuentas.Add(nuevaCuenta);
            }
          
            tbNombre.Clear();
            tbDni.Clear();
            tbImporte.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lbVer.Items.Clear();

            if (cuentas.Count != -1)
            {
                foreach (Cuenta c in cuentas)
                {
                    lbVer.Items.Add(c);
                }
            }
        }

        private void lbVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta selectedCuenta = lbVer.SelectedItem as Cuenta;


            if (selectedCuenta != null)
            {
                tbNombre.Text = selectedCuenta.Nombre;
                tbDni.Text = selectedCuenta.Dni.ToString();
                tbImporte.Text = selectedCuenta.Importe.ToString();
            }
        }
    }
}
