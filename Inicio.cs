using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeUsuarios
{
    public partial class Inicio : Form
    {

        private ConexionUsuariosDataContext conexion = new ConexionUsuariosDataContext();

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = conexion.LeerUsuarios();
        }

        private void Limpiar()
        {
            tbNoUsuario.Text = "";
            tbNombre.Text = "";
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNoUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            tbNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);

            conexion.EliminarUsuario(idUsuario);

            MessageBox.Show("Usuario Eliminado");
            dgvUsuarios.DataSource = conexion.LeerUsuarios();

            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
