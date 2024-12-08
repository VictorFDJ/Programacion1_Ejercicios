namespace pJGestionEventos.Presentacion.Reportes
{
    partial class rfmReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new pJGestionEventos.Presentacion.Reportes.DataSet1();
            this.sPLISTARVISITANTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LISTAR_VISITANTESTableAdapter = new pJGestionEventos.Presentacion.Reportes.DataSet1TableAdapters.SP_LISTAR_VISITANTESTableAdapter();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARVISITANTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.sPLISTARVISITANTESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pJGestionEventos.Presentacion.Reportes.ReporteVisitantes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1196, 742);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPLISTARVISITANTESBindingSource
            // 
            this.sPLISTARVISITANTESBindingSource.DataMember = "SP_LISTAR_VISITANTES";
            this.sPLISTARVISITANTESBindingSource.DataSource = this.dataSet1;
            // 
            // sP_LISTAR_VISITANTESTableAdapter
            // 
            this.sP_LISTAR_VISITANTESTableAdapter.ClearBeforeFill = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFiltrar.Location = new System.Drawing.Point(12, 35);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(241, 22);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.Visible = false;
            // 
            // rfmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 742);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rfmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.rfmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLISTARVISITANTESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPLISTARVISITANTESBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.SP_LISTAR_VISITANTESTableAdapter sP_LISTAR_VISITANTESTableAdapter;
        internal System.Windows.Forms.TextBox txtFiltrar;
    }
}