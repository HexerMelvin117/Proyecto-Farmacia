namespace Farmacia.WinForm
{
    partial class frmOrdenDeEntrega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDeliveryOrder = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbMedicinas = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtMedQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btAddMedicine = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbDeliveryOrder
            // 
            this.cmbDeliveryOrder.FormattingEnabled = true;
            this.cmbDeliveryOrder.ItemHeight = 23;
            this.cmbDeliveryOrder.Location = new System.Drawing.Point(104, 99);
            this.cmbDeliveryOrder.Name = "cmbDeliveryOrder";
            this.cmbDeliveryOrder.Size = new System.Drawing.Size(156, 29);
            this.cmbDeliveryOrder.TabIndex = 0;
            this.cmbDeliveryOrder.SelectedIndexChanged += new System.EventHandler(this.cmbDeliveryOrder_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Proveedor:";
            // 
            // cmbMedicinas
            // 
            this.cmbMedicinas.FormattingEnabled = true;
            this.cmbMedicinas.ItemHeight = 23;
            this.cmbMedicinas.Location = new System.Drawing.Point(104, 178);
            this.cmbMedicinas.Name = "cmbMedicinas";
            this.cmbMedicinas.Size = new System.Drawing.Size(156, 29);
            this.cmbMedicinas.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 178);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Medicina:";
            // 
            // btSearch
            // 
            this.btSearch.AutoSize = true;
            this.btSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSearch.Depth = 0;
            this.btSearch.Location = new System.Drawing.Point(195, 137);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSearch.Name = "btSearch";
            this.btSearch.Primary = false;
            this.btSearch.Size = new System.Drawing.Size(65, 36);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Buscar";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtMedQuantity
            // 
            this.txtMedQuantity.Location = new System.Drawing.Point(185, 225);
            this.txtMedQuantity.Name = "txtMedQuantity";
            this.txtMedQuantity.Size = new System.Drawing.Size(75, 23);
            this.txtMedQuantity.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(104, 225);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Cantidad:";
            // 
            // btAddMedicine
            // 
            this.btAddMedicine.Location = new System.Drawing.Point(185, 260);
            this.btAddMedicine.Name = "btAddMedicine";
            this.btAddMedicine.Size = new System.Drawing.Size(75, 23);
            this.btAddMedicine.TabIndex = 7;
            this.btAddMedicine.Text = "Agregar";
            this.btAddMedicine.Click += new System.EventHandler(this.btAddMedicine_Click);
            // 
            // frmOrdenDeEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 306);
            this.Controls.Add(this.btAddMedicine);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMedQuantity);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbMedicinas);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbDeliveryOrder);
            this.Name = "frmOrdenDeEntrega";
            this.Text = "Orden De Entrega";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbDeliveryOrder;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbMedicinas;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btSearch;
        private MetroFramework.Controls.MetroTextBox txtMedQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btAddMedicine;
    }
}