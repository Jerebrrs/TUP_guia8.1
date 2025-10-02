using Guia8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cuenta> listaCuenta = new List<Cuenta>();
        int v=-1;
        private void btnConfitmar_Click(object sender, EventArgs e)
        {
            try
            {

                
                string nombre = tbNombre.Text;
                int dni = Convert.ToInt32(tbDni.Text);
                double imp = Convert.ToDouble(tbImporte.Text);

                
                if (nombre != "" && dni != null && imp != null)
                {
                 

                    if (v == -1)
                    {
                        Cuenta cuenta = new Cuenta(nombre, dni, imp);
                        listaCuenta.Add(cuenta);
                        MessageBox.Show($@"Sasfgwregerggee :  {cuenta.Nombre}");
                    }
                    else
                    {

                        Cuenta cuenta = new Cuenta(nombre, dni, imp);

                        listaCuenta[v] = cuenta;


                        MessageBox.Show($@"oisghasoighaoishgoiashigoisohasoihgoiasg{imp}");
                        v = -1;
                    }

                  
                }
               
                tbDni.Clear();
                tbImporte.Clear();
                tbNombre.Clear();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Los campos no pueden estar vacios");
            }
          

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lbActualizar.Items.Clear();
            foreach (Cuenta c in listaCuenta)
            {
                lbActualizar.Items.Add(c.ToString());
            }
        }

        private void lbActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            v = lbActualizar.SelectedIndex;
            Cuenta cuenta = listaCuenta[v];
            tbNombre.Text = cuenta.Nombre;
            tbDni.Text = Convert.ToString(cuenta.Dni);
            tbImporte.Text = Convert.ToString(cuenta.Importe);



        }
    }
}
