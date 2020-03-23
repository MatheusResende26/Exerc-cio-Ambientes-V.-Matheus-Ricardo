namespace DataGridView
{
    partial class frmlogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLog = new System.Windows.Forms.Label();
            this.txtUs = new System.Windows.Forms.TextBox();
            this.txtSen = new System.Windows.Forms.TextBox();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblSen = new System.Windows.Forms.Label();
            this.gpbLog = new System.Windows.Forms.GroupBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.piccertoSen = new System.Windows.Forms.PictureBox();
            this.piccertoUs = new System.Windows.Forms.PictureBox();
            this.picADM = new System.Windows.Forms.PictureBox();
            this.gpbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccertoSen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccertoUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picADM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(244, 27);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(80, 31);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Login";
            // 
            // txtUs
            // 
            this.txtUs.Location = new System.Drawing.Point(154, 125);
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(148, 20);
            this.txtUs.TabIndex = 1;
            this.txtUs.TextChanged += new System.EventHandler(this.Txtusuario_TextChanged);
            // 
            // txtSen
            // 
            this.txtSen.Location = new System.Drawing.Point(154, 170);
            this.txtSen.Name = "txtSen";
            this.txtSen.PasswordChar = '•';
            this.txtSen.Size = new System.Drawing.Size(148, 20);
            this.txtSen.TabIndex = 2;
            this.txtSen.TextChanged += new System.EventHandler(this.Txtsenha_TextChanged);
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.Location = new System.Drawing.Point(87, 130);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(55, 16);
            this.lblUs.TabIndex = 3;
            this.lblUs.Text = "Usuário";
            // 
            // lblSen
            // 
            this.lblSen.AutoSize = true;
            this.lblSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblSen.Location = new System.Drawing.Point(101, 172);
            this.lblSen.Name = "lblSen";
            this.lblSen.Size = new System.Drawing.Size(47, 16);
            this.lblSen.TabIndex = 4;
            this.lblSen.Text = "Senha";
            // 
            // gpbLog
            // 
            this.gpbLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbLog.Controls.Add(this.piccertoSen);
            this.gpbLog.Controls.Add(this.piccertoUs);
            this.gpbLog.Controls.Add(this.btnEntrar);
            this.gpbLog.Controls.Add(this.picADM);
            this.gpbLog.Controls.Add(this.lblSen);
            this.gpbLog.Controls.Add(this.lblUs);
            this.gpbLog.Controls.Add(this.txtSen);
            this.gpbLog.Controls.Add(this.txtUs);
            this.gpbLog.Location = new System.Drawing.Point(48, 99);
            this.gpbLog.Name = "gpbLog";
            this.gpbLog.Size = new System.Drawing.Size(492, 255);
            this.gpbLog.TabIndex = 5;
            this.gpbLog.TabStop = false;
            this.gpbLog.Text = "Login e senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar.Location = new System.Drawing.Point(186, 212);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(90, 37);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Visible = false;
            this.btnEntrar.Click += new System.EventHandler(this.Btnentrar_Click);
            this.btnEntrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btnentrar_MouseUp);
            // 
            // piccertoSen
            // 
            this.piccertoSen.Image = global::DataGridView.Properties.Resources.certo_png;
            this.piccertoSen.Location = new System.Drawing.Point(308, 170);
            this.piccertoSen.Name = "piccertoSen";
            this.piccertoSen.Size = new System.Drawing.Size(23, 18);
            this.piccertoSen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccertoSen.TabIndex = 9;
            this.piccertoSen.TabStop = false;
            this.piccertoSen.Visible = false;
            // 
            // piccertoUs
            // 
            this.piccertoUs.Image = global::DataGridView.Properties.Resources.certo_png;
            this.piccertoUs.Location = new System.Drawing.Point(308, 125);
            this.piccertoUs.Name = "piccertoUs";
            this.piccertoUs.Size = new System.Drawing.Size(23, 18);
            this.piccertoUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccertoUs.TabIndex = 8;
            this.piccertoUs.TabStop = false;
            this.piccertoUs.Visible = false;
            // 
            // picADM
            // 
            this.picADM.BackgroundImage = global::DataGridView.Properties.Resources.adm;
            this.picADM.Image = global::DataGridView.Properties.Resources.adm;
            this.picADM.Location = new System.Drawing.Point(186, 19);
            this.picADM.Name = "picADM";
            this.picADM.Size = new System.Drawing.Size(90, 90);
            this.picADM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picADM.TabIndex = 5;
            this.picADM.TabStop = false;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 448);
            this.Controls.Add(this.gpbLog);
            this.Controls.Add(this.lblLog);
            this.Name = "frmlogin";
            this.Text = "Login de usuario";
            this.Load += new System.EventHandler(this.login_Load);
            this.gpbLog.ResumeLayout(false);
            this.gpbLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccertoSen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccertoUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picADM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.TextBox txtSen;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblSen;
        private System.Windows.Forms.GroupBox gpbLog;
        private System.Windows.Forms.PictureBox picADM;
        private System.Windows.Forms.PictureBox piccertoUs;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox piccertoSen;
    }
}

