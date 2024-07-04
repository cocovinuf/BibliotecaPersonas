using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoSimple
{
    internal class ConexionDB
    {
        //----------------------------------------------------------------------------------------------------------------------------
        public List<Persona> Listar()
        {
            List<Persona> Personas = new List<Persona>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {

                conexion.ConnectionString = "server=.\\SQLexpress; Database = ProyectoSimple_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select P.Nombre, P.Edad, P.Nacionalidad, P.UrlFoto, E.Descripcion from persona P, estilos E where P.estilo_id = E.id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();


                while(lector.Read())
                {
                    Persona aux = new Persona();
                    //aux.id = lector.GetInt32["id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Edad = (int)lector["Edad"];
                    aux.Nacionalidad = (string)lector["Nacionalidad"];
                    aux.UrlFoto = (string)lector["UrlFoto"];
                    aux.EstiloMusical = new Estilo();
                    aux.EstiloMusical.Descripcion = (String)lector["Descripcion"];

                    Personas.Add(aux);
                }

                conexion.Close();
                return Personas;
            }
            catch (Exception ex)
            {
                return null;
            }

   
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------


        
        public void Cargar(Persona PersonaNueva)
        {
            List<Persona> PersonaACargar = new List<Persona>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            string instruccion = $"INSERT INTO Persona (Nombre, edad, Nacionalidad, urlFoto) VALUES ('{PersonaNueva.Nombre}', {PersonaNueva.Edad}, '{PersonaNueva.Nacionalidad}', '{PersonaNueva.UrlFoto}')";

            try
            {

                conexion.ConnectionString = "server=.\\SQLexpress; Database = ProyectoSimple_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = instruccion;
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                

                return ; 

            }


            
            catch (Exception ex)
            {

                throw ex;
            }

            

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------


        public void Borrar(Persona PersonaABorrar)
        {
            
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            string instruccion = $"Delete from Persona where Nombre = '{PersonaABorrar.Nombre}'";

            try
            {

                conexion.ConnectionString = "server=.\\SQLexpress; Database = ProyectoSimple_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = instruccion;
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                conexion.Close();

                return;

            }

            

            catch (Exception ex)
            {

                throw ex;
            }
        }



    }

}
