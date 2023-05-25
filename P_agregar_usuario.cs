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
    public partial class P_agregar_usuario : Form
    {
        private bool busar = false;
        private string id;
        E_usuarios objEntidad = new E_usuarios();
        N_usuario objNegocio = new N_usuario();
        public P_agregar_usuario()
        {
            InitializeComponent();
        }

        private void P_agregar_usuario_Load(object sender, EventArgs e)
        {
            mostrarUsuario("");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void mostrarUsuario(string buscar)
        {
            N_usuario objNegocio = new N_usuario();
            tablaUsuario.DataSource = objNegocio.buscarUsuario(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarUsuario(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (busar == false)
            {
                try
                {
                    objEntidad.nombre = txtNombre.Text.ToUpper();
                    objEntidad.apellido = txtApellido.Text.ToUpper();
                    objEntidad.fechaDeNacimiento = dateTimePicker1.Value;
                    objEntidad.TipoDeUsuario = comboBox1.Text;
                    objEntidad.usuario = txtUsuario.Text;
                    objEntidad.contraseña = txtContraseña.Text;
                    
                    objNegocio.agregarUsuario(objEntidad);
                    MessageBox.Show("se guardo el registro");
                    mostrarUsuario("");
                    busar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el usuario" + ex);
                    throw;
                }

            }
            if (busar == true)

            {
                try
                {
                    objEntidad.nombre = txtNombre.Text.ToUpper();
                    objEntidad.apellido = txtApellido.Text.ToUpper();
                    objEntidad.fechaDeNacimiento = dateTimePicker1.Value;
                    objEntidad.TipoDeUsuario = comboBox1.Text;
                    objEntidad.usuario = txtUsuario.Text;
                    objEntidad.contraseña = txtContraseña.Text;

                    
                    objNegocio.editar(objEntidad);
                    MessageBox.Show("se edito el usuario");
                    mostrarUsuario("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el usuario" + ex);
                    throw;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaUsuario.SelectedRows.Count > 0)
            {
                busar = true;

                txtId.Text = tablaUsuario.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaUsuario.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaUsuario.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = tablaUsuario.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = tablaUsuario.CurrentRow.Cells[4].Value.ToString();
                comboBox1.Text = tablaUsuario.CurrentRow.Cells[5].Value.ToString();
                txtUsuario.Text = tablaUsuario.CurrentRow.Cells[6].Value.ToString();
                txtContraseña.Text = tablaUsuario.CurrentRow.Cells[6].Value.ToString();

            }
            else
            {
                MessageBox.Show("seleccione la fila que desea edita");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaUsuario.SelectedRows.Count > 0)
            {
                objEntidad.id = Convert.ToInt32(tablaUsuario.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminar(objEntidad);
                MessageBox.Show("se elimino correctamente");
                mostrarUsuario("");
            }
            else
            {
                MessageBox.Show("seleccione la fila que desea eliminar");
            }
        }
    }
}
