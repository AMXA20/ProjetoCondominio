namespace Projeto
{
    partial class RelatorioMulta
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
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdCondominioDataSet = new Projeto.bdCondominioDataSet();
            this.tbMultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMultaTableAdapter = new Projeto.bdCondominioDataSetTableAdapters.tbMultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMultaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Relatório de Multas";
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "dsMulta";
            reportDataSource3.Value = this.tbMultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.ReportMultar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 212);
            this.reportViewer1.TabIndex = 11;
            // 
            // bdCondominioDataSet
            // 
            this.bdCondominioDataSet.DataSetName = "bdCondominioDataSet";
            this.bdCondominioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMultaBindingSource
            // 
            this.tbMultaBindingSource.DataMember = "tbMulta";
            this.tbMultaBindingSource.DataSource = this.bdCondominioDataSet;
            // 
            // tbMultaTableAdapter
            // 
            this.tbMultaTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 262);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Name = "RelatorioMulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.RelatorioMulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMultaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbMultaBindingSource;
        private bdCondominioDataSet bdCondominioDataSet;
        private bdCondominioDataSetTableAdapters.tbMultaTableAdapter tbMultaTableAdapter;
    }
}