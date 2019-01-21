using BL.Farmacia;
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
    public partial class frmOrdenDeEntrega : MetroFramework.Forms.MetroForm
    {

        
        public frmOrdenDeEntrega()
        {
            InitializeComponent();
            var frmLogin = new frmLogin();
            bool tipoAdmin = frmLogin.tipoAdmin;
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
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
                    cmbDeliveryOrder.DisplayMember = "prov_nom";
                    cmbDeliveryOrder.ValueMember = "prov_cod";
                    cmbDeliveryOrder.DataSource = ds.Tables["Proveedor"];

                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Error llenando lista de proveedores: " + ex.Message);
                }
            }
        }

        private void cmbDeliveryOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string provider = "";
            DataRowView oDataRowView = cmbDeliveryOrder.SelectedItem as DataRowView;
            if (oDataRowView != null)
            {
                provider = oDataRowView.Row["prov_nom"] as string;
            }

            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                try
                {
                    string query = "select med_cod,med_nom FROM medicina WHERE prov_cod = (Select prov_cod FROM proveedor WHERE prov_nom LIKE '" + provider + "')";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, connStr);
                    cn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Medicina");
                    cmbMedicinas.DisplayMember = "med_nom";
                    cmbMedicinas.ValueMember = "med_cod";
                    cmbMedicinas.DataSource = ds.Tables["Medicina"];   
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error llenando lista de medicinas: " + ex.Message);
                }
            }
        }

        private void btAddMedicine_Click(object sender, EventArgs e)
        {
            string medName = "";
            DataRowView oDataRowView = cmbMedicinas.SelectedItem as DataRowView;
            if (oDataRowView != null)
            {
                medName = oDataRowView.Row["med_nom"] as string;
            }
            int medQuantity = int.Parse(txtMedQuantity.Text);
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE medicina SET med_cantidad = med_cantidad + "+medQuantity+" WHERE med_nom LIKE '"+medName+"'";
                    int numRowsUpdated = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Agregado a inventario");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al agregar mas medicinas: " + ex.Message);
                }
            }
                
        }
    }
}
