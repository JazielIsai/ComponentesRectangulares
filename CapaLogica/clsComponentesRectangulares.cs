using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class clsComponentesRectangulares : absPadre
    {
        //Éste método consiste en proyectar cada una de las fuerzas a sumar sobre los dos ejes cartesianos
        //(es decir descomponer cada fuerza en dos), luego hacer una suma de fuerzas por cada eje
        //(obteniendo dos resultantes) y por último componer las dos fuerzas resultantes en una única fuerza.

        //Variables donde Ax sera el resultado de la sumatoria de las componentes de las fuerzas en X
        // y Ay sera el resultado de la sumatoria de las componentes de las fuerzas en Y
        private double Ax = 0, Ay = 0;
        //Arreglos donde en las posiciones guardaremos el resultado de las componentes de cada vector  o fuerza ingresada
        private double[] _componenteX;
        private double[] _componenteY;
        
        //Visual Studio al momento de calcular con Cos, Sen, Tan, lo hace por medio de radianes, asi que convertiremos los grados en redianes
        public void ConvertirAngulosRadian()
        {
            for (int i = 0; i < NumeroPosicionesXY; i++)
            {
                Angulos[i] = Angulos[i] * Radian;
            }
        }

        //Se realiza la sumatoria de las fuerzas obtenidas por el usuario 
        public double SumatoriaFuerzas()
        {
            double resultante = 0;

            ConvertirAngulosRadian();

            for (int i = 0; i < NumeroPosicionesXY; i++)
            {
                //Rx = v1Cosθ + v2Cosθ + v3Cosθ
                Ax = Ax + Vectores[i] * Math.Cos(Angulos[i]);

                //Ry = v1Sinθ + v2Sinθ + v3Sinθ
                Ay = Ay + Vectores[i] * Math.Sin(Angulos[i]);
            }
            
            //c = Raiz Cuadrada (ax^2 + ay^2) --- Formula geneal 
            resultante = Math.Sqrt(Math.Pow(Ax, 2) + Math.Pow(Ay, 2));

            return resultante;
        }

        //Se obtiene cada componenteX de cada fuerza ingresada
        public double[] ComponenteX()
        {
            _componenteX = new double[NumeroPosicionesXY];

            for (int i = 0; i < NumeroPosicionesXY; i++)
            {
                //Rx = v1Cosθ 
                _componenteX[i] = Vectores[i] * Math.Cos(Angulos[i]);
            }
            return _componenteX;
        }

        //Se obtiene cada componenteY de cada fuerza ingresada
        public double[] ComponenteY()
        {
            _componenteY = new double[NumeroPosicionesXY];

            for (int i = 0; i < NumeroPosicionesXY; i++)
            {
                //Ry = v1Sinθ 
                _componenteY[i] = Vectores[i] * Math.Sin(Angulos[i]);
            }
            return _componenteY;
        }

        //Aplicamos la formula para obtener el angulo de la fuerza resultante
        public double AnguloResultanteVector()
        {
            //teta (0) =  tan -1 (AY / AX)
            double teta = 0;
            teta = Math.Atan(Ay / Ax);
            teta = teta * 57.2958; //El 57.2958 es lo que vale un radian en angulo 
            return teta;
        }

        ////Aplicamos la formula para obtener el angulo de la fuerza resultante para poder graficarlo
        //public double AnguloResultanteVectorGrafica()
        //{
        //    //teta (0) =  tan -1 (AY / AX)
        //    double teta = 0;
        //    teta = Math.Atan(Ay / Ax);
        //    return teta;
        //}

        //Imprimimos valores
        public string ImprimirComponentesDeCadaVector()
        {
            StringBuilder XY = new StringBuilder();

            for (int i = 1; i < NumeroPosicionesXY + 1; i++)
            {
                XY.AppendLine(i + ".- Vector " + Vectores[i - 1] + " y Angulo" + Angles[i - 1] + ":");
                XY.AppendLine("Componente X: " + Math.Round(ComponenteX()[i - 1], 2));
                XY.AppendLine("Componente Y: " + Math.Round(ComponenteY()[i - 1], 2) + "\n\n");
            }

            return XY.ToString();
        }

        //Imprimimos valores
        public string ImprimirComponentesFuerzaResultante()
        {
            StringBuilder XY = new StringBuilder();

            XY.AppendLine("Componente X: " + Math.Round(Ax, 2));
            XY.AppendLine("Componente Y: " + Math.Round(Ay, 2));

            return XY.ToString();
        }

    }
}
