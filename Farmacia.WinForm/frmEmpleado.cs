using MySql.Data.MySqlClient;
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
    public partial class frmEmpleado : MetroFramework.Forms.MetroForm
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            bool tipoAdmin = frmLogin.tipoAdmin;
            if (tipoAdmin == true)
            {
                txtElimEmpleado.Enabled = true;
                btDeleteEmployee.Enabled = true;
            }
            this.dgridEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabPage1.Text = "Empleados";
            tabPage2.Text = "Gestionar Empleados";
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand("select * from empleado", cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dgridEmpleados.DataSource = dt;
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string empCod = txtEmpCod.Text;
            string empPnom = txtEmpPnom.Text;
            string empSnom = txtEmpSnom.Text;
            string empPape = txtEmpPape.Text;
            string empSape = txtEmpSape.Text;
            int cajSalary = 0;
            int isCashier = 0;


            if (chboxIsCashier.Checked == true)
            {
                isCashier = isCashier + 1;
                txtCajSalar.Enabled = true;
                if (txtCajSalar.Text == "")
                {
                    MessageBox.Show("Porfavor Introduzca salario de cajero");
                }
                else
                {
                    cajSalary = int.Parse(txtCajSalar.Text);
                }
            }

            

            DataTable dt = new DataTable();
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                try
                {
                    MySqlCommand comm = cn.CreateCommand();
                    comm.CommandText = "INSERT INTO empleado VALUES ('" + empCod + "','" + empPnom + "','" + empSnom + "','" + empPape + "','" + empSape + "','"+ isCashier +"','"+ cajSalary +"')";
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Empleado agregado exitosamente.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error agregando linea a Mysql: " + ex.Message);
                }
            }

        }

        

        private void chboxIsCashier_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxIsCashier.Checked == true)
            {
                txtCajSalar.Enabled = true;
            }
            else
            {
                txtCajSalar.Enabled = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand("select * from empleado WHERE caj_puesto = 1", cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dgridEmpleados.DataSource = dt;
                }
            }
        }

        private void dgridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgridEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgridEmpleados.SelectedRows)
                {
                    txtElimEmpleado.Text = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un linea debajo de los encabezados");
            }

        }

        private void btDeleteEmployee_Click(object sender, EventArgs e)
        {
            string codeDelete = txtElimEmpleado.Text;
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                try
                {
                    MySqlCommand comm = cn.CreateCommand();
                    comm.CommandText = "Delete FROM empleado WHERE emp_cod = " + codeDelete;
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Empleado eliminado exitosamente");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error eliminando linea a Mysql: " + ex.Message);
                }
            }
        }
    }
}
