using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace capaDatos
{
    public class D_visita
    {
        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_usuarioV> buscarVisita(string visita)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAREGISTRO", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", visita);
            LeerFilas = cmd.ExecuteReader();

            List<E_usuarioV>Listar=new List<E_usuarioV>();
            while(LeerFilas.Read())
            {
                Listar.Add(new E_usuarioV
                {
                    id = LeerFilas.GetInt32(0),
                    codigo = LeerFilas.GetString(1),
                    nombre = LeerFilas.GetString(2),
                    apellido = LeerFilas.GetString(3),
                    carrera = LeerFilas.GetString(4),
                    edificio = LeerFilas.GetInt32(5),
                    hora_de_entrada = LeerFilas.GetDateTime(6),
                    hora_de_salida = LeerFilas.GetDateTime(7),
                    motivo_de_visita = LeerFilas.GetString(8),
                    aula = LeerFilas.GetInt32(9),


                });
                      
            }
            conectar.Close();
            LeerFilas.Close();
            return Listar;
        }
        public void agregarVisita(E_usuarioV visita)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAREGISTRO", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", visita.nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", visita.apellido);
            cmd.Parameters.AddWithValue("@CARRERA", visita.carrera);
            cmd.Parameters.AddWithValue("@EDIFICIO", visita.edificio);
            cmd.Parameters.AddWithValue("@HORADEENTRADA", visita.hora_de_entrada);
            cmd.Parameters.AddWithValue("@HORADESALIDA", visita.hora_de_salida);
            cmd.Parameters.AddWithValue("@MOTIVODEVISITA", visita.motivo_de_visita);
            cmd.Parameters.AddWithValue("@AULA", visita.aula);
            cmd.ExecuteNonQuery();
            conectar.Close();
        }
        public void editar(E_usuarioV visita)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARREGISTRO",conectar);
            cmd.CommandType=CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@ID", visita.id);
            cmd.Parameters.AddWithValue("NOMBRE", visita.nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", visita.apellido);
            cmd.Parameters.AddWithValue("@CARRERA", visita.carrera);
            cmd.Parameters.AddWithValue("@EDIFICIO", visita.edificio);
            cmd.Parameters.AddWithValue("@HORADEENTRADA", visita.hora_de_entrada);
            cmd.Parameters.AddWithValue("@HORADESALIDA", visita.hora_de_salida);
            cmd.Parameters.AddWithValue("@MOTIVODEVISITA", visita.motivo_de_visita);
            cmd.Parameters.AddWithValue("@AULA", visita.aula);
            cmd.ExecuteNonQuery();
            conectar.Close();
        }
        public void eliminar(E_usuarioV visita)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARREGISTRO", conectar);
            cmd.CommandType= CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@ID",visita.id);
            cmd.ExecuteNonQuery();
            conectar.Close();
        }
    }
}
