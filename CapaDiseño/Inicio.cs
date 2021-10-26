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
    public partial class Inicio : Form
    {
        clsComponentesRectangulares ObjComRec = new clsComponentesRectangulares();
        clsGraficacion ObjGrafica = new clsGraficacion();
        int _numPosiciones = 0;


        public Inicio(int cantidadVectores)
        {
            InitializeComponent();
            ObjComRec.NumeroPosicionArreglo(cantidadVectores);
            ObjComRec.NumeroPosicionesXY = cantidadVectores;
            btnNext.Enabled = true;
            btnObtnerComRectangular.Enabled = true;
            btnDibujarFuerzaResultante.Enabled = true;
        }

        private void btnObtnerComRectangular_Click(object sender, EventArgs e)
        {
            lblSumatoriaVectores.Text = lblSumatoriaVectores.Text + Convert.ToString(ObjComRec.SumatoriaFuerzas());
            lblAnguloResultante.Text = lblAnguloResultante.Text + Convert.ToString(ObjComRec.AnguloResultanteVector());
            ObjGrafica.DibujarVectores(pnGraficación, ObjComRec.Vectores.Length, ObjComRec.ComponenteX(), ObjComRec.ComponenteY(), ObjComRec.Vectores, ObjComRec.Angles);
            lblComponentesReultantes.Text = ObjComRec.ImprimirComponentesFuerzaResultante();
            lblImprimirComponentes.Text = ObjComRec.ImprimirComponentesDeCadaVector();
            btnObtnerComRectangular.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rbtComponentesRectangulares.Checked == true)
            {
                ObjComRec.Vectores[_numPosiciones] = Convert.ToDouble(txtVector.Text);
                ObjComRec.Angles[_numPosiciones] = Convert.ToDouble(txtAngle.Text);
                ObjComRec.Angulos[_numPosiciones] = Convert.ToDouble(txtAngle.Text);
                _numPosiciones++;
                txtAngle.Text = "";
                txtVector.Text = "";
                if (ObjComRec.Vectores.Length == _numPosiciones)
                    btnNext.Enabled = false;
                
            }

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujarFuerzaResultante_Click(object sender, EventArgs e)
        {
            //DibujoFuerzaResultante FormDibujo = new DibujoFuerzaResultante(ObjComRec.SumatoriaFuerzas(), ObjComRec.AnguloResultanteVector());

            //FormDibujo.Visible = true;

            ObjGrafica.DibujarFuerzaResultante(pnGraficación, ObjComRec.SumatoriaFuerzas(), ObjComRec.AnguloResultanteVector());


        }

        private void btnNewEjercicio_Click(object sender, EventArgs e)
        {
            Presentacion FormPresent = new Presentacion();
            FormPresent.Visible = true;
            Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
