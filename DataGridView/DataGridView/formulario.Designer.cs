namespace DataGridView
{
    partial class formulario
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
            this.lblForm = new System.Windows.Forms.Label();
            this.gpbForm = new System.Windows.Forms.GroupBox();
            this.txtObgCPF = new System.Windows.Forms.TextBox();
            this.txtObgRG = new System.Windows.Forms.TextBox();
            this.txtObgNome = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.rbmS = new System.Windows.Forms.RadioButton();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpDtNasc = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNesc = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNecEspeciais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblForm.Location = new System.Drawing.Point(245, 9);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(143, 31);
            this.lblForm.TabIndex = 0;
            this.lblForm.Text = "Formulário";
            // 
            // gpbForm
            // 
            this.gpbForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbForm.Controls.Add(this.txtObgCPF);
            this.gpbForm.Controls.Add(this.txtObgRG);
            this.gpbForm.Controls.Add(this.txtObgNome);
            this.gpbForm.Controls.Add(this.btnExcluir);
            this.gpbForm.Controls.Add(this.btCadastrar);
            this.gpbForm.Controls.Add(this.txtCPF);
            this.gpbForm.Controls.Add(this.txtRG);
            this.gpbForm.Controls.Add(this.rbN);
            this.gpbForm.Controls.Add(this.rbmS);
            this.gpbForm.Controls.Add(this.cmbSexo);
            this.gpbForm.Controls.Add(this.dtpDtNasc);
            this.gpbForm.Controls.Add(this.txtNome);
            this.gpbForm.Controls.Add(this.lblCPF);
            this.gpbForm.Controls.Add(this.lblNesc);
            this.gpbForm.Controls.Add(this.lblRG);
            this.gpbForm.Controls.Add(this.lblSexo);
            this.gpbForm.Controls.Add(this.lblDtNasc);
            this.gpbForm.Controls.Add(this.lblNome);
            this.gpbForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gpbForm.Location = new System.Drawing.Point(33, 43);
            this.gpbForm.Name = "gpbForm";
            this.gpbForm.Size = new System.Drawing.Size(596, 343);
            this.gpbForm.TabIndex = 1;
            this.gpbForm.TabStop = false;
            this.gpbForm.Text = "Cadastro de Pessoas";
            this.gpbForm.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtObgCPF
            // 
            this.txtObgCPF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtObgCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObgCPF.ForeColor = System.Drawing.Color.Red;
            this.txtObgCPF.Location = new System.Drawing.Point(259, 250);
            this.txtObgCPF.Name = "txtObgCPF";
            this.txtObgCPF.Size = new System.Drawing.Size(132, 13);
            this.txtObgCPF.TabIndex = 17;
            this.txtObgCPF.Text = "*Preenchimento obrigatório";
            this.txtObgCPF.TextChanged += new System.EventHandler(this.TxtpreencherCPF_TextChanged);
            // 
            // txtObgRG
            // 
            this.txtObgRG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtObgRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObgRG.ForeColor = System.Drawing.Color.Red;
            this.txtObgRG.Location = new System.Drawing.Point(259, 200);
            this.txtObgRG.Name = "txtObgRG";
            this.txtObgRG.Size = new System.Drawing.Size(132, 13);
            this.txtObgRG.TabIndex = 16;
            this.txtObgRG.Text = "*Preenchimento obrigatório";
            this.txtObgRG.TextChanged += new System.EventHandler(this.TxtpreencherRG_TextChanged);
            // 
            // txtObgNome
            // 
            this.txtObgNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtObgNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObgNome.ForeColor = System.Drawing.Color.Red;
            this.txtObgNome.Location = new System.Drawing.Point(385, 28);
            this.txtObgNome.Name = "txtObgNome";
            this.txtObgNome.Size = new System.Drawing.Size(132, 13);
            this.txtObgNome.TabIndex = 15;
            this.txtObgNome.Text = "*Preenchimento obrigatório";
            this.txtObgNome.Visible = false;
            this.txtObgNome.TextChanged += new System.EventHandler(this.TxtpreencheNome_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Location = new System.Drawing.Point(186, 291);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 28);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCadastrar.Location = new System.Drawing.Point(60, 291);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(106, 28);
            this.btCadastrar.TabIndex = 13;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Visible = false;
            this.btCadastrar.Click += new System.EventHandler(this.BtcadastrarF_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(60, 250);
            this.txtCPF.Mask = "999.999.999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(196, 20);
            this.txtCPF.TabIndex = 12;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(60, 200);
            this.txtRG.Mask = "99.999.999-9";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(196, 20);
            this.txtRG.TabIndex = 11;
            this.txtRG.TextChanged += new System.EventHandler(this.mtxtrg_TextChanged);
            // 
            // rbN
            // 
            this.rbN.AutoSize = true;
            this.rbN.Location = new System.Drawing.Point(259, 157);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(45, 17);
            this.rbN.TabIndex = 10;
            this.rbN.TabStop = true;
            this.rbN.Text = "Não";
            this.rbN.UseVisualStyleBackColor = true;
            // 
            // rbmS
            // 
            this.rbmS.AutoSize = true;
            this.rbmS.Location = new System.Drawing.Point(186, 157);
            this.rbmS.Name = "rbmS";
            this.rbmS.Size = new System.Drawing.Size(42, 17);
            this.rbmS.TabIndex = 9;
            this.rbmS.TabStop = true;
            this.rbmS.Text = "Sim";
            this.rbmS.UseVisualStyleBackColor = true;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(68, 117);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(160, 21);
            this.cmbSexo.TabIndex = 8;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.Cmbsexo_SelectedIndexChanged);
            // 
            // dtpDtNasc
            // 
            this.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNasc.Location = new System.Drawing.Point(139, 69);
            this.dtpDtNasc.Name = "dtpDtNasc";
            this.dtpDtNasc.Size = new System.Drawing.Size(103, 20);
            this.dtpDtNasc.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(28, 250);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNesc
            // 
            this.lblNesc.AutoSize = true;
            this.lblNesc.Location = new System.Drawing.Point(28, 161);
            this.lblNesc.Name = "lblNesc";
            this.lblNesc.Size = new System.Drawing.Size(131, 13);
            this.lblNesc.TabIndex = 4;
            this.lblNesc.Text = "Necessidades Especiais?:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(28, 203);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 3;
            this.lblRG.Text = "RG:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(28, 120);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(28, 69);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(105, 13);
            this.lblDtNasc.TabIndex = 1;
            this.lblDtNasc.Text = "Data de nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDataNascimento,
            this.colSexo,
            this.colCPF,
            this.colRG,
            this.colNecEspeciais});
            this.dgvClientes.Location = new System.Drawing.Point(5, 392);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(648, 89);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Nome";
            this.colName.Name = "colName";
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.HeaderText = "Data de Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            // 
            // colCPF
            // 
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            // 
            // colRG
            // 
            this.colRG.HeaderText = "RG";
            this.colRG.Name = "colRG";
            // 
            // colNecEspeciais
            // 
            this.colNecEspeciais.HeaderText = "Necessidades Especiais";
            this.colNecEspeciais.Name = "colNecEspeciais";
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 510);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gpbForm);
            this.Controls.Add(this.lblForm);
            this.Name = "formulario";
            this.Text = "formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.gpbForm.ResumeLayout(false);
            this.gpbForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.GroupBox gpbForm;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.RadioButton rbmS;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtpDtNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNesc;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNecEspeciais;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtObgNome;
        private System.Windows.Forms.TextBox txtObgCPF;
        private System.Windows.Forms.TextBox txtObgRG;
    }
}