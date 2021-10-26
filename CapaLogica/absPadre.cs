using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public abstract class absPadre
    {

        public const double Radian = 0.0174533;

        public double[] Vectores;
        //Angulos Originales
        public double[] Angles;
        //Copia de los angulos
        public double[] Angulos;

        public int NumeroPosicionesXY { get; set; }


        public void NumeroPosicionArreglo(int _numPosiciones)
        {
            Vectores = new double[_numPosiciones];
            Angles = new double[_numPosiciones];
            Angulos = new double[_numPosiciones];
        }
    }
}
