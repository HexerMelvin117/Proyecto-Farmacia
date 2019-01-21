namespace Farmacia.WinForm
{
    partial class frmClientes
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
            this.txtClieCod = new MetroFramework.Controls.MetroTextBox();
            this.txtCliePnom = new MetroFramework.Controls.MetroTextBox();
            this.txtClieSnom = new MetroFramework.Controls.MetroTextBox();
            this.txtCliePape = new MetroFramework.Controls.MetroTextBox();
            this.txtClieSape = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dGridClientes = new System.Windows.Forms.DataGridView();
            this.btFillData = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btDelete = new MetroFramework.Controls.MetroButton();
            this.txtClieDelete = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btModify = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClieCod
            // 
            this.txtClieCod.Location = new System.Drawing.Point(131, 63);
            this.txtClieCod.Name = "txtClieCod";
            this.txtClieCod.Size = new System.Drawing.Size(149, 23);
            this.txtClieCod.TabIndex = 0;
            // 
            // txtCliePnom
            // 
            this.txtCliePnom.Location = new System.Drawing.Point(131, 92);
            this.txtCliePnom.Name = "txtCliePnom";
            this.txtCliePnom.Size = new System.Drawing.Size(149, 23);
            this.txtCliePnom.TabIndex = 1;
            // 
            // txtClieSnom
            // 
            this.txtClieSnom.Location = new System.Drawing.Point(131, 121);
            this.txtClieSnom.Name = "txtClieSnom";
            this.txtClieSnom.Size = new System.Drawing.Size(149, 23);
            this.txtClieSnom.TabIndex = 2;
            // 
            // txtCliePape
            // 
            this.txtCliePape.Location = new System.Drawing.Point(131, 150);
            this.txtCliePape.Name = "txtCliePape";
            this.txtCliePape.Size = new System.Drawing.Size(149, 23);
            this.txtCliePape.TabIndex = 3;
            // 
            // txtClieSape
            // 
            this.txtClieSape.Location = new System.Drawing.Point(131, 179);
            this.txtClieSape.Name = "txtClieSape";
            this.txtClieSape.Size = new System.Drawing.Size(149, 23);
            this.txtClieSape.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Codigo:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Primer Nombre:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Segundo Nom.:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 150);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "1er Apellido:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 179);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "2ndo Apellido:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(205, 208);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Agregar";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dGridClientes
            // 
            this.dGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridClientes.Location = new System.Drawing.Point(286, 60);
            this.dGridClientes.Name = "dGridClientes";
            this.dGridClientes.Size = new System.Drawing.Size(380, 165);
            this.dGridClientes.TabIndex = 13;
            this.dGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridClientes_CellClick);
            this.dGridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridClientes_CellContentClick);
            this.dGridClientes.SelectionChanged += new System.EventHandler(this.dGridClientes_SelectionChanged);
            // 
            // btFillData
            // 
            this.btFillData.Location = new System.Drawing.Point(286, 231);
            this.btFillData.Name = "btFillData";
            this.btFillData.Size = new System.Drawing.Size(95, 23);
            this.btFillData.TabIndex = 14;
            this.btFillData.Text = "Mostrar Datos";
            this.btFillData.Click += new System.EventHandler(this.btFillData_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(286, 38);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Clientes";
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(591, 231);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Eliminar";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtClieDelete
            // 
            this.txtClieDelete.Depth = 0;
            this.txtClieDelete.Hint = "Codigo";
            this.txtClieDelete.Location = new System.Drawing.Point(510, 231);
            this.txtClieDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClieDelete.Name = "txtClieDelete";
            this.txtClieDelete.PasswordChar = '\0';
            this.txtClieDelete.SelectedText = "";
            this.txtClieDelete.SelectionLength = 0;
            this.txtClieDelete.SelectionStart = 0;
            this.txtClieDelete.Size = new System.Drawing.Size(75, 23);
            this.txtClieDelete.TabIndex = 17;
            this.txtClieDelete.UseSystemPasswordChar = false;
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(124, 208);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 18;
            this.btModify.Text = "Modificar";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 265);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.txtClieDelete);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btFillData);
            this.Controls.Add(this.dGridClientes);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtClieSape);
            this.Controls.Add(this.txtCliePape);
            this.Controls.Add(this.txtClieSnom);
            this.Controls.Add(this.txtCliePnom);
            this.Controls.Add(this.txtClieCod);
            this.Name = "frmClientes";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtClieCod;
        private MetroFramework.Controls.MetroTextBox txtCliePnom;
        private MetroFramework.Controls.MetroTextBox txtClieSnom;
        private MetroFramework.Controls.MetroTextBox txtCliePape;
        private MetroFramework.Controls.MetroTextBox txtClieSape;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dGridClientes;
        private MetroFramework.Controls.MetroButton btFillData;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btDelete;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClieDelete;
        private MetroFramework.Controls.MetroButton btModify;
    }
}