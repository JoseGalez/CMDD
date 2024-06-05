using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int[] numeros = new int[100];
        private static int cont = 0;
        private static int acum = 0;
        private static double prom = 0;
        static int BusquedaSecuencial( int cont)
        {
            int i= 0;
            int pos = -1;
            while (pos == -1 && i < cont)
            {
                if (numeros[i] == cont)
                {
                    pos = i;
                    i++;
                }
            }
            return pos;
        }
        static void MetodoBurbuja()
        {
            int aux = 0;
            int i = 0, j = 0;
            for(i = 0; i < cont -1; i++)
            {
                for(j = i +1; j < cont; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;

                    }
                }
            }
        }

        static int BusquedaBinaria(int buscado)
        {
            int izq = 0;
            int der = cont;
            int med = 0;
            int ret = -1;
            bool eureka = false;
            do
            {
                med = izq + der / 2;
                if (numeros[med] == buscado)
                {
                    eureka = true;

                }
                else
                {
                    if (numeros[med] < buscado)
                    {
                        izq = med + 1;

                    }
                    else
                    {
                        der = med - 1;
                    }
                }

            } while (izq <= der && eureka == false);
            if (eureka)
            {
                ret = med;
            }return ret;
        }
       private void button4_Click(object sender, EventArgs e)
        {
            int valor = 0;
            valor = Convert.ToInt32(tbBusqueda.Text);
           if(rbSecuencial.Checked == true ){
                BusquedaSecuencial(valor);
                MessageBox.Show($"{valor}");
           }
           else
            { if (rbBinaria.Checked == true)
              {
                    MetodoBurbuja();
                    BusquedaBinaria(valor);
                    MessageBox.Show($"{valor}");
                }
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarNombre_Click(object sender, EventArgs e)
        {
            numeros[cont] = Convert.ToInt32(tbIngresar.Text);
            acum += Convert.ToInt32(tbIngresar.Text);
            cont++;
            tbIngresar.Clear();
        
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            prom = acum / cont;
            label1.Text = $"{prom:f2}";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MetodoBurbuja();
            for (int i = 0; i < cont; i++)
            {
                listBox1.Items.Add($"{numeros[i]}");
            }
        }
    }
}
