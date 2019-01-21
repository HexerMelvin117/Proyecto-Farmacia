namespace Farmacia.WinForm
{
    partial class frmMedicinas
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
            this.btDelete = new System.Windows.Forms.Button();
            this.dgridMeds = new System.Windows.Forms.DataGridView();
            this.btShowMeds = new MetroFramework.Controls.MetroButton();
            this.txtElimMed = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMedCod = new MetroFramework.Controls.MetroTextBox();
            this.txtMedNom = new MetroFramework.Controls.MetroTextBox();
            this.txtMedPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtMedQuantity = new MetroFramework.Controls.MetroTextBox();
            this.cmbProvider = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btAddMedicine = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgridMeds)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(430, 216);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(70, 26);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dgridMeds
            // 
            this.dgridMeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridMeds.Location = new System.Drawing.Point(23, 63);
            this.dgridMeds.Name = "dgridMeds";
            this.dgridMeds.Size = new System.Drawing.Size(478, 150);
            this.dgridMeds.TabIndex = 4;
            this.dgridMeds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridMeds_CellContentClick);
            this.dgridMeds.SelectionChanged += new System.EventHandler(this.dgridMeds_SelectionChanged);
            // 
            // btShowMeds
            // 
            this.btShowMeds.Location = new System.Drawing.Point(23, 219);
            this.btShowMeds.Name = "btShowMeds";
            this.btShowMeds.Size = new System.Drawing.Size(118, 32);
            this.btShowMeds.TabIndex = 5;
            this.btShowMeds.Text = "Mostrar Inventario";
            this.btShowMeds.Click += new System.EventHandler(this.btShowMeds_Click);
            // 
            // txtElimMed
            // 
            this.txtElimMed.Depth = 0;
            this.txtElimMed.Hint = "Codigo";
            this.txtElimMed.Location = new System.Drawing.Point(349, 219);
            this.txtElimMed.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtElimMed.Name = "txtElimMed";
            this.txtElimMed.PasswordChar = '\0';
            this.txtElimMed.SelectedText = "";
            this.txtElimMed.SelectionLength = 0;
            this.txtElimMed.SelectionStart = 0;
            this.txtElimMed.Size = new System.Drawing.Size(75, 23);
            this.txtElimMed.TabIndex = 6;
            this.txtElimMed.UseSystemPasswordChar = false;
            // 
            // txtMedCod
            // 
            this.txtMedCod.Location = new System.Drawing.Point(147, 305);
            this.txtMedCod.Name = "txtMedCod";
            this.txtMedCod.Size = new System.Drawing.Size(163, 23);
            this.txtMedCod.TabIndex = 7;
            // 
            // txtMedNom
            // 
            this.txtMedNom.Location = new System.Drawing.Point(147, 334);
            this.txtMedNom.Name = "txtMedNom";
            this.txtMedNom.Size = new System.Drawing.Size(163, 23);
            this.txtMedNom.TabIndex = 8;
            // 
            // txtMedPrice
            // 
            this.txtMedPrice.Location = new System.Drawing.Point(147, 363);
            this.txtMedPrice.Name = "txtMedPrice";
            this.txtMedPrice.Size = new System.Drawing.Size(163, 23);
            this.txtMedPrice.TabIndex = 9;
            // 
            // txtMedQuantity
            // 
            this.txtMedQuantity.Location = new System.Drawing.Point(147, 392);
            this.txtMedQuantity.Name = "txtMedQuantity";
            this.txtMedQuantity.Size = new System.Drawing.Size(163, 23);
            this.txtMedQuantity.TabIndex = 10;
            // 
            // cmbProvider
            // 
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.ItemHeight = 23;
            this.cmbProvider.Location = new System.Drawing.Point(148, 268);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(163, 29);
            this.cmbProvider.TabIndex = 11;
            this.cmbProvider.SelectedIndexChanged += new System.EventHandler(this.cmbProvider_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 305);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Codigo Medicina:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 334);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(138, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Nombre de Medicina:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 363);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Precio por Medicina:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(75, 392);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Cantidad:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(66, 268);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Proveedor:";
            // 
            // btAddMedicine
            // 
            this.btAddMedicine.Location = new System.Drawing.Point(349, 367);
            this.btAddMedicine.Name = "btAddMedicine";
            this.btAddMedicine.Size = new System.Drawing.Size(118, 48);
            this.btAddMedicine.TabIndex = 17;
            this.btAddMedicine.Text = "Agregar Medicina";
            this.btAddMedicine.Click += new System.EventHandler(this.btAddMedicine_Click);
            // 
            // frmMedicinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 430);
            this.Controls.Add(this.btAddMedicine);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.txtMedQuantity);
            this.Controls.Add(this.txtMedPrice);
            this.Controls.Add(this.txtMedNom);
            this.Controls.Add(this.txtMedCod);
            this.Controls.Add(this.txtElimMed);
            this.Controls.Add(this.btShowMeds);
            this.Controls.Add(this.dgridMeds);
            this.Controls.Add(this.btDelete);
            this.Name = "frmMedicinas";
            this.Text = "Medicinas";
            this.Load += new System.EventHandler(this.frmMedicinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridMeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dgridMeds;
        private MetroFramework.Controls.MetroButton btShowMeds;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtElimMed;
        private MetroFramework.Controls.MetroTextBox txtMedCod;
        private MetroFramework.Controls.MetroTextBox txtMedNom;
        private MetroFramework.Controls.MetroTextBox txtMedPrice;
        private MetroFramework.Controls.MetroTextBox txtMedQuantity;
        private MetroFramework.Controls.MetroComboBox cmbProvider;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btAddMedicine;
    }
}