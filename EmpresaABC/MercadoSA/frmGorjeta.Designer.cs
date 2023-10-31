
namespace MercadoSA
{
    partial class frmGorjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGorjeta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorConta = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorConta = new System.Windows.Forms.TextBox();
            this.txtValorGorjeta = new System.Windows.Forms.TextBox();
            this.cbbQualidade = new System.Windows.Forms.ComboBox();
            this.lblValorGorjeta = new System.Windows.Forms.Label();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.cbbFuncionarios = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodigoConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoConta);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblFuncionario);
            this.groupBox1.Controls.Add(this.cbbFuncionarios);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.lblValorConta);
            this.groupBox1.Controls.Add(this.lblValorTotal);
            this.groupBox1.Controls.Add(this.txtValorConta);
            this.groupBox1.Controls.Add(this.txtValorGorjeta);
            this.groupBox1.Controls.Add(this.cbbQualidade);
            this.groupBox1.Controls.Add(this.lblValorGorjeta);
            this.groupBox1.Controls.Add(this.lblQualidade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(108, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 493);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(227, 449);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 33);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calculadora de Gorjeta";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(167, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(261, 38);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Gorjeta";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(6, 417);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(563, 26);
            this.txtValorTotal.TabIndex = 8;
            // 
            // lblValorConta
            // 
            this.lblValorConta.AutoSize = true;
            this.lblValorConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorConta.Location = new System.Drawing.Point(6, 114);
            this.lblValorConta.Name = "lblValorConta";
            this.lblValorConta.Size = new System.Drawing.Size(131, 20);
            this.lblValorConta.TabIndex = 0;
            this.lblValorConta.Text = "Valor da conta:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(6, 394);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(97, 20);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "Valor total:";
            // 
            // txtValorConta
            // 
            this.txtValorConta.Location = new System.Drawing.Point(6, 137);
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(395, 26);
            this.txtValorConta.TabIndex = 1;
            // 
            // txtValorGorjeta
            // 
            this.txtValorGorjeta.Enabled = false;
            this.txtValorGorjeta.Location = new System.Drawing.Point(6, 352);
            this.txtValorGorjeta.Name = "txtValorGorjeta";
            this.txtValorGorjeta.Size = new System.Drawing.Size(563, 26);
            this.txtValorGorjeta.TabIndex = 6;
            // 
            // cbbQualidade
            // 
            this.cbbQualidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQualidade.FormattingEnabled = true;
            this.cbbQualidade.Items.AddRange(new object[] {
            "Excelente - 10%",
            "Ótimo - 8%",
            "Bom - 5%",
            "Ruim - 2%"});
            this.cbbQualidade.Location = new System.Drawing.Point(6, 201);
            this.cbbQualidade.Name = "cbbQualidade";
            this.cbbQualidade.Size = new System.Drawing.Size(563, 28);
            this.cbbQualidade.TabIndex = 2;
            // 
            // lblValorGorjeta
            // 
            this.lblValorGorjeta.AutoSize = true;
            this.lblValorGorjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorGorjeta.Location = new System.Drawing.Point(6, 329);
            this.lblValorGorjeta.Name = "lblValorGorjeta";
            this.lblValorGorjeta.Size = new System.Drawing.Size(142, 20);
            this.lblValorGorjeta.TabIndex = 5;
            this.lblValorGorjeta.Text = "Valor da gorjeta:";
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidade.Location = new System.Drawing.Point(6, 178);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(181, 20);
            this.lblQualidade.TabIndex = 3;
            this.lblQualidade.Text = "Qualidade do serviço:";
            // 
            // cbbFuncionarios
            // 
            this.cbbFuncionarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFuncionarios.FormattingEnabled = true;
            this.cbbFuncionarios.Location = new System.Drawing.Point(6, 83);
            this.cbbFuncionarios.Name = "cbbFuncionarios";
            this.cbbFuncionarios.Size = new System.Drawing.Size(395, 28);
            this.cbbFuncionarios.TabIndex = 11;
            this.cbbFuncionarios.SelectedIndexChanged += new System.EventHandler(this.cbbFuncionarios_SelectedIndexChanged);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(6, 60);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(198, 20);
            this.lblFuncionario.TabIndex = 12;
            this.lblFuncionario.Text = "Selecionar Funcionário:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(425, 83);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 26);
            this.txtCodigo.TabIndex = 13;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(421, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(289, 511);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 38);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCodigoConta
            // 
            this.txtCodigoConta.Enabled = false;
            this.txtCodigoConta.Location = new System.Drawing.Point(425, 137);
            this.txtCodigoConta.Name = "txtCodigoConta";
            this.txtCodigoConta.Size = new System.Drawing.Size(144, 26);
            this.txtCodigoConta.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código da Conta:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightBlue;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(403, 511);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 38);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmGorjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGorjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGorjeta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorConta;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorConta;
        private System.Windows.Forms.TextBox txtValorGorjeta;
        private System.Windows.Forms.ComboBox cbbQualidade;
        private System.Windows.Forms.Label lblValorGorjeta;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.ComboBox cbbFuncionarios;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoConta;
        private System.Windows.Forms.Button btnVoltar;
    }
}