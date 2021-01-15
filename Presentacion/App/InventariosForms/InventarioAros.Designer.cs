
namespace Presentacion.App
{
    partial class InventarioAros
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costoVisible = new System.Windows.Forms.CheckBox();
            this.btntListarBuscar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBodegas = new System.Windows.Forms.ComboBox();
            this.buscarBodega = new System.Windows.Forms.CheckBox();
            this.DReporteAroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioAroListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DReporteLlantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioLlantaListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteAroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioAroListaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteLlantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioLlantaListaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "reporteAro";
            reportDataSource1.Value = this.DReporteAroBindingSource;
            reportDataSource2.Name = "inventarioAroLista";
            reportDataSource2.Value = this.InventarioAroListaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informes.InventarioAro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 152);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(991, 395);
            this.reportViewer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.buscarBodega);
            this.groupBox1.Controls.Add(this.costoVisible);
            this.groupBox1.Controls.Add(this.btntListarBuscar);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBuscarSucursal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscarCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscarId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros del reporte";
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
            // btntListarBuscar
            // 
            this.btntListarBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btntListarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntListarBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntListarBuscar.ForeColor = System.Drawing.Color.White;
            this.btntListarBuscar.Location = new System.Drawing.Point(785, 64);
            this.btntListarBuscar.Name = "btntListarBuscar";
            this.btntListarBuscar.Size = new System.Drawing.Size(184, 26);
            this.btntListarBuscar.TabIndex = 42;
            this.btntListarBuscar.Text = "Generar reporte";
            this.btntListarBuscar.UseVisualStyleBackColor = false;
            this.btntListarBuscar.Click += new System.EventHandler(this.btntListarBuscar_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(150, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 17);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Buscar en todas las Sucursales";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Sucursal";
            // 
            // txtBuscarSucursal
            // 
            this.txtBuscarSucursal.FormattingEnabled = true;
            this.txtBuscarSucursal.Location = new System.Drawing.Point(19, 66);
            this.txtBuscarSucursal.Name = "txtBuscarSucursal";
            this.txtBuscarSucursal.Size = new System.Drawing.Size(125, 21);
            this.txtBuscarSucursal.TabIndex = 39;
            this.txtBuscarSucursal.SelectedIndexChanged += new System.EventHandler(this.txtBuscarSucursal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(650, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Codigo";
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(653, 69);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(125, 20);
            this.txtBuscarCodigo.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(498, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(498, 68);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(125, 20);
            this.txtBuscarId.TabIndex = 35;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.comboBodegas);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(339, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 97);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bodegas";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 17);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Text = "Todas las bodegas";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
            this.buscarBodega.Location = new System.Drawing.Point(339, 25);
            this.buscarBodega.Name = "buscarBodega";
            this.buscarBodega.Size = new System.Drawing.Size(113, 17);
            this.buscarBodega.TabIndex = 46;
            this.buscarBodega.Text = "Buscar en bodega";
            this.buscarBodega.UseVisualStyleBackColor = true;
            this.buscarBodega.CheckedChanged += new System.EventHandler(this.buscarBodega_CheckedChanged);
            // 
            // DReporteAroBindingSource
            // 
            this.DReporteAroBindingSource.DataSource = typeof(Dominio.DReporteAro);
            // 
            // InventarioAroListaBindingSource
            // 
            this.InventarioAroListaBindingSource.DataSource = typeof(Dominio.InventarioAroLista);
            // 
            // DReporteLlantaBindingSource
            // 
            this.DReporteLlantaBindingSource.DataSource = typeof(Dominio.DReporteLlanta);
            // 
            // InventarioLlantaListaBindingSource
            // 
            this.InventarioLlantaListaBindingSource.DataSource = typeof(Dominio.InventarioLlantaLista);
            // 
            // InventarioAros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 547);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioAros";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteAroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioAroListaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DReporteLlantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioLlantaListaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DReporteAroBindingSource;
        private System.Windows.Forms.BindingSource InventarioAroListaBindingSource;
        private System.Windows.Forms.BindingSource DReporteLlantaBindingSource;
        private System.Windows.Forms.BindingSource InventarioLlantaListaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntListarBuscar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtBuscarSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.CheckBox costoVisible;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBodegas;
        private System.Windows.Forms.CheckBox buscarBodega;
    }
}