namespace Farmacia.WinForm
{
    partial class frmFacturas
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbClient = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbMedicine = new MetroFramework.Controls.MetroComboBox();
            this.txtPnom = new MetroFramework.Controls.MetroTextBox();
            this.txtPape = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAddToReceipt = new MetroFramework.Controls.MetroButton();
            this.dgridReceiptDetails = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.txtISV = new MetroFramework.Controls.MetroTextBox();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCalculateTotals = new System.Windows.Forms.Button();
            this.txtReceiptId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridReceiptDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cliente Id:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.ItemHeight = 23;
            this.cmbClient.Location = new System.Drawing.Point(79, 16);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(105, 29);
            this.cmbClient.TabIndex = 1;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Medicina:";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.ItemHeight = 23;
            this.cmbMedicine.Location = new System.Drawing.Point(77, 25);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(127, 29);
            this.cmbMedicine.TabIndex = 3;
            this.cmbMedicine.SelectedIndexChanged += new System.EventHandler(this.cmbMedicine_SelectedIndexChanged);
            // 
            // txtPnom
            // 
            this.txtPnom.Enabled = false;
            this.txtPnom.Location = new System.Drawing.Point(277, 16);
            this.txtPnom.Name = "txtPnom";
            this.txtPnom.Size = new System.Drawing.Size(94, 23);
            this.txtPnom.TabIndex = 4;
            // 
            // txtPape
            // 
            this.txtPape.Enabled = false;
            this.txtPape.Location = new System.Drawing.Point(481, 16);
            this.txtPape.Name = "txtPape";
            this.txtPape.Size = new System.Drawing.Size(94, 23);
            this.txtPape.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txtPape);
            this.groupBox1.Controls.Add(this.txtPnom);
            this.groupBox1.Controls.Add(this.cmbClient);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(29, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 58);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(265, 25);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 23);
            this.txtPrice.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(210, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Precio:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(346, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Cantidad:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(417, 25);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(75, 23);
            this.txtQuantity.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAddToReceipt);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.cmbMedicine);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(29, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // btAddToReceipt
            // 
            this.btAddToReceipt.Location = new System.Drawing.Point(498, 19);
            this.btAddToReceipt.Name = "btAddToReceipt";
            this.btAddToReceipt.Size = new System.Drawing.Size(99, 40);
            this.btAddToReceipt.TabIndex = 11;
            this.btAddToReceipt.Text = "Agregar a Factura";
            this.btAddToReceipt.Click += new System.EventHandler(this.btAddToReceipt_Click);
            // 
            // dgridReceiptDetails
            // 
            this.dgridReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridReceiptDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgridReceiptDetails.Location = new System.Drawing.Point(31, 233);
            this.dgridReceiptDetails.Name = "dgridReceiptDetails";
            this.dgridReceiptDetails.Size = new System.Drawing.Size(600, 200);
            this.dgridReceiptDetails.TabIndex = 12;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(31, 452);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(98, 63);
            this.btSave.TabIndex = 13;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(484, 452);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Sub Total:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(519, 482);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(30, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "ISV:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(510, 516);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(555, 452);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(75, 23);
            this.txtSubtotal.TabIndex = 12;
            // 
            // txtISV
            // 
            this.txtISV.Location = new System.Drawing.Point(555, 482);
            this.txtISV.Name = "txtISV";
            this.txtISV.Size = new System.Drawing.Size(75, 23);
            this.txtISV.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(555, 516);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(75, 23);
            this.txtTotal.TabIndex = 18;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(405, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Apellido:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(210, 16);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(62, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Nombre:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id_Medicina";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre_de_Medicina";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio_Unitario";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio_Total";
            this.Column5.Name = "Column5";
            // 
            // btCalculateTotals
            // 
            this.btCalculateTotals.Location = new System.Drawing.Point(135, 452);
            this.btCalculateTotals.Name = "btCalculateTotals";
            this.btCalculateTotals.Size = new System.Drawing.Size(98, 63);
            this.btCalculateTotals.TabIndex = 19;
            this.btCalculateTotals.Text = "Calcular Total";
            this.btCalculateTotals.UseVisualStyleBackColor = true;
            this.btCalculateTotals.Click += new System.EventHandler(this.btCalculateTotals_Click);
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.Location = new System.Drawing.Point(510, 24);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.Size = new System.Drawing.Size(94, 23);
            this.txtReceiptId.TabIndex = 20;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(435, 24);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(69, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "Id Factura:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(375, 452);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 23);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "Limpiar Factura";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 555);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtReceiptId);
            this.Controls.Add(this.btCalculateTotals);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtISV);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dgridReceiptDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFacturas";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridReceiptDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbClient;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbMedicine;
        private MetroFramework.Controls.MetroTextBox txtPnom;
        private MetroFramework.Controls.MetroTextBox txtPape;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btAddToReceipt;
        private System.Windows.Forms.DataGridView dgridReceiptDetails;
        private System.Windows.Forms.Button btSave;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtSubtotal;
        private MetroFramework.Controls.MetroTextBox txtISV;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btCalculateTotals;
        private MetroFramework.Controls.MetroTextBox txtReceiptId;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}