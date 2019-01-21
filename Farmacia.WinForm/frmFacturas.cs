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
    public partial class frmFacturas : MetroFramework.Forms.MetroForm
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                
                try
                {
                    string query = "select Clie_cod FROM cliente";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, connStr);
                    cn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Cliente");
                    cmbClient.DisplayMember = "clie_cod";
                    cmbClient.ValueMember = "Clie_cod";
                    cmbClient.DataSource = ds.Tables["Cliente"];

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error llenando lista de proveedores: " + ex.Message);
                }
            }
            
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {

                try
                {
                    string query = "select med_cod,med_nom FROM medicina";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, connStr);
                    cn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Medicina");
                    cmbMedicine.DisplayMember = "med_nom";
                    cmbMedicine.ValueMember = "med_cod";
                    cmbMedicine.DataSource = ds.Tables["Medicina"];
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error llenando lista de Medicina: " + ex.Message);
                }
            }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod;
            int clie_cod;
            DataRowView oDataRowView = cmbClient.SelectedItem as DataRowView;

            if (oDataRowView != null)
            {
                cod = oDataRowView.Row["clie_cod"].ToString();
                clie_cod = int.Parse(cod);
                string constring = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
                string Query = "Select * FROM cliente WHERE clie_cod = " + clie_cod + "";
                MySqlConnection condatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader;
                try
                {
                    condatabase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    while(myReader.Read())
                    {
                        string clie_nom = myReader.GetString("clie_pnom");
                        string clie_pape = myReader.GetString("clie_pape");
                        txtPnom.Text = clie_nom;
                        txtPape.Text = clie_pape;
                    }

                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Error al cargar informacion del cliente: " + ex.Message);
                }

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void cmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod;
            string med_nom;
            DataRowView oDataRowView = cmbMedicine.SelectedItem as DataRowView;

            if (oDataRowView != null)
            {
                med_nom = oDataRowView.Row["med_nom"].ToString();
                string constring = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
                string Query = "Select * FROM medicina WHERE med_nom LIKE '"+ med_nom +"'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader;
                try
                {
                    condatabase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    while (myReader.Read())
                    {
                        string med_precio = myReader.GetString("med_precio");
                        txtPrice.Text = med_precio;
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar informacion del cliente: " + ex.Message);
                }
            }
        }

        private void btAddToReceipt_Click(object sender, EventArgs e)
        {
            string Id_Medicina;
            string Med_precio = txtPrice.Text;
            string MedCantidad = txtQuantity.Text;
            int totalPrecio = int.Parse(MedCantidad) * int.Parse(Med_precio);

            DataRowView oDataRowView = cmbMedicine.SelectedItem as DataRowView;
            if (oDataRowView != null)
            {
                string nomMedi = oDataRowView.Row["med_nom"] as string;
                string constring = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
                string Query = "Select med_cod FROM medicina WHERE med_nom LIKE '" + nomMedi + "'";
                MySqlConnection condatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader;
                try
                {
                    condatabase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    while (myReader.Read())
                    {
                        Id_Medicina = myReader.GetString("med_cod");
                        dgridReceiptDetails.Rows.Add(Id_Medicina,nomMedi,Med_precio,MedCantidad,totalPrecio.ToString());
                    }
                }
                catch (MySqlException ex)
                {

                }

            }    
        }

        private void btCalculateTotals_Click(object sender, EventArgs e)
        {

            int sum = 0;
            for (int i = 0; i < dgridReceiptDetails.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgridReceiptDetails.Rows[i].Cells["Column5"].Value);
            }
            txtSubtotal.Text = sum.ToString();

            double taxISV = 0.14 * int.Parse(txtSubtotal.Text);
            txtISV.Text = taxISV.ToString();
            double grandTotal = taxISV + int.Parse(txtSubtotal.Text);
            txtTotal.Text = grandTotal.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string fact_Id = txtReceiptId.Text;
            string fact_subtotal = txtSubtotal.Text;
            string fact_ISV = txtISV.Text;
            string fact_total = txtTotal.Text;
            int fact_puntos;

            if (txtReceiptId.Text == "")
            {
                MessageBox.Show("Porfavor introduzca id de Factura.");
            }
            else
            {
                int clie_cod;
                DataRowView oDataRowView = cmbClient.SelectedItem as DataRowView;
                if (oDataRowView != null)
                {
                    string cod = oDataRowView.Row["clie_cod"].ToString();
                    clie_cod = int.Parse(cod);
                    if (double.Parse(fact_total) < 2000)
                    {
                        fact_puntos = 5;
                        string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
                        using (MySqlConnection cn = new MySqlConnection(connStr))
                        {
                            cn.Open();
                            MySqlCommand comm = cn.CreateCommand();
                            comm.CommandText = "INSERT INTO factura VALUES ('" + fact_Id + "','" + fact_subtotal + "','" + fact_ISV + "','" + fact_total + "','" + fact_puntos + "','" + clie_cod + "')";
                            comm.ExecuteNonQuery();
                            MessageBox.Show("factura creada exitosamente.");
                        }
                    }
                    else
                    {
                        if (double.Parse(fact_total) > 2000)
                        {
                            fact_puntos = 10;
                            string connStr = "Server=localhost;Database=pharmacymanagementdb;Uid=root;Pwd=1997soreal";
                            using (MySqlConnection cn = new MySqlConnection(connStr))
                            {
                                cn.Open();
                                MySqlCommand comm = cn.CreateCommand();
                                comm.CommandText = "INSERT INTO factura VALUES ('" + fact_Id + "','" + fact_subtotal + "','" + fact_ISV + "','" + fact_total + "','" + fact_puntos + "','" + clie_cod + "')";
                                comm.ExecuteNonQuery();
                                MessageBox.Show("factura creada exitosamente.");

                            }
                        }
                    }
                }

            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.dgridReceiptDetails.Rows.Clear();
        }
    }
}
