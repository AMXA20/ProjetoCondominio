namespace Projeto
{
    partial class editarMultar
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
            this.cbApartamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCond = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbTp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rtDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnvio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbApartamento
            // 
            this.cbApartamento.DisplayMember = "gfd";
            this.cbApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApartamento.Enabled = false;
            this.cbApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApartamento.FormattingEnabled = true;
            this.cbApartamento.Location = new System.Drawing.Point(255, 156);
            this.cbApartamento.Name = "cbApartamento";
            this.cbApartamento.Size = new System.Drawing.Size(240, 24);
            this.cbApartamento.TabIndex = 117;
            this.cbApartamento.Tag = "";
            this.cbApartamento.SelectedIndexChanged += new System.EventHandler(this.cbApartamento_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(252, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 116;
            this.label7.Text = "Apartamento:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbCond
            // 
            this.cbCond.DisplayMember = "gfd";
            this.cbCond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCond.FormattingEnabled = true;
            this.cbCond.Location = new System.Drawing.Point(63, 156);
            this.cbCond.Name = "cbCond";
            this.cbCond.Size = new System.Drawing.Size(183, 24);
            this.cbCond.TabIndex = 115;
            this.cbCond.Tag = "";
            this.cbCond.SelectedIndexChanged += new System.EventHandler(this.cbCond_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(60, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.TabIndex = 114;
            this.label4.Text = "Selecione o Condominio:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(57, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 32);
            this.label9.TabIndex = 113;
            this.label9.Text = "Editar Multa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(150, 313);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 39);
            this.btnSalvar.TabIndex = 111;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(298, 313);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 39);
            this.btnSair.TabIndex = 112;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbTp
            // 
            this.cbTp.DisplayMember = "gfd";
            this.cbTp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTp.FormattingEnabled = true;
            this.cbTp.Location = new System.Drawing.Point(63, 105);
            this.cbTp.Name = "cbTp";
            this.cbTp.Size = new System.Drawing.Size(117, 24);
            this.cbTp.TabIndex = 110;
            this.cbTp.Tag = "";
            this.cbTp.SelectedIndexChanged += new System.EventHandler(this.cbTp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 109;
            this.label1.Text = "Data de Vencimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(60, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Tipo de Multa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtVencimento
            // 
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(366, 109);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(129, 20);
            this.dtVencimento.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(60, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 119;
            this.label6.Text = "Descrição da Multa:";
            // 
            // rtDesc
            // 
            this.rtDesc.Location = new System.Drawing.Point(63, 211);
            this.rtDesc.Name = "rtDesc";
            this.rtDesc.Size = new System.Drawing.Size(432, 96);
            this.rtDesc.TabIndex = 118;
            this.rtDesc.Text = "";
            this.rtDesc.TextChanged += new System.EventHandler(this.rtDesc_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(215, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "Data de Envio:";
            // 
            // dtEnvio
            // 
            this.dtEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnvio.Location = new System.Drawing.Point(218, 109);
            this.dtEnvio.Name = "dtEnvio";
            this.dtEnvio.Size = new System.Drawing.Size(117, 20);
            this.dtEnvio.TabIndex = 120;
            // 
            // editarMultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(546, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEnvio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtDesc);
            this.Controls.Add(this.cbApartamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCond);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cbTp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtVencimento);
            this.Name = "editarMultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editarMultar";
            this.Load += new System.EventHandler(this.editarMultar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbApartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbTp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnvio;
    }
}