using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes f = new Clientes();
            f.MdiParent = this;
            f.Show();
        }

        private void tiposDeCreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipo_credito f = new tipo_credito();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeCreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solicitud_creditos f = new Solicitud_creditos();
            f.MdiParent = this;
            f.Show();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
