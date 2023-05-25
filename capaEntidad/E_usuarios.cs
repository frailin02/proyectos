using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class E_usuarios
    {
        public int id { get;set;}   
        public string codigo { get;set;}
        public string nombre { get;set;}   
        public string apellido { get;set;}  
        public DateTime fechaDeNacimiento { get;set;}   
        public string TipoDeUsuario { get;set;} 
        public string usuario { get;set;}   
        public string contraseña { get;set;}

    }
}
