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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //oculta la ventana

            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.Show();//enseña la ventana
        }
    }
}
