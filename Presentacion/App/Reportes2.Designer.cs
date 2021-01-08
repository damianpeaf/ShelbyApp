
namespace Presentacion.App
{
    partial class Reportes2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tipoMovimiento2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tipoMovimiento = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.btntListarBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaHasta2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaDesde2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarSucursal2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DReporteAroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimientoAroListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArosMasEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArosMasSalidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioAroListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoMovimiento2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteAroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoAroListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasEntradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasSalidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioAroListaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoMovimiento2
            // 
            this.tipoMovimiento2.Controls.Add(this.tabPage1);
            this.tipoMovimiento2.Controls.Add(this.tabPage2);
            this.tipoMovimiento2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoMovimiento2.Location = new System.Drawing.Point(0, 0);
            this.tipoMovimiento2.Name = "tipoMovimiento2";
            this.tipoMovimiento2.SelectedIndex = 0;
            this.tipoMovimiento2.Size = new System.Drawing.Size(800, 450);
            this.tipoMovimiento2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventario Aros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.DReporteAroBindingSource;
            reportDataSource6.Name = "DataSet2";
            reportDataSource6.Value = this.MovimientoAroListaBindingSource;
            reportDataSource7.Name = "DataSet3";
            reportDataSource7.Value = this.ArosMasEntradasBindingSource;
            reportDataSource8.Name = "DataSet4";
            reportDataSource8.Value = this.ArosMasSalidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.MovimientosAros2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 282);
            this.reportViewer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.tipoMovimiento);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFechaHasta);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFechaDesde);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBuscarSucursal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtBuscarCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtBuscarId);
            this.groupBox1.Controls.Add(this.btntListarBuscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros del reporte";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(418, 89);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(127, 16);
            this.label26.TabIndex = 70;
            this.label26.Text = "Tipo de movimiento";
            // 
            // tipoMovimiento
            // 
            this.tipoMovimiento.Enabled = false;
            this.tipoMovimiento.FormattingEnabled = true;
            this.tipoMovimiento.Items.AddRange(new object[] {
            "Salida",
            "Ingreso"});
            this.tipoMovimiento.Location = new System.Drawing.Point(421, 108);
            this.tipoMovimiento.Name = "tipoMovimiento";
            this.tipoMovimiento.Size = new System.Drawing.Size(121, 21);
            this.tipoMovimiento.TabIndex = 69;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(564, 112);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(58, 17);
            this.checkBox4.TabIndex = 68;
            this.checkBox4.Text = "Ambos";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(301, 108);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(108, 17);
            this.checkBox3.TabIndex = 60;
            this.checkBox3.Text = "Rango de fechas";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(160, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Hasta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(160, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Hasta";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.CustomFormat = "dd-MM-yyyy";
            this.txtFechaHasta.Enabled = false;
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaHasta.Location = new System.Drawing.Point(160, 108);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(125, 20);
            this.txtFechaHasta.TabIndex = 56;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(163, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker2.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Desde";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.CustomFormat = "dd-MM-yyyy";
            this.txtFechaDesde.Enabled = false;
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaDesde.Location = new System.Drawing.Point(17, 108);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(122, 20);
            this.txtFechaDesde.TabIndex = 54;
            this.txtFechaDesde.ValueChanged += new System.EventHandler(this.txtFechaDesde_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 17);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "Buscar en todas las Sucursales";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Sucursal";
            // 
            // txtBuscarSucursal
            // 
            this.txtBuscarSucursal.FormattingEnabled = true;
            this.txtBuscarSucursal.Location = new System.Drawing.Point(6, 34);
            this.txtBuscarSucursal.Name = "txtBuscarSucursal";
            this.txtBuscarSucursal.Size = new System.Drawing.Size(125, 21);
            this.txtBuscarSucursal.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(317, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(320, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(125, 20);
            this.txtCodigo.TabIndex = 46;
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(320, 35);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(125, 20);
            this.txtBuscarCodigo.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(177, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(177, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 20);
            this.txtId.TabIndex = 43;
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(177, 35);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(125, 20);
            this.txtBuscarId.TabIndex = 44;
            // 
            // btntListarBuscar
            // 
            this.btntListarBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btntListarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntListarBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntListarBuscar.ForeColor = System.Drawing.Color.White;
            this.btntListarBuscar.Location = new System.Drawing.Point(596, 60);
            this.btntListarBuscar.Name = "btntListarBuscar";
            this.btntListarBuscar.Size = new System.Drawing.Size(184, 26);
            this.btntListarBuscar.TabIndex = 42;
            this.btntListarBuscar.Text = "Generar reporte";
            this.btntListarBuscar.UseVisualStyleBackColor = false;
            this.btntListarBuscar.Click += new System.EventHandler(this.btntListarBuscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventario Llantas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFechaHasta2);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtFechaDesde2);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBuscarSucursal2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCodigo2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtId2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros del reporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(418, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "Tipo de movimiento";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Salida",
            "Ingreso"});
            this.comboBox1.Location = new System.Drawing.Point(421, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 89;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(564, 108);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 17);
            this.checkBox2.TabIndex = 88;
            this.checkBox2.Text = "Ambos";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(301, 104);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(108, 17);
            this.checkBox5.TabIndex = 87;
            this.checkBox5.Text = "Rango de fechas";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(160, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(160, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "Hasta";
            // 
            // txtFechaHasta2
            // 
            this.txtFechaHasta2.CustomFormat = "dd-MM-yyyy";
            this.txtFechaHasta2.Enabled = false;
            this.txtFechaHasta2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaHasta2.Location = new System.Drawing.Point(160, 104);
            this.txtFechaHasta2.Name = "txtFechaHasta2";
            this.txtFechaHasta2.Size = new System.Drawing.Size(125, 20);
            this.txtFechaHasta2.TabIndex = 83;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(163, 104);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker3.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 82;
            this.label10.Text = "Desde";
            // 
            // txtFechaDesde2
            // 
            this.txtFechaDesde2.CustomFormat = "dd-MM-yyyy";
            this.txtFechaDesde2.Enabled = false;
            this.txtFechaDesde2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaDesde2.Location = new System.Drawing.Point(17, 104);
            this.txtFechaDesde2.Name = "txtFechaDesde2";
            this.txtFechaDesde2.Size = new System.Drawing.Size(122, 20);
            this.txtFechaDesde2.TabIndex = 81;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 56);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(174, 17);
            this.checkBox6.TabIndex = 80;
            this.checkBox6.Text = "Buscar en todas las Sucursales";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 79;
            this.label11.Text = "Sucursal";
            // 
            // txtBuscarSucursal2
            // 
            this.txtBuscarSucursal2.FormattingEnabled = true;
            this.txtBuscarSucursal2.Location = new System.Drawing.Point(6, 30);
            this.txtBuscarSucursal2.Name = "txtBuscarSucursal2";
            this.txtBuscarSucursal2.Size = new System.Drawing.Size(125, 21);
            this.txtBuscarSucursal2.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(317, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Codigo";
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(320, 31);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(125, 20);
            this.txtCodigo2.TabIndex = 75;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(177, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 16);
            this.label13.TabIndex = 74;
            this.label13.Text = "ID";
            // 
            // txtId2
            // 
            this.txtId2.Location = new System.Drawing.Point(177, 30);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(125, 20);
            this.txtId2.TabIndex = 72;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(596, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 26);
            this.button1.TabIndex = 71;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.MovimientoLlantas.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 139);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(786, 282);
            this.reportViewer2.TabIndex = 4;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // DReporteAroBindingSource
            // 
            this.DReporteAroBindingSource.DataSource = typeof(Dominio.DReporteAro);
            // 
            // MovimientoAroListaBindingSource
            // 
            this.MovimientoAroListaBindingSource.DataSource = typeof(Dominio.MovimientoAroLista);
            // 
            // ArosMasEntradasBindingSource
            // 
            this.ArosMasEntradasBindingSource.DataSource = typeof(Dominio.ArosMasEntradas);
            // 
            // ArosMasSalidasBindingSource
            // 
            this.ArosMasSalidasBindingSource.DataSource = typeof(Dominio.ArosMasSalidas);
            // 
            // InventarioAroListaBindingSource
            // 
            this.InventarioAroListaBindingSource.DataSource = typeof(Dominio.InventarioAroLista);
            // 
            // Reportes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tipoMovimiento2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes2";
            this.Text = "Reportes2";
            this.Load += new System.EventHandler(this.Reportes2_Load);
            this.tipoMovimiento2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteAroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoAroListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasEntradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasSalidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioAroListaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tipoMovimiento2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntListarBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtBuscarSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox tipoMovimiento;
        private System.Windows.Forms.CheckBox checkBox4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DReporteAroBindingSource;
        private System.Windows.Forms.BindingSource MovimientoAroListaBindingSource;
        private System.Windows.Forms.BindingSource ArosMasEntradasBindingSource;
        private System.Windows.Forms.BindingSource ArosMasSalidasBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtFechaHasta2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtFechaDesde2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtBuscarSucursal2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource InventarioAroListaBindingSource;
    }
}