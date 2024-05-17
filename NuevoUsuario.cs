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
    public partial class NuevoUsuario : Form
    {
        private ConexionUsuariosDataContext conexion = new ConexionUsuariosDataContext();

        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.InsertarUsuario(tbNombre.Text,
                tbApellidos.Text,
                tbEmail.Text,
                tbDepartamento.Text,
                Convert.ToDecimal(tbSalario.Text));

            MessageBox.Show("Usuario Guardado");
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
