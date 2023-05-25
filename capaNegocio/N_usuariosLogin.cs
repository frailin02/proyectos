using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class N_usuariosLogin
    {
        D_usuarioLogin objd = new D_usuarioLogin();
        public DataTable N_usuario(E_usuario obje)
        {
            return objd.D_usuarios(obje);
        }
    }
}
