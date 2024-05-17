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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirForm(new Inicio());
        }

        private void AbrirForm(object formsec)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form form = formsec as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(form);
            this.panelContainer.Tag = form;
            form.Show();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            AbrirForm(new NuevoUsuario());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inicio());
        }

        private void btnPActualiza_Click(object sender, EventArgs e)
        {
            AbrirForm(new ActualizaUsuario());
        }
    }
}
