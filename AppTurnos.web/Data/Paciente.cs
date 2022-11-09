using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "Id, Nombre, Apellido, TipoDocumento, NumeroDocumento, NumeroAfiliado from Pacientes where Id = " + Id;
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            Paciente Paciente = new Paciente();

            if (dr != null)
            {
                while (dr.Read())
                {


                    Paciente.Id = Convert.ToInt32(dr["Id"]);
                    Paciente.Nombre = dr["Nombre"].ToString();
                    Paciente.Apellido = dr["Apellido"].ToString();
                    Paciente.TipoDocumento = dr["TipoDocumento"].ToString();
                    Paciente.NumeroDocumento = Convert.ToInt32(dr["NumeroDocumento"]);
                    Paciente.NumeroAfiliado = dr["NumeroAfiliado"].ToString();
                }
            }

            return Paciente;
        }

        public void Agregar(Paciente paciente)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Agregar", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Nombre", paciente.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Apellido", paciente.Apellido));
                    cmd.Parameters.Add(new SqlParameter("@TipoDocumento", paciente.TipoDocumento));
                    cmd.Parameters.Add(new SqlParameter("@NumeroDocumento", paciente.NumeroDocumento));
                    cmd.Parameters.Add(new SqlParameter("@NumeroAfiliado", paciente.NumeroAfiliado));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Paciente paciente)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Modificar", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id", paciente.Id));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", paciente.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Apellido", paciente.Apellido));
                    cmd.Parameters.Add(new SqlParameter("@TipoDocumento", paciente.TipoDocumento));
                    cmd.Parameters.Add(new SqlParameter("@NumeroDocumento", paciente.NumeroDocumento));
                    cmd.Parameters.Add(new SqlParameter("@NumeroAfiliado", paciente.NumeroAfiliado));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Eliminar", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id", Id));


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}