namespace Projeto
{
    partial class RelatorioCondominio
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
            this.tbCondominioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCondominioDataSet = new Projeto.bdCondominioDataSet();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbCondominioTableAdapter = new Projeto.bdCondominioDataSetTableAdapters.tbCondominioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbCondominioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCondominioBindingSource
            // 
            this.tbCondominioBindingSource.DataMember = "tbCondominio";
            this.tbCondominioBindingSource.DataSource = this.bdCondominioDataSet;
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
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Relatório de Condominio";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsCond";
            reportDataSource1.Value = this.tbCondominioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.ReportCondominio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 207);
            this.reportViewer1.TabIndex = 5;
            // 
            // tbCondominioTableAdapter
            // 
            this.tbCondominioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 6;
            // 
            // RelatorioCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Name = "RelatorioCondominio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioCondominio";
            this.Load += new System.EventHandler(this.RelatorioCondominio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCondominioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbCondominioBindingSource;
        private bdCondominioDataSet bdCondominioDataSet;
        private bdCondominioDataSetTableAdapters.tbCondominioTableAdapter tbCondominioTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}