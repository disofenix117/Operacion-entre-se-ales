using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

namespace operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void limpiagraficasI()
        {
            foreach (var series in grafico1.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in grafico2.Series)
            {
                series.Points.Clear();
            }


        }
        void limpiagraficasF()
        {
            foreach (var series in grafico3.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in grafico4.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in grafico5.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in grafico6.Series)
            {
                series.Points.Clear();
            }




        }
        void Corrimiento(double[] señal1 , double[] señal2, double k ,double c1, double c2)
        {
            double[] ejeXi1=new double[señal1.Length] ;
            double[] ejeXf1 = new double[ejeXi1.Length];
            double[] ejeXi2 = new double[señal2.Length];
            double[] ejeXf2 = new double[ejeXi2.Length];
            //double j = Convert.ToDouble(señal1[1]+k);

            //eje X (n)
            for ( int i=0 ; i<ejeXf1.Length;i++)
            {
                ejeXi1[i] = i-c1;
                ejeXf1[i] = ejeXi1[i]+k;      //corrimiento

                grafico3.Series[0].Points.AddXY(ejeXf1[i],señal1[i]);//señal 1

            }

            for (int i = 0; i < ejeXf2.Length; i++)
            {
                ejeXi2[i] = i - c2;
                ejeXf2[i] = ejeXi2[i] + k;      //corrimiento

                grafico4.Series[0].Points.AddXY(ejeXf2[i], señal2[i]);//señal 2

            }            
        }
        void Reflexion(double[] señal1, double[] señal2,double c1, double c2)
        {

            double[] ejeXi1 = new double[señal1.Length];
            double[] ejeXf1 = new double[ejeXi1.Length];
            double[] ejeXi2 = new double[señal2.Length];
            double[] ejeXf2 = new double[ejeXi2.Length];


            for (int i = 0; i < ejeXf1.Length; i++)
            {
                ejeXi1[i] = i - c1;

                ejeXf1[i] = -1 * ejeXi1[i];      //reflexion

                grafico3.Series[0].Points.AddXY(ejeXf1[i], señal1[i ]);//señal 1

            }

            for (int i = 0; i < ejeXf2.Length; i++)
            {
                ejeXi2[i] = i - c2;

                ejeXf2[i] = -1*ejeXi2[i];      //reflexion

                grafico4.Series[0].Points.AddXY(ejeXf2[i], señal2[i]);//señal 2

            }
        }

        void Submuestreo(double[] señal1, double[] señal2, double k,double c1, double c2)
        {
            double[] ejeXi1 = new double[señal1.Length];
            double[] ejeXf1 = new double[ejeXi1.Length];
            double[] ejeXi2 = new double[señal2.Length];
            double[] ejeXf2 = new double[ejeXi2.Length];
            double[] Señal = new double[ejeXi1.Length];
            //señal 1

            for (int i = 0; i < ejeXf1.Length; i++)
            {
                ejeXi1[i] = i - c1;

                ejeXf1[i] = k * ejeXi1[i];      
            }
            //submuestreo
            for (int i = 0; i < ejeXf1.Length; i++)
            {
                int j=0;
                while ( j < ejeXf1.Length)
                {

                    if (ejeXf1[i] == ejeXi1[j])
                    {

                        Señal[i] = Convert.ToDouble( señal1[j]);
                        j++;

                    }
                    else
                    {
                        j++;
                    }
                }

            }
            //Graficar
            for (int i = 0;i<ejeXf1.Length;i++)
            {
                grafico3.Series[0].Points.AddXY(ejeXf1[i], Señal[i]);//señal 1

            }

            //señal 2

            for (int i = 0; i < ejeXf2.Length; i++)
            {
                ejeXi2[i] = i - c2;

                ejeXf2[i] = k * ejeXi2[i];
            }
            //submuestreo
            for (int i = 0; i < ejeXf2.Length; i++)
            {
                int j = 0;
                while (j < ejeXf2.Length)
                {

                    if (ejeXf2[i] == ejeXi2[j])
                    {

                        Señal[i] = Convert.ToDouble(señal2[j]);
                        j++;

                    }
                    else
                    {
                        j++;
                    }
                }

            }
            //Graficar
            for (int i = 0; i < ejeXf2.Length; i++)
            {
                grafico4.Series[0].Points.AddXY(ejeXf2[i], Señal[i]);//señal 1

            }



        }

        void Escalado(double[] señal1, double[] señal2, double k,double c1, double c2)
        {
            double[] ejeXi1 = new double[señal1.Length];
            double[] ejeXi2 = new double[señal2.Length];

            for (int i = 0; i < ejeXi1.Length; i++)
            {
                ejeXi1[i] = i - c1;
                ejeXi2[i] = i - c2;

            }


            for (int i = 0; i < ejeXi1.Length; i++)
            {
                grafico3.Series[0].Points.AddXY(ejeXi1[i], k *Convert.ToDouble( señal1[i]));//señal 1
                grafico4.Series[0].Points.AddXY(ejeXi2[i], k * Convert.ToDouble(señal2[i]));//señal 2


            }


        }

        void suma(double[] señal1, double[] señal2 ,double c1, double c2)
        {

            double[] ejeXi1 = new double[señal1.Length];
            double[] ejeXi2 = new double[señal2.Length];

            for (int i = 0; i < ejeXi1.Length; i++)
            {
                ejeXi1[i] = i - c1;
                ejeXi2[i] = i - c2;

            }



            for (int i = 1; i < señal2.Length; i++)
            {
                double b;
                b = ( Convert.ToDouble(señal1[i]) + Convert.ToDouble(señal2[i])); //operacion de reflexion
                grafico5.Series[0].Points.AddXY(ejeXi1[i], b);
            }

        }
        void multiplicacion(double[] señal1, double[] señal2, double c1, double c2)
        {

            double[] ejeXi1 = new double[señal1.Length];
            double[] ejeXi2 = new double[señal2.Length];

            for (int i = 0; i < ejeXi1.Length; i++)
            {
                ejeXi1[i] = i - c1;
                ejeXi2[i] = i - c2;

            }


            for (int i = 1; i < señal2.Length; i++)
            {
                double b;
                b = (Convert.ToDouble(señal1[i]) * Convert.ToDouble(señal2[i])); //operacion de reflexion
                grafico6.Series[0].Points.AddXY(ejeXi1[i], b);
            }
        }



        void leerCSV(double c1,double c2)
        {
            var reader1 = new StreamReader(File.OpenRead(@"F:\Diego Suarez\U.M.N.G\Procesamiento de Señales\2.0\Trabajos\operaciones 2 (lee 2 archivos con pos de 0s diferentes)\operaciones\Files\S1.csv"));
            var reader2 = new StreamReader(File.OpenRead(@"F:\Diego Suarez\U.M.N.G\Procesamiento de Señales\2.0\Trabajos\operaciones 2 (lee 2 archivos con pos de 0s diferentes)\operaciones\Files\S2.csv"));

            List<string> lista = new List<string>();
            while(!reader1.EndOfStream && !reader2.EndOfStream)
            {
                var señales1 = File.ReadAllLines(@"F:\Diego Suarez\U.M.N.G\Procesamiento de Señales\2.0\Trabajos\operaciones 2 (lee 2 archivos con pos de 0s diferentes)\operaciones\Files\S1.csv").Length;
                var señales2 = File.ReadAllLines(@"F:\Diego Suarez\U.M.N.G\Procesamiento de Señales\2.0\Trabajos\operaciones 2 (lee 2 archivos con pos de 0s diferentes)\operaciones\Files\S2.csv").Length;

                //Capturando señales
                double[] señal1 = new double[señales1];
                double[] señal2 = new double[señales2];
                //guardando valores
                for (int i=0;i<señal1.Length;i++)
                {
                    señal1[i] =Convert.ToDouble( reader1.ReadLine());
                }
                for (int i = 0; i < señal2.Length; i++)
                {
                    señal2[i] = Convert.ToDouble(reader2.ReadLine());
                }
                //valores del eje x
                double[] ejeXi1 = new double[señal1.Length];
                double[] ejeXi2 = new double[señal2.Length];

                for (int i = 0; i < ejeXi1.Length; i++)
                {
                    ejeXi1[i] = i - c1;
                    ejeXi2[i] = i - c2;
                }
                //pintando señales
                for (int i = 0; i < señal1.Length; i++)
                {
                    grafico1.Series[0].Points.AddXY(ejeXi1[i],Convert.ToDouble(señal1[i]));
                    grafico2.Series[0].Points.AddXY(ejeXi2[i], Convert.ToDouble(señal2[i]));

                }

                

            }
        }

        private void importar_Click(object sender, EventArgs e)

        {
            double c1,c2;
            limpiagraficasI();

            if (String.IsNullOrEmpty(ceroPos1.Text)) c1 = 0; else c1 = double.Parse(ceroPos1.Text);
            if (String.IsNullOrEmpty(ceroPos1.Text)) c2 = 0; else c2 = double.Parse(ceroPos2.Text);


            leerCSV(c1,c2);

        }

        private void NVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiagraficasF();

            string Operacion =operacion.Text;
            double k,c1,c2;

            if (String.IsNullOrEmpty(NVal.Text)) k = 0; else k = double.Parse(NVal.Text);
            if (String.IsNullOrEmpty(ceroPos1.Text)) c1 = 0; else c1 = double.Parse(ceroPos1.Text);
            if (String.IsNullOrEmpty(ceroPos2.Text)) c2 = 0; else c2 = double.Parse(ceroPos2.Text);

            var reader1 = new StreamReader(File.OpenRead(@"F:\Diego Suarez\U.M.N.G\Procesamiento de Señales\2.0\Trabajos\operaciones 2 (lee 2 archivos con pos de 0s diferentes)\operaciones\Files\S1.csv"));
            var reader2 = new StreamReader(File.OpenRead(@"F:\Diego Suarez\U.M.N.G\Procesamiento de Señales\2.0\Trabajos\operaciones 2 (lee 2 archivos con pos de 0s diferentes)\operaciones\Files\S2.csv"));

            List<string> lista = new List<string>();

            while (!reader1.EndOfStream && !reader2.EndOfStream)
            {

                var señales1 = File.ReadAllLines(@"F:\Diego Suarez\U.M.N.G\Procesamiento de Señales\2.0\Trabajos\operaciones 2 (lee 2 archivos con pos de 0s diferentes)\operaciones\Files\S1.csv").Length;
                var señales2 = File.ReadAllLines(@"F:\Diego Suarez\U.M.N.G\Procesamiento de Señales\2.0\Trabajos\operaciones 2 (lee 2 archivos con pos de 0s diferentes)\operaciones\Files\S2.csv").Length;

                //Capturando señales
                double[] señal1 = new double[señales1];
                double[] señal2 = new double[señales2];
                //guardando valores
                for (int i = 0; i < señal1.Length; i++)
                {
                    señal1[i] = Convert.ToDouble(reader1.ReadLine());
                }
                for (int i = 0; i < señal2.Length; i++)
                {
                    señal2[i] = Convert.ToDouble(reader2.ReadLine());
                }
                //valores del eje x
                double[] ejeXi1 = new double[señal1.Length];
                double[] ejeXi2 = new double[señal2.Length];

                for (int i = 0; i < ejeXi1.Length; i++)
                {
                    ejeXi1[i] = i - c1;
                    ejeXi2[i] = i - c1;

                }


                switch (Operacion)
                {
                    case "Corrimiento":
                        {
                            Corrimiento(señal1, señal2, k,c1,c2);
                            break;
                        }
                    case "Reflexion":
                        {
                            Reflexion(señal1, señal2,c1, c2);
                            break;
                        }
                    case "Submuestreo":
                        {
                            Submuestreo(señal1, señal2, k,c1, c2);
                            break;
                        }
                    case "Escalado":
                        {
                            Escalado(señal1, señal2, k,c1, c2);
                            break;
                        }

                }
                suma(señal1, señal2,c1, c2);
                multiplicacion(señal1, señal2,c1, c2);




            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void grafico4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void grafico2_Click(object sender, EventArgs e)
        {

        }
    }
}
