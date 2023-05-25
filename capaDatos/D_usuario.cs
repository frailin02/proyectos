using capaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class D_usuario
    {

        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_usuarios> buscarUsuario(string usuario)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARUSUARIOS", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", usuario);
            LeerFilas = cmd.ExecuteReader();

            List<E_usuarios> Listar = new List<E_usuarios>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_usuarios
                {
                    id = LeerFilas.GetInt32(0),
                    codigo = LeerFilas.GetString(1),
                    nombre = LeerFilas.GetString(2),
                    apellido = LeerFilas.GetString(3),
                    fechaDeNacimiento = LeerFilas.GetDateTime(4),
                    TipoDeUsuario = LeerFilas.GetString(5),
                    usuario = LeerFilas.GetString(6),
                    contraseña = LeerFilas.GetString(7),
                   


                });

            }
            conectar.Close();
            LeerFilas.Close();
            return Listar;
        }
        public void agregarUsuario(E_usuarios usuarios)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARUSUARIO", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", usuarios.nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", usuarios.apellido);
            cmd.Parameters.AddWithValue("@FECHADENACIMIENTO", usuarios.fechaDeNacimiento);
            cmd.Parameters.AddWithValue("@TIPODEUSUARIO", usuarios.TipoDeUsuario);
            cmd.Parameters.AddWithValue("@USUARIO", usuarios.usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuarios.contraseña);
            
            cmd.ExecuteNonQuery();
            conectar.Close();
        }
        public void editar(E_usuarios usuarios)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();
            cmd.Parameters.AddWithValue("@NOMBRE", usuarios.nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", usuarios.apellido);
            cmd.Parameters.AddWithValue("@FECHADENACIMIENTO", usuarios.fechaDeNacimiento);
            cmd.Parameters.AddWithValue("@TIPODEUSUARIO", usuarios.TipoDeUsuario);
            cmd.Parameters.AddWithValue("@USUARIO", usuarios.usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuarios.contraseña);

            cmd.ExecuteNonQuery();
            conectar.Close();
        }
        public void eliminar(E_usuarios usuarios)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@ID", usuarios.id);
            cmd.ExecuteNonQuery();
            conectar.Close();
        }
    }
}
