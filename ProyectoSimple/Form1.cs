using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace ProyectoSimple
{
    public partial class Form1 : Form
    {
        private List<Persona> ListaPersonas;
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConexionDB conexionUno = new ConexionDB();
            ListaPersonas = conexionUno.Listar();
            dgvPersonas.DataSource = ListaPersonas;
            dgvPersonas.Columns["UrlFoto"].Visible = false;

            Persona seleccionada = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            cargarImagen(seleccionada.UrlFoto);
        }
    
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Persona seleccionada = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            cargarImagen(seleccionada.UrlFoto);
        }

//--------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnCargaPersona_Click(object sender, EventArgs e)
        {
            Persona PersonaNueva = new Persona();


            string Nombre = txbNombre.Text;
            string Nacionalidad = txbNacionalidad.Text;
            string UrlFoto = txbUrlFoto.Text;
            int Edad = (int)nudEdad.Value;

            PersonaNueva.Edad = Edad;
            PersonaNueva.UrlFoto = UrlFoto;
            PersonaNueva.Nacionalidad = Nacionalidad;
            PersonaNueva.Nombre = Nombre;
                       
            ConexionDB ConexionCargar = new ConexionDB();
            ConexionCargar.Cargar(PersonaNueva);
            ListaPersonas = ConexionCargar.Listar();
            dgvPersonas.DataSource = ListaPersonas;

        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {

            ConexionDB ConexionBorrar = new ConexionDB();
            Persona PersonaABorrar = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            ConexionBorrar.Borrar(PersonaABorrar);

        //------------------------------------------------------------------------------------

            ListaPersonas = ConexionBorrar.Listar();
            dgvPersonas.DataSource = ListaPersonas;

            Persona seleccionada = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            cargarImagen(seleccionada.UrlFoto);

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbFoto.Load(imagen);
            }
            catch (Exception)
            {

                pbFoto.Load("https://cdn.icon-icons.com/icons2/317/PNG/512/sign-error-icon_34362.png");
            }
        }


    }



}
