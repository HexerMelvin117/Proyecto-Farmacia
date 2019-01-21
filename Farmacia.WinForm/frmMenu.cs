using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.WinForm
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            var frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            bool tipoAdmin = frmLogin.tipoAdmin;
            if (tipoAdmin == true)
            {
                facturacionToolStripMenuItem.Enabled = true;
            }
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProveedor = new frmOrdenDeEntrega();
            frmProveedor.ShowDialog();
        }

        private void medicinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMedicinas = new frmMedicinas();
            frmMedicinas.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.ShowDialog();

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmFacturas = new frmFacturas();
            frmFacturas.ShowDialog();
        }

        private void manejoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEmpleado = new frmEmpleado();
            frmEmpleado.ShowDialog();

        }
    }
}
