using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class N_usuario
    {

        D_usuario objDato = new D_usuario();
        public List<E_usuarios> buscarUsuario(string buscar)
        {
            return objDato.buscarUsuario(buscar);
        }
        public void agregarUsuario(E_usuarios usuarios)
        {
            objDato.agregarUsuario(usuarios);
        }
        public void editar(E_usuarios usuarios)
        {
            objDato.editar(usuarios);
        }
        public void eliminar(E_usuarios usuarios)
        {
            objDato.eliminar(usuarios);
        }
    }
}
