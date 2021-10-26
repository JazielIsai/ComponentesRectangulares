using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CapaLogica
{
    public class clsGraficacion 
    {
        //Para poder llevar acabo la graficación necesitamos crear un objeto de tipo Grafico
        Graphics ObjGrafica;
        //Creamos lapizes para la representacion de estos graficos que se haran
        Pen ObjPenBlack = new Pen(Color.Black, 3);
        Pen ObjPenBlue = new Pen(Color.Blue, 3);

        //Variables la cual se les daran las medidas de lo alto(Y) y ancho(X) del espacio que se dibujara (Panel)
        int medidaX = 0;
        int mediday = 0;

        //Obtendra cada una de las cordenadas
        public int CordenadaX { get; set; }
        public int CordenadaY { get; set; }

        //Graficaremos el plano carteciano con el cual empezaremos a graficar nuestras graficas apartir de aqui.
        public void PlanoCarteciano(Panel pn)
        {
            medidaX = pn.Width / 2;
            mediday = pn.Height / 2;

            

            ObjGrafica = pn.CreateGraphics();

            //Dibujar Plano carteciano
            ObjGrafica.DrawLine(ObjPenBlack, 0, mediday, 604, mediday); 
            ObjGrafica.DrawLine(ObjPenBlack, medidaX, 0, medidaX, 604);


        }

        //Creación de la graficación de las fuerzas
        public void DibujarVectores(Panel pn, int _numPocisiones, double[] _cordenadaX, double[] _cordenadaY, double[] Vector, double[] Angulo)
        {
            medidaX = pn.Width / 2; //medida en X es igual a 309
            mediday = pn.Height / 2; //medida en Y es igual a 308

            PlanoCarteciano(pn);

            Font Fuente = new Font("Times New Roman", 6);

            //Vector
            for (int i = 0; i < _numPocisiones; i++)
            {
                CordenadaX = Convert.ToInt32(_cordenadaX[i]);
                CordenadaY = Convert.ToInt32(_cordenadaY[i]);
                //Dibuja las fuerzas dadas por el usuario
                ObjGrafica.DrawLine(ObjPenBlue, medidaX, mediday, 309 + CordenadaX, 308 - CordenadaY);
                //Dibuja las cordenadas correspondiente al vector que se dibujo
                ObjGrafica.DrawString("V = " + Convert.ToInt32(Vector[i]) + " / " + Convert.ToInt32(Angulo[i]) + "°", Fuente, Brushes.WhiteSmoke, 309 + CordenadaX, 308 - CordenadaY);

            }
            
            //Liberamos los recursos que hemos utilizado de estos objetos
            //ObjPenBlack.Dispose();
            //ObjPenBlue.Dispose();
            //ObjGrafica.BeginContainer();
        }

        public void DibujarFuerzaResultante(Panel pn, double FuerzaResultante, double AnguloResultante)
        {
            PlanoCarteciano(pn);

            mediday = pn.Height / 2;
            medidaX = pn.Width / 2;

            Font Fuente = new Font("Times New Roman", 6);

            ObjGrafica.DrawLine(ObjPenBlue, medidaX, mediday, medidaX + Convert.ToInt32(FuerzaResultante), mediday + Convert.ToInt32(AnguloResultante));
            //ObjGrafica.DrawString("FR = " + Convert.ToInt32(FuerzaResultante) + " / " + Convert.ToInt32(AnguloResultante) + "°", Fuente, Brushes.WhiteSmoke, medidaX + CordenadaX, mediday - CordenadaY);
        }
    }
}
