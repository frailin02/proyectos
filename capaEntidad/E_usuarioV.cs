using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class E_usuarioV
    {
        public int id { get; set; }
        public string codigo { get; set; }

        public string nombre { get; set; }  

        public string apellido { get; set; }

        public string carrera { get; set; } 

        public int edificio { get; set; }    

        public DateTime hora_de_entrada { get; set; }    

        public DateTime hora_de_salida { get; set; }    

        public string motivo_de_visita { get; set; }    

        public int aula { get; set; }    

    }
}
