
namespace Presentacion.App
{
    partial class MovimientosLlanta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tipoMovimiento2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.DReporteLlantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimientoLlantaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArosMasEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArosMasSalidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoMovimiento2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteLlantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoLlantaListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasEntradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasSalidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoMovimiento2
            // 
            this.tipoMovimiento2.Controls.Add(this.tabPage2);
            this.tipoMovimiento2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoMovimiento2.Location = new System.Drawing.Point(0, 0);
            this.tipoMovimiento2.Name = "tipoMovimiento2";
            this.tipoMovimiento2.SelectedIndex = 0;
            this.tipoMovimiento2.Size = new System.Drawing.Size(800, 450);
            this.tipoMovimiento2.TabIndex = 1;
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
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DReporteLlantaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.MovimientoLlantaListaBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ArosMasEntradasBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.ArosMasSalidasBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 139);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(786, 282);
            this.reportViewer2.TabIndex = 4;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
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
            // DReporteLlantaBindingSource
            // 
            this.DReporteLlantaBindingSource.DataSource = typeof(Dominio.DReporteLlanta);
            // 
            // MovimientoLlantaListaBindingSource
            // 
            this.MovimientoLlantaListaBindingSource.DataSource = typeof(Dominio.MovimientoLlantaLista);
            // 
            // ArosMasEntradasBindingSource
            // 
            this.ArosMasEntradasBindingSource.DataSource = typeof(Dominio.ArosMasEntradas);
            // 
            // ArosMasSalidasBindingSource
            // 
            this.ArosMasSalidasBindingSource.DataSource = typeof(Dominio.ArosMasSalidas);
            // 
            // Reportes3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tipoMovimiento2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes3";
            this.Text = "Reportes3";
            this.tipoMovimiento2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteLlantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoLlantaListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasEntradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasSalidasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tipoMovimiento2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.BindingSource DReporteLlantaBindingSource;
        private System.Windows.Forms.BindingSource MovimientoLlantaListaBindingSource;
        private System.Windows.Forms.BindingSource ArosMasEntradasBindingSource;
        private System.Windows.Forms.BindingSource ArosMasSalidasBindingSource;
    }
}