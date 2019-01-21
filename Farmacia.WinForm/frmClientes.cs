using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Farmacia.WinForm
{
    public partial class frmClientes : MetroFramework.Forms.MetroForm
    {
        public frmClientes()
        {
            InitializeComponent();

        }
        MySqlConnection con;

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.dGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string str = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            try
            {
                con = new MySqlConnection(str);
                con.Open();
                MessageBox.Show("Bonjour!");
            }
            catch (Exception x)
            {
                MessageBox.Show("Error" + x.Message);
            }

            bool tipoAdmin = frmLogin.tipoAdmin;
            if (tipoAdmin == true)
            {
                btDelete.Enabled = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string clie_cod = txtClieCod.Text;
            string clie_pnom = txtCliePnom.Text;
            string clie_snom = txtClieSnom.Text;
            string clie_pape = txtCliePape.Text;
            string clie_sape = txtClieSape.Text;

            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "INSERT INTO cliente VALUES ('" + clie_cod + "','" + clie_pnom + "','" + clie_snom + "','" + clie_pape + "','" + clie_sape + "')";
                comm.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado exitosamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error agregando linea a Mysql: " + ex.Message);
            }
        }

        private void dGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dGridClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dGridClientes.SelectedRows)
                {
                    txtClieCod.Text = row.Cells[0].Value.ToString();
                    txtCliePnom.Text = row.Cells[1].Value.ToString();
                    txtClieSnom.Text = row.Cells[2].Value.ToString();
                    txtCliePape.Text = row.Cells[3].Value.ToString();
                    txtClieSape.Text = row.Cells[4].Value.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione un linea debajo de los encabezados");
            }
        }

        private void btFillData_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand("select * from cliente", cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dGridClientes.DataSource = dt;
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string CodeDelete = txtClieDelete.Text;
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "Delete FROM cliente WHERE clie_cod = " + CodeDelete;
                comm.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error eliminando linea a Mysql: " + ex.Message);
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            int clie_cod = int.Parse(txtClieCod.Text);
            string clie_pnom = txtCliePnom.Text;
            string clie_snom = txtClieSnom.Text;
            string clie_pape = txtCliePape.Text;
            string clie_sape = txtClieSape.Text;

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE cliente SET clie_cod = '" + clie_cod + "',clie_pnom = '" + clie_pnom + "',clie_snom = '" + clie_snom + "',clie_pape = '" + clie_pape + "',clie_sape = '" + clie_sape + "' WHERE clie_cod =" + clie_cod;

                int numRowsUpdated = cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Cliente modificado exitosamente");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al modificar registros: " + ex.Message);
            }
        }
    }
}
