using BL.Farmacia;
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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        
        SeguridadBL _seguridad;
        public static bool tipoAdmin;
        public frmLogin()
            
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contrasenia = txtPassword.Text;

            var resultado = _seguridad.Autorizar(usuario, contrasenia);

            if (resultado == true)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("El nombre o contraseña es invalido.");
            }

            tipoAdmin = _seguridad.tipoAdmin(usuario, contrasenia);

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
