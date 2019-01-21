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
    public partial class frmMedicinas : MetroFramework.Forms.MetroForm
    {
        
        public frmMedicinas()
        {
            InitializeComponent();

            loadTable();
        }

        private void loadTable()
        {
            DataTable dt = new DataTable();
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand("select * from medicina", cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dgridMeds.DataSource = dt;
                }
            }
        }

        private void frmMedicinas_Load(object sender, EventArgs e)
        {
            this.dgridMeds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bool tipoAdmin = frmLogin.tipoAdmin;
            if (tipoAdmin == true)
            {
                btDelete.Enabled = true;
            }
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                try
                {
                    string query = "select prov_cod,prov_nom FROM proveedor";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, connStr);
                    cn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Proveedor");
                    cmbProvider.DisplayMember = "prov_nom";
                    cmbProvider.ValueMember = "prov_cod";
                    cmbProvider.DataSource = ds.Tables["Proveedor"];

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error llenando lista de proveedores: " + ex.Message);
                }
            }

        }

        private void btShowMeds_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand("select * from medicina", cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    dgridMeds.DataSource = dt;
                }
            }
        }

        private void dgridMeds_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgridMeds.SelectedRows)
                {
                    txtElimMed.Text = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un linea debajo de los encabezados");
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string codeDelete = txtElimMed.Text;
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                try
                {
                    MySqlCommand comm = cn.CreateCommand();
                    comm.CommandText = "Delete FROM medicina WHERE med_cod = " + codeDelete;
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Medicina eliminada del inventario");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error eliminando linea a Mysql: " + ex.Message);
                }
            }

        }

        private void btAddMedicine_Click(object sender, EventArgs e)
        {
            string MedCod = txtMedCod.Text;
            string MedNom = txtMedNom.Text;
            string MedPrice = txtMedPrice.Text;
            string MedQuantity = txtMedQuantity.Text;

            string provider = "";
            DataRowView oDataRowView = cmbProvider.SelectedItem as DataRowView;
            if (oDataRowView != null)
            {
                provider = oDataRowView.Row["prov_nom"] as string;
            }
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                try
                {
                    MySqlCommand comm = cn.CreateCommand();
                    comm.CommandText = "INSERT INTO medicina VALUES (" + MedCod + ",'" + MedNom + "'," + MedPrice + "," + MedQuantity + ",(Select prov_cod FROM proveedor WHERE prov_nom LIKE '"+ provider +"'))";
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Medicina agregada exitosamente.");
                    txtMedCod.Text = "";
                    txtMedNom.Text = "";
                    txtMedPrice.Text = "";
                    txtMedQuantity.Text = "";

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error agregando Medicina: " + ex.Message);
                }
            }

        }

        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgridMeds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
