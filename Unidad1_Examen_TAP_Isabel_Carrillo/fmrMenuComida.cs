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
    public partial class fmrMenuComida : Form
    {
        //creamos variables publicas para guardar el progreso de los progressbar y una variable que guarda el total de la compra
        public int progressPizza, progressLonche, progressSandwich, progressGordita, total;
        private string usuario;//variable que será usada para mostrar el nombre del usuario guardado en el form1 
        fmrImagen imagen;//se crea una variable de tipo fmrImagen (formulario que contiene los requisitos para mostrar imagenes)
        public fmrMenuComida(string usuario)//costructor que pide un único parámetro con el nombre del usuario
        {
            InitializeComponent();
            this.usuario = usuario;//se manda a llamar la variable usuario que es un parámetro
        }
        //creamos un evento load para que muestre un from con las imagenes de la comida
        private void fmrMenuComida_Load(object sender, EventArgs e)
        {
            //en la variable de tipo fmrImagen se guarda la ubicación de la imagen
            imagen = new fmrImagen(this.Location.X + ClientSize.Width + 50, this.Location.Y + ClientSize.Height - 280);
            toolLabel.Text = usuario; //se muestra el nombre del usuario en statusstrip
        }
        //creamos el evento click para sandwich
        private void btnSandwich_Click(object sender, EventArgs e)
        {
            if (progressSandwich >= 0 && progressSandwich <= 90)//condición que no permite seleccíonar mas de 10 piezas de sandwich
            {
                total += 20;//variable global, se aumenta el costo al total
                progressSandwich += 10;//para que la barra de progreso aumente de 10 cada vez que de click
                pbSandwich.Value = progressSandwich;//para que la barra de progreso aumente de 10 cada vez que de click
                lblTotalD.Text = total.ToString();//se muestra el nuevo total
            }
        }
        //creamos el evento click para lonche
        private void btnLonche_Click(object sender, EventArgs e)
        {
            if (progressLonche >= 0 && progressLonche <= 90)//condición que no permite seleccíonar mas de 10 piezas de lonche
            {
                total += 40;//variable global, se aumenta el costo al total
                progressLonche += 10;//para que la barra de progreso aumente de 10 cada vez que de click
                pbLonche.Value = progressLonche;//para que la barra de progreso aumente de 10 cada vez que de click
                lblTotalD.Text = total.ToString();//se muestra el nuevo total
            }
        }
        //creamos el evento click para gordita
        private void btnGordita_Click(object sender, EventArgs e)
        {
            if (progressGordita >= 0 && progressGordita <= 90)//condición que no permite seleccíonar mas de 10 piezas de gordita
            {
                total += 10;//variable global, se aumenta el costo al total
                progressGordita += 10;//para que la barra de progreso aumente de 10 cada vez que de click
                pbGordita.Value = progressGordita;//la barra de progreso se iguala a la cantidad de clicks que se dan al botón
                lblTotalD.Text = total.ToString();//se muestra el nuevo total
            }
        }
        //creamos el evento click para pizza
        private void btnPizza_Click(object sender, EventArgs e)
        {
            if (progressPizza >= 0 && progressPizza <= 90)//condición que no permite seleccíonar mas de 10 piezas de pizza
            {
                total += 25;//variable global, se aumenta el costo al total
                progressPizza += 10;//para que la barra de progreso aumente de 10  cada vez que de click
                pbPizza.Value = progressPizza;//la barra de progreso se iguala a la cantidad de clicks que se dan al botón
                lblTotalD.Text = total.ToString();//se muestra el nuevo total
            }
        }
        private void toolButon_ButtonClick(object sender, EventArgs e)//evento click en el botón que se encuentra en el statusstrip para cerrar sesión
        {
            this.DialogResult = DialogResult.OK;//esta respuesta se envia al form1 para volver a dicho formulario
            this.Close();//el formularío actual se cierra
        }
        private void btnPizza_MouseHover(object sender, EventArgs e)//evento para mostrar una imagen cuando el cursor esté sobre el botón pizza y no se mueva
        {
            imagen.pbImagen.Image = Properties.Resources.Pizza;//cargara la imagen elegida a la variable imagen de tipo fmrImagen
            imagen.Show(); //la mostrara en un show para no generar más procesos
        }

        private void btnPizza_MouseLeave(object sender, EventArgs e)//evento que ocurre cuando el cursor no está sobre el botón pizza
        {
            imagen.Hide();//esconde el form que contiene la imagen
        }
        //creamos un evento de mouseHover
        private void btnSandwich_MouseHover(object sender, EventArgs e)//evento para mostrar una imagen cuando el cursor esté sobre el botón sandwich y no se mueva
        {
            imagen.pbImagen.Image = Properties.Resources.Sandwich;//cargara la imagen elegida a la variable imagen de tipo fmrImagen
            imagen.Show();//la mostrara en un show para no generar más procesos
        }
        private void btnSandwich_MouseLeave(object sender, EventArgs e)//evento que ocurre cuando el cursor no está sobre el botón pizza
        {
            imagen.Hide();//esconde el form que contiene la imagen
        }
        private void btnLonche_MouseHover(object sender, EventArgs e)//evento para mostrar una imagen cuando el cursor esté sobre el botón lonche y no se mueva
        {
            imagen.pbImagen.Image = Properties.Resources.Lonche;//cargara la imagen elegida a la variable imagen de tipo fmrImagen
            imagen.Show();//la mostrara en un show para no generar más procesos
        }
        private void btnLonche_MouseLeave(object sender, EventArgs e)//evento que ocurre cuando el cursor no está sobre el botón pizza
        {
            imagen.Hide();//esconde el form que contiene la imagen
        }
        private void btnGordita_MouseHover(object sender, EventArgs e)//evento para mostrar una imagen cuando el cursor esté sobre el botón gordita y no se mueva
        {
            imagen.pbImagen.Image = Properties.Resources.Gordita;//cargara la imagen elegida a la variable imagen de tipo fmrImagen
            imagen.Show();//la mostrara en un show para no generar más procesos
        }
        private void btnGordita_MouseLeave(object sender, EventArgs e)//evento que ocurre cuando el cursor no está sobre el botón pizza
        {
            imagen.Hide();//esconde el form que contiene la imagen
        }

    }
}
