using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad1_Examen_TAP_Isabel_Carrillo
{
    public partial class fmrImagen : Form
    {//variables globales de tipo entero, servirán para guardar las coordenadas
        int x, y;
        public fmrImagen(int x, int y)//costructor con 2 parámetros que guardan las coordenadas
        {
            InitializeComponent();
            this.x = x;//se guarda el parámetro que contiene la coordenada en x en x en este formulario
            this.y = y;//se guarda el parámetro que contiene la coordenada en y en y en este formulario
        }
        private void fmrImagen_Load(object sender, EventArgs e)//evento cargar o iniciar
        {
            this.Location = new Point(x, y);//coordenadas donde se mostrará la imagen
        }
    }
}

