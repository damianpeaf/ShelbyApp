﻿
namespace Presentacion.App
{
    partial class MovimientosAro
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
            this.DReporteAroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimientoAroListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArosMasEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArosMasSalidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.DReporteAroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoAroListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasEntradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasSalidasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DReporteAroBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.MovimientoAroListaBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ArosMasEntradasBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.ArosMasSalidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.MovimientosAros2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 136);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 314);
            this.reportViewer1.TabIndex = 5;
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
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 136);
            this.groupBox1.TabIndex = 4;
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
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged_1);
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
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
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
            this.btntListarBuscar.Click += new System.EventHandler(this.btntListarBuscar_Click_1);
            // 
            // MovimientosAro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovimientosAro";
            this.Text = "Reportes2";
            this.Load += new System.EventHandler(this.Reportes2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DReporteAroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoAroListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasEntradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArosMasSalidasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DReporteAroBindingSource;
        private System.Windows.Forms.BindingSource MovimientoAroListaBindingSource;
        private System.Windows.Forms.BindingSource ArosMasEntradasBindingSource;
        private System.Windows.Forms.BindingSource ArosMasSalidasBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox tipoMovimiento;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtBuscarSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btntListarBuscar;
    }
}