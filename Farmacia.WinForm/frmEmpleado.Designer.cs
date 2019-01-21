namespace Farmacia.WinForm
{
    partial class frmEmpleado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgridEmpleados = new System.Windows.Forms.DataGridView();
            this.btShowAll = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtEmpCod = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpPnom = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpSnom = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpPape = new MetroFramework.Controls.MetroTextBox();
            this.txtEmpSape = new MetroFramework.Controls.MetroTextBox();
            this.txtCajSalar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.chboxIsCashier = new MetroFramework.Controls.MetroCheckBox();
            this.btDeleteEmployee = new MetroFramework.Controls.MetroButton();
            this.txtElimEmpleado = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 254);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Controls.Add(this.btShowAll);
            this.tabPage1.Controls.Add(this.dgridEmpleados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(437, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroLabel7);
            this.tabPage2.Controls.Add(this.txtElimEmpleado);
            this.tabPage2.Controls.Add(this.btDeleteEmployee);
            this.tabPage2.Controls.Add(this.chboxIsCashier);
            this.tabPage2.Controls.Add(this.metroButton2);
            this.tabPage2.Controls.Add(this.metroLabel6);
            this.tabPage2.Controls.Add(this.metroLabel5);
            this.tabPage2.Controls.Add(this.metroLabel4);
            this.tabPage2.Controls.Add(this.metroLabel3);
            this.tabPage2.Controls.Add(this.metroLabel2);
            this.tabPage2.Controls.Add(this.metroLabel1);
            this.tabPage2.Controls.Add(this.txtCajSalar);
            this.tabPage2.Controls.Add(this.txtEmpSape);
            this.tabPage2.Controls.Add(this.txtEmpPape);
            this.tabPage2.Controls.Add(this.txtEmpSnom);
            this.tabPage2.Controls.Add(this.txtEmpPnom);
            this.tabPage2.Controls.Add(this.txtEmpCod);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(437, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgridEmpleados
            // 
            this.dgridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridEmpleados.Location = new System.Drawing.Point(6, 6);
            this.dgridEmpleados.Name = "dgridEmpleados";
            this.dgridEmpleados.Size = new System.Drawing.Size(425, 175);
            this.dgridEmpleados.TabIndex = 0;
            this.dgridEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridEmpleados_CellContentClick);
            this.dgridEmpleados.SelectionChanged += new System.EventHandler(this.dgridEmpleados_SelectionChanged);
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(6, 187);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(89, 35);
            this.btShowAll.TabIndex = 1;
            this.btShowAll.Text = "Mostrar Todos";
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(101, 187);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 35);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Mostrar Cajeros";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtEmpCod
            // 
            this.txtEmpCod.Location = new System.Drawing.Point(142, 15);
            this.txtEmpCod.Name = "txtEmpCod";
            this.txtEmpCod.Size = new System.Drawing.Size(133, 23);
            this.txtEmpCod.TabIndex = 0;
            // 
            // txtEmpPnom
            // 
            this.txtEmpPnom.Location = new System.Drawing.Point(142, 44);
            this.txtEmpPnom.Name = "txtEmpPnom";
            this.txtEmpPnom.Size = new System.Drawing.Size(133, 23);
            this.txtEmpPnom.TabIndex = 1;
            // 
            // txtEmpSnom
            // 
            this.txtEmpSnom.Location = new System.Drawing.Point(142, 73);
            this.txtEmpSnom.Name = "txtEmpSnom";
            this.txtEmpSnom.Size = new System.Drawing.Size(133, 23);
            this.txtEmpSnom.TabIndex = 2;
            // 
            // txtEmpPape
            // 
            this.txtEmpPape.Location = new System.Drawing.Point(142, 102);
            this.txtEmpPape.Name = "txtEmpPape";
            this.txtEmpPape.Size = new System.Drawing.Size(133, 23);
            this.txtEmpPape.TabIndex = 3;
            // 
            // txtEmpSape
            // 
            this.txtEmpSape.Location = new System.Drawing.Point(142, 131);
            this.txtEmpSape.Name = "txtEmpSape";
            this.txtEmpSape.Size = new System.Drawing.Size(133, 23);
            this.txtEmpSape.TabIndex = 4;
            // 
            // txtCajSalar
            // 
            this.txtCajSalar.Enabled = false;
            this.txtCajSalar.Location = new System.Drawing.Point(142, 181);
            this.txtCajSalar.Name = "txtCajSalar";
            this.txtCajSalar.Size = new System.Drawing.Size(133, 23);
            this.txtCajSalar.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(80, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Codigo:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Primer Nombre:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Segundo Nombre:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Primer Apellido:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 131);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Segundo Apellido:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(41, 181);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Salario Cajero:";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(301, 15);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(118, 47);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Agregar Empleado";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // chboxIsCashier
            // 
            this.chboxIsCashier.AutoSize = true;
            this.chboxIsCashier.Location = new System.Drawing.Point(142, 160);
            this.chboxIsCashier.Name = "chboxIsCashier";
            this.chboxIsCashier.Size = new System.Drawing.Size(76, 15);
            this.chboxIsCashier.TabIndex = 14;
            this.chboxIsCashier.Text = "Es Cajero?";
            this.chboxIsCashier.UseVisualStyleBackColor = true;
            this.chboxIsCashier.CheckedChanged += new System.EventHandler(this.chboxIsCashier_CheckedChanged);
            // 
            // btDeleteEmployee
            // 
            this.btDeleteEmployee.Enabled = false;
            this.btDeleteEmployee.Location = new System.Drawing.Point(293, 160);
            this.btDeleteEmployee.Name = "btDeleteEmployee";
            this.btDeleteEmployee.Size = new System.Drawing.Size(126, 47);
            this.btDeleteEmployee.TabIndex = 15;
            this.btDeleteEmployee.Text = "Eliminar Empleado";
            this.btDeleteEmployee.Click += new System.EventHandler(this.btDeleteEmployee_Click);
            // 
            // txtElimEmpleado
            // 
            this.txtElimEmpleado.Enabled = false;
            this.txtElimEmpleado.Location = new System.Drawing.Point(355, 131);
            this.txtElimEmpleado.Name = "txtElimEmpleado";
            this.txtElimEmpleado.Size = new System.Drawing.Size(64, 20);
            this.txtElimEmpleado.TabIndex = 16;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(293, 131);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Codigo:";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEmpleado";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btShowAll;
        private System.Windows.Forms.DataGridView dgridEmpleados;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCajSalar;
        private MetroFramework.Controls.MetroTextBox txtEmpSape;
        private MetroFramework.Controls.MetroTextBox txtEmpPape;
        private MetroFramework.Controls.MetroTextBox txtEmpSnom;
        private MetroFramework.Controls.MetroTextBox txtEmpPnom;
        private MetroFramework.Controls.MetroTextBox txtEmpCod;
        private MetroFramework.Controls.MetroCheckBox chboxIsCashier;
        private MetroFramework.Controls.MetroButton btDeleteEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txtElimEmpleado;
    }
}