using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace AppTurnos.web.Data
{
    public class Paciente
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string NumeroAfiliado { get; set; }

        // CRUD

        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionAppTurnos"].ConnectionString;

        public List<Paciente> ObtenerTodos()
        {
            List<Paciente> pacienteList = new List<Paciente>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "SELECT * FROM Pacientes";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Paciente Paciente = new Paciente();

                    Paciente.Id = Convert.ToInt32(dr["Id"]);
                    Paciente.Nombre = dr["Nombre"].ToString();
                    Paciente.Apellido = dr["Apellido"].ToString();
                    Paciente.TipoDocumento = dr["TipoDocumento"].ToString();
                    Paciente.NumeroDocumento = Convert.ToInt32(dr["NumeroDocumento"]);
                    Paciente.NumeroAfiliado = dr["NumeroAfiliado"].ToString();

                    pacienteList.Add(Paciente);

                }
            }

            return pacienteList;

        }

        public Paciente ObtenerUno( int id)
        {
            return null;
        }

        public void Agregar(Paciente paciente)
        {
            
        }

        public void Modificar(Paciente paciente)
        {

        }

        public void Eliminar(int id)
        {

        }
    }
}