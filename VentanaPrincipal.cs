using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        //Método que cerrará la app entera si se cxierra el form
        protected override void OnFormClosing(FormClosingEventArgs e)//closed == se esta cerrando
        {

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventana01 ventana = new Ventana01();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventana01 ventana = new Ventana01();
            ventana.Show();

        }
        
    }
}

