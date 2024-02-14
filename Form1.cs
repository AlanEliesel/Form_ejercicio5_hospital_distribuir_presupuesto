using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ejercicio5_hospital_distribuir_presupuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Distribuir_Click(object sender, EventArgs e)
        {
            int Presupuesto = Convert.ToInt32(txt_presupuesto.Text);

            double emergencia = Presupuesto * 30 / 100;

            double cirugia = Presupuesto * 15 / 100;

            double suministro = Presupuesto * 25 / 100;

            double administracion = Presupuesto * 18 / 100;

            double laboratorio = Presupuesto * 5 / 100;

            double Imagenes_Diagnosticas = Presupuesto * 7 / 100;

            txt_emergencia.Text = emergencia.ToString();

            txt_cirugia.Text = cirugia.ToString();

            txt_suministro.Text = suministro.ToString();

            txt_administracion.Text = administracion.ToString();

            txt_laboratorio.Text = laboratorio.ToString();

            txt_imagenes_diagnostica.Text = Imagenes_Diagnosticas.ToString();


        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_suministro.Clear();
            txt_administracion.Clear();
            txt_laboratorio.Clear();    
            txt_cirugia.Clear();
            txt_emergencia.Clear();
            txt_imagenes_diagnostica.Clear();
            txt_presupuesto.Clear();
        }
    }
}
