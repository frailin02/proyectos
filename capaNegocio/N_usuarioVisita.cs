using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;
namespace capaNegocio
{
    public class N_usuarioVisita
    {
        D_visita objDato = new D_visita();
        public List<E_usuarioV> buscarVisita(string buscar)
        {
            return objDato.buscarVisita(buscar);
        }
        public void agregarVisita(E_usuarioV visita)
        {
            objDato.agregarVisita(visita);
        }
        public void editar(E_usuarioV visita)
        {
            objDato.editar(visita);
        }
        public void eliminar(E_usuarioV visita)
        {
            objDato.eliminar(visita);
        }
    }
}
