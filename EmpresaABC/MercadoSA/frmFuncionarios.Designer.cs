
namespace MercadoSA
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.gpbFuncionarios = new System.Windows.Forms.GroupBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtpDNasc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbFuncionarios.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbFuncionarios.Controls.Add(this.txtBairro);
            this.gpbFuncionarios.Controls.Add(this.lblBairro);
            this.gpbFuncionarios.Controls.Add(this.lblEstado);
            this.gpbFuncionarios.Controls.Add(this.cbbEstado);
            this.gpbFuncionarios.Controls.Add(this.txtCidade);
            this.gpbFuncionarios.Controls.Add(this.lblCidade);
            this.gpbFuncionarios.Controls.Add(this.txtNumero);
            this.gpbFuncionarios.Controls.Add(this.lblNumero);
            this.gpbFuncionarios.Controls.Add(this.mskCep);
            this.gpbFuncionarios.Controls.Add(this.lblCep);
            this.gpbFuncionarios.Controls.Add(this.txtEndereco);
            this.gpbFuncionarios.Controls.Add(this.lblEndereco);
            this.gpbFuncionarios.Controls.Add(this.txtEmail);
            this.gpbFuncionarios.Controls.Add(this.lblEmail);
            this.gpbFuncionarios.Controls.Add(this.dtpDNasc);
            this.gpbFuncionarios.Controls.Add(this.label4);
            this.gpbFuncionarios.Controls.Add(this.mskCpf);
            this.gpbFuncionarios.Controls.Add(this.lblCpf);
            this.gpbFuncionarios.Controls.Add(this.txtNome);
            this.gpbFuncionarios.Controls.Add(this.lblNome);
            this.gpbFuncionarios.Controls.Add(this.txtCodigo);
            this.gpbFuncionarios.Controls.Add(this.lblCodigo);
            this.gpbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.gpbFuncionarios.Name = "gpbFuncionarios";
            this.gpbFuncionarios.Size = new System.Drawing.Size(756, 401);
            this.gpbFuncionarios.TabIndex = 0;
            this.gpbFuncionarios.TabStop = false;
            this.gpbFuncionarios.Text = "Dados";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(220, 232);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(129, 24);
            this.txtBairro.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(166, 235);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(48, 18);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(371, 235);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "ES",
            "MG"});
            this.cbbEstado.Location = new System.Drawing.Point(431, 231);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 26);
            this.cbbEstado.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(432, 180);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(147, 24);
            this.txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(372, 183);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 18);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(90, 232);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 24);
            this.txtNumero.TabIndex = 8;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(28, 235);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 18);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Número";
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(622, 232);
            this.mskCep.Mask = "99999-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(77, 24);
            this.mskCep.TabIndex = 11;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(584, 235);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(39, 18);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(100, 181);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(249, 24);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(28, 184);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(72, 18);
            this.lblEndereco.TabIndex = 10;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(438, 81);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(382, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // dtpDNasc
            // 
            this.dtpDNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDNasc.Location = new System.Drawing.Point(374, 130);
            this.dtpDNasc.Name = "dtpDNasc";
            this.dtpDNasc.Size = new System.Drawing.Size(105, 24);
            this.dtpDNasc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de nascimento";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(72, 132);
            this.mskCpf.Mask = "999,999,999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(114, 24);
            this.mskCpf.TabIndex = 4;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(28, 135);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 18);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(83, 81);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 24);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 33);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(12, 477);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(756, 68);
            this.pnlCRUD.TabIndex = 12;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(650, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 42);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(545, 14);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 42);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(437, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(95, 42);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(332, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 42);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(223, 14);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 42);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(115, 14);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(95, 42);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(10, 14);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 42);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja - Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.gpbFuncionarios.ResumeLayout(false);
            this.gpbFuncionarios.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFuncionarios;
        private System.Windows.Forms.DateTimePicker dtpDNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
    }
}