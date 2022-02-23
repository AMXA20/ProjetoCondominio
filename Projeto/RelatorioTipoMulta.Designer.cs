namespace Projeto
{
    partial class RelatorioTipoMulta
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
            this.tbTipoMultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCondominioDataSet = new Projeto.bdCondominioDataSet();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbTipoMultaTableAdapter = new Projeto.bdCondominioDataSetTableAdapters.tbTipoMultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbTipoMultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTipoMultaBindingSource
            // 
            this.tbTipoMultaBindingSource.DataMember = "tbTipoMulta";
            this.tbTipoMultaBindingSource.DataSource = this.bdCondominioDataSet;
            // 
            // bdCondominioDataSet
            // 
            this.bdCondominioDataSet.DataSetName = "bdCondominioDataSet";
            this.bdCondominioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(449, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 22);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Relatório de Tipo de Multa";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsTipoMulta";
            reportDataSource1.Value = this.tbTipoMultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.ReportTipoMulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 213);
            this.reportViewer1.TabIndex = 11;
            // 
            // tbTipoMultaTableAdapter
            // 
            this.tbTipoMultaTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioTipoMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 262);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Name = "RelatorioTipoMulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioTipoMulta";
            this.Load += new System.EventHandler(this.RelatorioTipoMulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTipoMultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbTipoMultaBindingSource;
        private bdCondominioDataSet bdCondominioDataSet;
        private bdCondominioDataSetTableAdapters.tbTipoMultaTableAdapter tbTipoMultaTableAdapter;
    }
}