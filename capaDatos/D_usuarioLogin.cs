using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using capaEntidad;

namespace capaDatos
{
    public class D_usuarioLogin
    {
        SqlConnection conectar=new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable D_usuarios(E_usuario obje)
        {
            SqlCommand cmd = new SqlCommand("SP_LOGIN", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USUARIO", obje.usuario);
            cmd.Parameters.AddWithValue("@CLAVE", obje.contraseña);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);    
            return dt;

        }
    }
}
