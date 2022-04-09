using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Nombre de la escuela : Tec. San Pedro de las colonias
Clave de actividad : TAPU1_A4_INT
Nombre de la actividad :
PIDETEC
Objetivo : Desarrollar e implementar una aplicación para windows forms, 
haciendo uso del lenguaje de programación C# y el IDE visual studio community edition (2015+), 
que permita tomar órdenes de comida en la cafetería de una institución educativa.
Nombre del maestro: Ulises Martínez Rodríguez.
Nombre de la materia: Tópicos Avanzados de programación
Nombre de la unidad :
unidad I: interfaz gráfica de usuario.
Nombrre y matricula de los alumnos:
Isabel Esmeralda Carrillo Rodríguez 201000067  
Ramón Abraham Santana Rodríguez 201000076
Diana Karen Velasquez Vazquez 201000114
Jorge Luis Cervantes Lujan 201000069

 */
namespace Unidad1_Examen_TAP_Isabel_Carrillo
{
    public partial class Form1 : Form
    {
        //se crea un directorio para alumnos y uno para empleados.
        Dictionary<string, string> Alumno = new Dictionary<string, string>();
        Dictionary<string, string> Empleado = new Dictionary<string, string>();
        //se crea una variable global que va a guardar el nombre del usuario, tiene que ser una variable estatica y pública, pues se usará en fmrMenuComida
        public static string usuario;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //se llena el directorio de alumnos con 10 alumnos
            Alumno.Add("201000067", "CARRILLO RODRIGUEZ ISABEL");//nombre muy largo que ocultaban el boton de cerrar sesión
            Alumno.Add("201000076", "SANTANA RODRIGUEZ RAMON");//nombre muy largo que ocultaban el boton de cerrar sesión
            Alumno.Add("201000114", "VELASQUEZ VAZQUEZ DIANA KAREN");
            Alumno.Add("201000069", "CERVANTES LUJAN JORGE LUIS");
            Alumno.Add("201000175", "CARRIZALES CARRILLO LUIS GAEL");
            Alumno.Add("201000133", "LOZA MILAN LEONARDO");
            Alumno.Add("201000188", "OCHOA ESPARZA SANJUANA MELISSA");
            Alumno.Add("201000152", "SCOTT CARREON PAOLA ALEJANDRA");
            Alumno.Add("201000151", "MARTINEZ RAMIRES DANIELA");
            Alumno.Add("201000150", "ZURITA DE LA CRUZ ADRIANA");
            //se llena el directorio de empleados con 10 empleados
            Empleado.Add("001", "UMR");
            Empleado.Add("002", "ISABEL CARILLO RODRIGUEZ");
            Empleado.Add("003", "SANTANA RODRIGUEZ RAMON");
            Empleado.Add("004", "VELASQUEZ VAZQUEZ DIANA KAREN");
            Empleado.Add("005", "ADRIANA ZURITA DE LA CRUZ");
            Empleado.Add("006", "CERVANTES LUJAN JORGE LUIS");
            Empleado.Add("007", "KEVIN OROZCO REBOLLAR");
            Empleado.Add("008", "IDAIA RUIZ ARROYO");
            Empleado.Add("009", "LEONARDO LOZA MILAN");
            Empleado.Add("010", "ALEJANDRO HERNANDEZ LOPEZ");
        }
        //evento cheked en chkInvitado
        private void chkInvitado_CheckedChanged(object sender, EventArgs e)
        {
            //Condicional, en caso que el evento sea cierto "true"
            if (chkInvitado.Checked == true)
            {//en un DialogResult (para guardar una respuesta sí/no), se genera una pregunta
                DialogResult result = MessageBox.Show("¿Estas seguro que deseas ingresar como invitado?", "PIDETEC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)//Condicional, en caso de que la respuesta sea sí
                {
                    txtNombre.Focus(); //Pone el foco de atención (selecciona, por así decir el txtNombre)
                    txtNombre.Text = "Ingresa tu nombre de usuario";//en el txtNombre escribe lo siguiente
                }
                if (result == DialogResult.No)//condicional en caso de seleccionar no
                {
                    chkInvitado.Checked = false; //el evento checked se vuelve falso
                    txtNombre.Text = "Ingresa tu matricula o número de empleado";//en el txtNombre escribe lo siguiente
                }
            }
            if (chkInvitado.Checked == false)//Condicional en caso de que el evento sea falso
            {
                chkInvitado.Checked = false;//el evento checked se mantiene falso 
                txtNombre.Text = "Ingresa tu matricula o número de empleado";//en el txtNombre escribe lo siguiente
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)//evento click en el botón aceptar
        {
            string msg = string.Empty;//a la variable msg se le borra el contenido
            string usuario = string.Empty;//a la variable usuario se le borra el contenido
            //condicional para buscar en los diccionarios el Número de empelado o el Número de matricula o bien si está seleccionada la opción invitado 
            if (Alumno.ContainsKey(txtNombre.Text) || Empleado.ContainsKey(txtNombre.Text) || chkInvitado.Checked == true)
            {
                if (Alumno.ContainsKey(txtNombre.Text))//en caso que el contenido del txtNombre se encuentre en el directorio Alumno:
                {//en la variable msg se guardará un texto con formato y un mensaje para el usuario y el nombre que se encuentre en el txtNombre
                    msg = string.Format("Bienvenido a PIDETEC estimado alumno: {0}, espero tu visita sea placentera.", Alumno[txtNombre.Text].ToString());
                    usuario = Alumno[txtNombre.Text].ToString();//en la variable global, usuario se guarda el contenido del txtNombre
                }
                if (Empleado.ContainsKey(txtNombre.Text))//en caso que el contenido del txtNombre se encuentre en el directorio Empleado:
                {//en la variable msg se guardará un texto con formato y un mensaje para el usuario y el nombre que se encuentre en el txtNombre
                    msg = string.Format("Bienvenido a PIDETEC {0}", Empleado[txtNombre.Text].ToString());
                    usuario = Empleado[txtNombre.Text].ToString();//en la variable global, usuario se guarda el contenido del txtNombre
                }
                if (chkInvitado.Checked == true)//en caso de que el evento checked sea cierto:
                {//en la variable msg se guardará un cuadro de texto con un mensaje para el usuario y el nombre que se encuentre en el txtNombre
                    msg = string.Format("Bienvenido señor invitado llamado: {0}", txtNombre.Text);
                    usuario = txtNombre.Text;//en la variable global, usuario se guarda el contenido del txtNombre
                }
                MessageBox.Show(msg);//con un messageBox se muestra el contenido de la variable msg
                fmrMenuComida cambiar = new fmrMenuComida(usuario); //se manda llamar el formulario fmrMenuComida y se le da un parámetro con el nombre del usuario
                this.Hide();//se esconde el formulario de login
                DialogResult dialogResult = cambiar.ShowDialog();//para que no se creen más procesos, se utiliza un DialogResult con el formulario del menu
                if (dialogResult == DialogResult.OK) //condición mientras el DialogResult regrese un valor ok 
                {
                    this.Show();// se vuelve a mostrar este formulario
                }
            }
            else //si el nombre del usuario no existe en los directorios y no está checkeado invitado, entonces:
            {
                MessageBox.Show("Usuario no encontrado");//se mostrará el siguiente cuadro de texto
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)//evento al presionar una tecla en el txtNombre
        {
            if (chkInvitado.Checked == true)//en caso de que el evento checked sea cierto:
            {//se crea una condición que no permite mayúsculas, minúsculas y las teclas delet y backspace (al final serán estás las que se puedan usar)
                if (e.KeyChar >= 00 && e.KeyChar <= 64 && e.KeyChar != 127 && e.KeyChar != 08 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
                {
                    e.Handled = true;//los caracteres que entren en la condición no podrán ser usados
                    MessageBox.Show("Solo puedes ingresar letras"); //mostramos el siguente mensaje
                }
            }
            else//si el evento checked es falso
            {//se crea una condición que no permite números y las teclas delet y backspace (al final serán estás las que se puedan usar)
                if (e.KeyChar >= 00 && e.KeyChar <= 47 && e.KeyChar != 127 && e.KeyChar != 08 || e.KeyChar >= 58 && e.KeyChar <= 255)
                {
                    e.Handled = true;//los caracteres que entren en la condición no podrán ser usados
                    MessageBox.Show("Solo puedes ingresar números"); //mostramos el siguente mensaje
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)//evento click en el botón cancelar
        {
            Application.Exit();//cuando se de click en el botón cancelar se va a salir del programa cerrando todas las tareas
        }
        private void txtNombre_Click(object sender, EventArgs e)//evento click en el textbox nombre
        {
            txtNombre.Text = string.Empty;//se borra el contenido del textbox
        }
    }
}
