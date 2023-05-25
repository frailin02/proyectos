using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_visitas_proyecto_final
{
   
    public partial class visitas : Form
    { 
       
    private string id;
    E_usuarioV objEntidad = new E_usuarioV();
    N_usuarioVisita objNegocio = new N_usuarioVisita();
        public visitas()
        {
            InitializeComponent();
        }

        private void visitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rEGISTRO_VISITADataSet.REGISTROV' Puede moverla o quitarla según sea necesario.
            mostrarBuscarTabla("");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objEntidad.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                objNegocio.eliminar(objEntidad);
                MessageBox.Show("se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("seleccione la fila que desea eliminar");
            }
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_usuarioVisita objNegocio = new N_usuarioVisita();
            dataGridView1.DataSource = objNegocio.buscarVisita(buscar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(textBox1.Text);
        }
    }
}
