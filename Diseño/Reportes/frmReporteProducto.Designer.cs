namespace Presentacion.Reportes
{
    partial class frmReporteProducto
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cyberCatchVentasDataSet = new Presentacion.CyberCatchVentasDataSet();
            this.vistaCompatibleProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_Compatible_ProductoTableAdapter = new Presentacion.CyberCatchVentasDataSetTableAdapters.Vista_Compatible_ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cyberCatchVentasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCompatibleProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaCompatibleProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(597, 513);
            this.reportViewer1.TabIndex = 0;
            // 
            // cyberCatchVentasDataSet
            // 
            this.cyberCatchVentasDataSet.DataSetName = "CyberCatchVentasDataSet";
            this.cyberCatchVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaCompatibleProductoBindingSource
            // 
            this.vistaCompatibleProductoBindingSource.DataMember = "Vista_Compatible_Producto";
            this.vistaCompatibleProductoBindingSource.DataSource = this.cyberCatchVentasDataSet;
            // 
            // vista_Compatible_ProductoTableAdapter
            // 
            this.vista_Compatible_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(597, 513);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteProducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Producto";
            this.Load += new System.EventHandler(this.frmReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cyberCatchVentasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCompatibleProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CyberCatchVentasDataSet cyberCatchVentasDataSet;
        private System.Windows.Forms.BindingSource vistaCompatibleProductoBindingSource;
        private CyberCatchVentasDataSetTableAdapters.Vista_Compatible_ProductoTableAdapter vista_Compatible_ProductoTableAdapter;
    }
}