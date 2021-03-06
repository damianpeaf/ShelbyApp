﻿
namespace Presentacion.App
{
    partial class InventarioLlantas
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
            this.DReporteLlantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioLlantaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DReporteAroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioAroListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBodegas = new System.Windows.Forms.ComboBox();
            this.buscarBodega = new System.Windows.Forms.CheckBox();
            this.costoVisible = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarSucursal1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarCodigo1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarId1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteLlantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioLlantaListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteAroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioAroListaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DReporteLlantaBindingSource
            // 
            this.DReporteLlantaBindingSource.DataSource = typeof(Dominio.DReporteLlanta);
            // 
            // InventarioLlantaListaBindingSource
            // 
            this.InventarioLlantaListaBindingSource.DataSource = typeof(Dominio.InventarioLlantaLista);
            // 
            // DReporteAroBindingSource
            // 
            this.DReporteAroBindingSource.DataSource = typeof(Dominio.DReporteAro);
            // 
            // InventarioAroListaBindingSource
            // 
            this.InventarioAroListaBindingSource.DataSource = typeof(Dominio.InventarioAroLista);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DReporteLlantaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.InventarioLlantaListaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.InventarioLlanta.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 152);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(991, 395);
            this.reportViewer2.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.buscarBodega);
            this.groupBox2.Controls.Add(this.costoVisible);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBuscarSucursal1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBuscarCodigo1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBuscarId1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 152);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros del reporte";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.comboBodegas);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(330, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 97);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bodegas";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Todas las bodegas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBodegas
            // 
            this.comboBodegas.FormattingEnabled = true;
            this.comboBodegas.Location = new System.Drawing.Point(6, 44);
            this.comboBodegas.Name = "comboBodegas";
            this.comboBodegas.Size = new System.Drawing.Size(121, 21);
            this.comboBodegas.TabIndex = 38;
            // 
            // buscarBodega
            // 
            this.buscarBodega.AutoSize = true;
            this.buscarBodega.Location = new System.Drawing.Point(330, 25);
            this.buscarBodega.Name = "buscarBodega";
            this.buscarBodega.Size = new System.Drawing.Size(113, 17);
            this.buscarBodega.TabIndex = 48;
            this.buscarBodega.Text = "Buscar en bodega";
            this.buscarBodega.UseVisualStyleBackColor = true;
            this.buscarBodega.CheckedChanged += new System.EventHandler(this.buscarBodega_CheckedChanged);
            // 
            // costoVisible
            // 
            this.costoVisible.AutoSize = true;
            this.costoVisible.Location = new System.Drawing.Point(19, 93);
            this.costoVisible.Name = "costoVisible";
            this.costoVisible.Size = new System.Drawing.Size(85, 17);
            this.costoVisible.TabIndex = 43;
            this.costoVisible.Text = "Costo visible";
            this.costoVisible.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(773, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 26);
            this.button1.TabIndex = 42;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(150, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(174, 17);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Buscar en todas las Sucursales";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Sucursal";
            // 
            // txtBuscarSucursal1
            // 
            this.txtBuscarSucursal1.FormattingEnabled = true;
            this.txtBuscarSucursal1.Location = new System.Drawing.Point(19, 66);
            this.txtBuscarSucursal1.Name = "txtBuscarSucursal1";
            this.txtBuscarSucursal1.Size = new System.Drawing.Size(125, 21);
            this.txtBuscarSucursal1.TabIndex = 39;
            this.txtBuscarSucursal1.SelectedIndexChanged += new System.EventHandler(this.txtBuscarSucursal1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(639, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Codigo";
            // 
            // txtBuscarCodigo1
            // 
            this.txtBuscarCodigo1.Location = new System.Drawing.Point(642, 66);
            this.txtBuscarCodigo1.Name = "txtBuscarCodigo1";
            this.txtBuscarCodigo1.Size = new System.Drawing.Size(125, 20);
            this.txtBuscarCodigo1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(499, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID";
            // 
            // txtBuscarId1
            // 
            this.txtBuscarId1.Location = new System.Drawing.Point(499, 67);
            this.txtBuscarId1.Name = "txtBuscarId1";
            this.txtBuscarId1.Size = new System.Drawing.Size(125, 20);
            this.txtBuscarId1.TabIndex = 35;
            // 
            // InventarioLlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 547);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioLlantas";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DReporteLlantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioLlantaListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteAroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioAroListaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DReporteAroBindingSource;
        private System.Windows.Forms.BindingSource InventarioAroListaBindingSource;
        private System.Windows.Forms.BindingSource DReporteLlantaBindingSource;
        private System.Windows.Forms.BindingSource InventarioLlantaListaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtBuscarSucursal1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarCodigo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarId1;
        private System.Windows.Forms.CheckBox costoVisible;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBodegas;
        private System.Windows.Forms.CheckBox buscarBodega;
    }
}