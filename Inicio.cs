using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_visitas_proyecto_final
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        p_agregarVisita agregar;
        P_agregar_usuario usuario;
        visitas visitas;
        private void Inicio_Load(object sender, EventArgs e)
        {
            if (p_formLogin.tipodeusuario == "ADMINISTRADOR")
            {

                btnConsultaV.Enabled = true;
                btnVisita.Enabled = true;

            }
            else if (p_formLogin.tipodeusuario == "GENERAL")

            {
                btnVisita.Enabled = true;
                btnConsultaV.Enabled = false;


            }
            label1.Text = p_formLogin.usuario_nombre;
            label5.Text = p_formLogin.tipodeusuario;
        }

        private void btnVisita_Click(object sender, EventArgs e)
        {
            agregar= new p_agregarVisita();
            agregar.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario= new P_agregar_usuario();   
            usuario.Visible = true;
            

        }

        private void btnConsultaV_Click(object sender, EventArgs e)
        {
            visitas = new visitas();
            visitas.Visible= true;
            
        }
    }
}
