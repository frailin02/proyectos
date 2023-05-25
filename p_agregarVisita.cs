using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaEntidad;
namespace Registro_de_visitas_proyecto_final
{
    public partial class p_agregarVisita : Form
    {
        public p_agregarVisita()
        {
            InitializeComponent();
        }
        private bool busar=false;
        private string id;
        E_usuarioV objEntidad = new E_usuarioV();
        N_usuarioVisita objNegocio = new N_usuarioVisita(); 
        private void p_agregarVisita_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            if (p_formLogin.tipodeusuario == "ADMINISTRADOR")
            {

                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnBuscar.Enabled=true;
                btnGuardar.Enabled=true;    
            }
            else if (p_formLogin.tipodeusuario == "GENERAL")

            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnBuscar.Enabled = false;
                btnGuardar.Enabled = true;


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = tablaVisita.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = tablaVisita.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = tablaVisita.CurrentRow.Cells[3].Value.ToString();
            txtCarrera.Text = tablaVisita.CurrentRow.Cells[4].Value.ToString();
            cbEdificio.Text = tablaVisita.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerEntrada.Text = tablaVisita.CurrentRow.Cells[6].Value.ToString();
            dateTimePickerSalida.Text = tablaVisita.CurrentRow.Cells[7].Value.ToString();
            txtMotivo.Text = tablaVisita.CurrentRow.Cells[8].Value.ToString();
            cbAula.Text = tablaVisita.CurrentRow.Cells[9].Value.ToString();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_usuarioVisita objNegocio = new N_usuarioVisita();
            tablaVisita.DataSource= objNegocio.buscarVisita(buscar);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private ComboBox GetCbAula()
        {
            return cbAula;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (busar==false)
            {
                try
                {
                    objEntidad.nombre = txtNombre.Text.ToUpper();
                    objEntidad.apellido = txtApellido.Text.ToUpper();
                    objEntidad.carrera = txtCarrera.Text.ToUpper();
                    objEntidad.edificio = Convert.ToInt32(cbEdificio.Text);

                    objEntidad.hora_de_entrada = dateTimePickerEntrada.Value;
                    objEntidad.hora_de_salida = dateTimePickerSalida.Value;
                    objEntidad.motivo_de_visita = txtMotivo.Text.ToUpper();
                    objEntidad.aula = cbAula.TabIndex;
                    objNegocio.agregarVisita(objEntidad);
                    MessageBox.Show("se guardo el registro");
                    mostrarBuscarTabla("");
                    busar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar la visita"+ ex);
                    throw;
                }

            }
            if (busar==true)

            {
                try
                {
                    objEntidad.id = Convert.ToInt32(id);
                    objEntidad.nombre = txtNombre.Text.ToUpper();
                    objEntidad.apellido = txtApellido.Text.ToUpper();
                    objEntidad.carrera = txtCarrera.Text.ToUpper();
                    objEntidad.edificio = Convert.ToInt32(cbEdificio.Text);
          
                    objEntidad.hora_de_entrada = dateTimePickerEntrada.Value;
                    objEntidad.hora_de_salida = dateTimePickerSalida.Value;
                    objEntidad.motivo_de_visita = txtMotivo.Text.ToUpper();
                    objEntidad.aula = Convert.ToInt32(cbAula.Text);
                    objNegocio.editar(objEntidad);
                    MessageBox.Show("se edito el registro");
                    mostrarBuscarTabla("");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar la visita" + ex);
                    throw;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaVisita.SelectedRows.Count > 0)
            {
                busar = true;

                txtId.Text = tablaVisita.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text=tablaVisita.CurrentRow.Cells[1].Value.ToString();    
                txtNombre.Text = tablaVisita.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = tablaVisita.CurrentRow.Cells[3].Value.ToString();
                txtCarrera.Text = tablaVisita.CurrentRow.Cells[4].Value.ToString();
                cbEdificio.Text = tablaVisita.CurrentRow.Cells[5].Value.ToString();
               dateTimePickerEntrada.Text= tablaVisita.CurrentRow.Cells[6].Value.ToString();
                dateTimePickerSalida.Text = tablaVisita.CurrentRow.Cells[7].Value.ToString();
                txtMotivo.Text = tablaVisita.CurrentRow.Cells[8].Value.ToString();
                cbAula.Text = tablaVisita.CurrentRow.Cells[9].Value.ToString();

            }
            else
            {
                MessageBox.Show("seleccione la fila que desea edita");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaVisita.SelectedRows.Count>0)
            {
                objEntidad.id =Convert.ToInt32( tablaVisita.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminar(objEntidad);
                MessageBox.Show("se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("seleccione la fila que desea eliminar");
            }
        }
    }
}
