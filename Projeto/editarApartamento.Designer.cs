namespace Projeto
{
    partial class editarApartamento
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rbAlugadoS = new System.Windows.Forms.RadioButton();
            this.rbAlugadoN = new System.Windows.Forms.RadioButton();
            this.cbCond = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.txtBloco = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cbProprietario = new System.Windows.Forms.ComboBox();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(189, 233);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 39);
            this.btnSalvar.TabIndex = 62;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(301, 233);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 39);
            this.btnSair.TabIndex = 61;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(24, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 32);
            this.label9.TabIndex = 44;
            this.label9.Text = "Editar Apartamento";
            // 
            // rbAlugadoS
            // 
            this.rbAlugadoS.AutoSize = true;
            this.rbAlugadoS.BackColor = System.Drawing.Color.Transparent;
            this.rbAlugadoS.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbAlugadoS.ForeColor = System.Drawing.Color.White;
            this.rbAlugadoS.Location = new System.Drawing.Point(398, 170);
            this.rbAlugadoS.Name = "rbAlugadoS";
            this.rbAlugadoS.Size = new System.Drawing.Size(53, 20);
            this.rbAlugadoS.TabIndex = 73;
            this.rbAlugadoS.TabStop = true;
            this.rbAlugadoS.Text = "Sim";
            this.rbAlugadoS.UseVisualStyleBackColor = false;
            this.rbAlugadoS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbAlugadoS_MouseClick);
            // 
            // rbAlugadoN
            // 
            this.rbAlugadoN.AutoSize = true;
            this.rbAlugadoN.BackColor = System.Drawing.Color.Transparent;
            this.rbAlugadoN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbAlugadoN.ForeColor = System.Drawing.Color.White;
            this.rbAlugadoN.Location = new System.Drawing.Point(493, 170);
            this.rbAlugadoN.Name = "rbAlugadoN";
            this.rbAlugadoN.Size = new System.Drawing.Size(54, 20);
            this.rbAlugadoN.TabIndex = 72;
            this.rbAlugadoN.TabStop = true;
            this.rbAlugadoN.Text = "Não";
            this.rbAlugadoN.UseVisualStyleBackColor = false;
            this.rbAlugadoN.DragOver += new System.Windows.Forms.DragEventHandler(this.rbAlugadoN_DragOver);
            this.rbAlugadoN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbAlugadoN_MouseClick);
            // 
            // cbCond
            // 
            this.cbCond.DisplayMember = "gfd";
            this.cbCond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCond.FormattingEnabled = true;
            this.cbCond.Location = new System.Drawing.Point(29, 111);
            this.cbCond.Name = "cbCond";
            this.cbCond.Size = new System.Drawing.Size(149, 21);
            this.cbCond.TabIndex = 71;
            this.cbCond.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(27, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Condominio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Bloco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(395, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Alugado?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(395, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Andar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(195, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Número:";
            // 
            // txtAndar
            // 
            this.txtAndar.BackColor = System.Drawing.Color.White;
            this.txtAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAndar.Location = new System.Drawing.Point(398, 106);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(149, 26);
            this.txtAndar.TabIndex = 65;
            this.txtAndar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAndar_KeyPress);
            // 
            // txtBloco
            // 
            this.txtBloco.BackColor = System.Drawing.Color.White;
            this.txtBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloco.Location = new System.Drawing.Point(29, 164);
            this.txtBloco.Name = "txtBloco";
            this.txtBloco.Size = new System.Drawing.Size(149, 26);
            this.txtBloco.TabIndex = 64;
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(198, 106);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(149, 26);
            this.txtNum.TabIndex = 63;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // cbProprietario
            // 
            this.cbProprietario.DisplayMember = "gfd";
            this.cbProprietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProprietario.FormattingEnabled = true;
            this.cbProprietario.Location = new System.Drawing.Point(199, 167);
            this.cbProprietario.Name = "cbProprietario";
            this.cbProprietario.Size = new System.Drawing.Size(148, 21);
            this.cbProprietario.TabIndex = 75;
            this.cbProprietario.Tag = "";
            this.cbProprietario.Visible = false;
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.BackColor = System.Drawing.Color.Transparent;
            this.lblProprietario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProprietario.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblProprietario.Location = new System.Drawing.Point(195, 146);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(99, 16);
            this.lblProprietario.TabIndex = 74;
            this.lblProprietario.Text = "Proprietário:";
            this.lblProprietario.Visible = false;
            // 
            // editarApartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this.cbProprietario);
            this.Controls.Add(this.lblProprietario);
            this.Controls.Add(this.rbAlugadoS);
            this.Controls.Add(this.rbAlugadoN);
            this.Controls.Add(this.cbCond);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAndar);
            this.Controls.Add(this.txtBloco);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label9);
            this.Name = "editarApartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editarApartamento";
            this.Load += new System.EventHandler(this.editarApartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbAlugadoS;
        private System.Windows.Forms.RadioButton rbAlugadoN;
        private System.Windows.Forms.ComboBox cbCond;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.TextBox txtBloco;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cbProprietario;
        private System.Windows.Forms.Label lblProprietario;

    }
}