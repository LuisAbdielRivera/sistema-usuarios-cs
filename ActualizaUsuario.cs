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
    public partial class ActualizaUsuario : Form
    {
        private ConexionUsuariosDataContext conexion = new ConexionUsuariosDataContext();

        public ActualizaUsuario()
        {
            InitializeComponent();
        }

        private void ActualizaUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = conexion.LeerUsuarios();
        }

        private void Limpiar()
        {
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbEmail.Text = "";
            tbDepartamento.Text = "";
            tbSalario.Text = "";
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            tbApellidos.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            tbEmail.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            tbDepartamento.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            tbSalario.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);

            conexion.ActualizarUsuario(
                tbNombre.Text,
                tbApellidos.Text,
                tbEmail.Text,
                tbDepartamento.Text,
                Convert.ToDecimal(tbSalario.Text),
                idUsuario
                );

            MessageBox.Show("Usuario Actualizado");

            dgvUsuarios.DataSource = conexion.LeerUsuarios();
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
