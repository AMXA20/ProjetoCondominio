namespace Projeto
{
    partial class RelatorioMorador
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
            this.tbMoradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCondominioDataSet = new Projeto.bdCondominioDataSet();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbMoradorTableAdapter = new Projeto.bdCondominioDataSetTableAdapters.tbMoradorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbMoradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMoradorBindingSource
            // 
            this.tbMoradorBindingSource.DataMember = "tbMorador";
            this.tbMoradorBindingSource.DataSource = this.bdCondominioDataSet;
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
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Relatório de Morador";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsMorador";
            reportDataSource1.Value = this.tbMoradorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.ReportMorador.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(637, 198);
            this.reportViewer1.TabIndex = 7;
            // 
            // tbMoradorTableAdapter
            // 
            this.tbMoradorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 8;
            // 
            // RelatorioMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Name = "RelatorioMorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioMorador";
            this.Load += new System.EventHandler(this.RelatorioMorador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMoradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbMoradorBindingSource;
        private bdCondominioDataSet bdCondominioDataSet;
        private bdCondominioDataSetTableAdapters.tbMoradorTableAdapter tbMoradorTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}