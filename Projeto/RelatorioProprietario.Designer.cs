namespace Projeto
{
    partial class RelatorioProprietario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbProprietarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCondominioDataSet = new Projeto.bdCondominioDataSet();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbProprietarioTableAdapter = new Projeto.bdCondominioDataSetTableAdapters.tbProprietarioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbProprietarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProprietarioBindingSource
            // 
            this.tbProprietarioBindingSource.DataMember = "tbProprietario";
            this.tbProprietarioBindingSource.DataSource = this.bdCondominioDataSet;
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
            this.lblData.Location = new System.Drawing.Point(458, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 22);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Relatório de Proprietário";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "dsProprietario";
            reportDataSource2.Value = this.tbProprietarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.ReportProprietario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(659, 214);
            this.reportViewer1.TabIndex = 9;
            // 
            // tbProprietarioTableAdapter
            // 
            this.tbProprietarioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 10;
            // 
            // RelatorioProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Name = "RelatorioProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioProprietario";
            this.Load += new System.EventHandler(this.RelatorioProprietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProprietarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCondominioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbProprietarioBindingSource;
        private bdCondominioDataSet bdCondominioDataSet;
        private bdCondominioDataSetTableAdapters.tbProprietarioTableAdapter tbProprietarioTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}