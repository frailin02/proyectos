using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;

namespace Registro_de_visitas_proyecto_final
{
    public partial class p_formLogin : Form
    {
        E_usuario objeuser = new E_usuario();
        N_usuariosLogin objnuser = new N_usuariosLogin();
        Inicio frm1 = new Inicio();
        p_formLogin cerr;
        

        public static string usuario_nombre;
        public static string tipodeusuario;

        void p_logueo()
        {
            DataTable dt = new DataTable();
            objeuser.usuario = txtUsuario.Text;
            objeuser.contraseña = txtContraseña.Text;
            dt= objnuser.N_usuario(objeuser);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido "+ dt.Rows[0][1].ToString(), " Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre= dt.Rows[0][1].ToString();
                tipodeusuario = dt.Rows[0][0].ToString();
                frm1.ShowDialog();
                p_formLogin login = new p_formLogin();
                login.ShowDialog();

                if(login.ShowDialog() == DialogResult.OK)   
                    Application.Run(new Inicio());

                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            else
            {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public p_formLogin()
        {
            InitializeComponent();
        }

        private void p_formLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo();
            cerr = new p_formLogin();
            cerr.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
