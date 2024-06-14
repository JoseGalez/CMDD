using ControlDeEmbarque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeEmbarque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Controlador nacho = new Controlador();
        private void button1_Click(object sender, EventArgs e)
        {
            FormVerListado ver = new FormVerListado();
            nacho.Burbuja();
            for(int i = 0; i < nacho.cont; i++)
            {
                ver.lbResultado.Items.Add($"{nacho.idContenedor[i]} -- {nacho.paisorg[i]} -- {nacho.pesoc[i]}");
            }
            ver.ShowDialog();
            ver.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            int id = 0;
            double peso = 0;
            string pais = "";
            if (agregar.ShowDialog() == DialogResult.OK)
            { 
                    id = Convert.ToInt32(agregar.duID.Text);
                    peso = Convert.ToDouble(agregar.duPeso.Text);
                    pais = agregar.cbPais.Text;
                    nacho.AgregarContenedor(id, pais, peso);
            }
            agregar.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar buscar = new FormBuscar();
            int[] listado = new int[100];
            int cant = 0, idx = 0,id = 0;
            double peso = 0;
            string pais = "";
            listado = nacho.BuscarPorOrigen(tbBuscar.Text, ref cant);
            for(int i =0; i < cant; i++)
            {
                idx = listado[i];
                id = nacho.idContenedor[idx];
                pais = nacho.paisorg[idx];
                peso = nacho.pesoc[idx];
                buscar.lbBuscar.Items.Add($"{id}--{pais}--{peso}");
            }
            buscar.ShowDialog();
            buscar.Dispose();
        }
    }
}
