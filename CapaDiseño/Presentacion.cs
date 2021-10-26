using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogica;

namespace CapaDiseño
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            Inicio FormInicio = new Inicio(Convert.ToInt32(txtNumVectores.Text));
            FormInicio.Visible = true;
            Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Componentes Rectangulares: \n" +
                            "Éste método consiste en proyectar cada una de las fuerzas " +
                            "a sumar sobre los dos ejes cartesianos (es decir descomponer " +
                            "cada fuerza en dos), luego hacer una suma de fuerzas por cada eje" +
                            "(obteniendo dos resultantes) y por último componer las dos fuerzas " +
                            "resultantes en una única fuerza." +
                            "\n\n" +
                            "Realizado por: CAMBIARLE");
        }
    }
}
