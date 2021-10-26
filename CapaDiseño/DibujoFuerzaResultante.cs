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
    public partial class DibujoFuerzaResultante : Form
    {
        clsGraficacion ObjGraficar = new clsGraficacion();        
        public DibujoFuerzaResultante(double fuerzaResultante, double AnguloResultante)
        {
            InitializeComponent();
            ObjGraficar.DibujarFuerzaResultante(pnGrafica, fuerzaResultante, AnguloResultante);
            label1.Text = fuerzaResultante.ToString();
        }

        private void DibujoFuerzaResultante_Load(object sender, EventArgs e)
        {

        }
    }
}
