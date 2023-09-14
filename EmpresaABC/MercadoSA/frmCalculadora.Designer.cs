
namespace MercadoSA
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblTitleResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.gpbOperadores = new System.Windows.Forms.GroupBox();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.gpbOperadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblV1
            // 
            this.lblV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV1.Location = new System.Drawing.Point(12, 75);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(79, 59);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "Variável 1";
            this.lblV1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblV2
            // 
            this.lblV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV2.Location = new System.Drawing.Point(12, 137);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(79, 64);
            this.lblV2.TabIndex = 1;
            this.lblV2.Text = "Variável 2";
            this.lblV2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleResultado
            // 
            this.lblTitleResultado.AutoSize = true;
            this.lblTitleResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleResultado.Location = new System.Drawing.Point(571, 75);
            this.lblTitleResultado.Name = "lblTitleResultado";
            this.lblTitleResultado.Size = new System.Drawing.Size(82, 20);
            this.lblTitleResultado.TabIndex = 2;
            this.lblTitleResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(575, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(151, 72);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Location = new System.Drawing.Point(34, 50);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(90, 22);
            this.rdbAdicao.TabIndex = 6;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Adição(+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // gpbOperadores
            // 
            this.gpbOperadores.Controls.Add(this.rdbDivisao);
            this.gpbOperadores.Controls.Add(this.rdbMultiplicacao);
            this.gpbOperadores.Controls.Add(this.rdbSubtracao);
            this.gpbOperadores.Controls.Add(this.rdbAdicao);
            this.gpbOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperadores.Location = new System.Drawing.Point(261, 181);
            this.gpbOperadores.Name = "gpbOperadores";
            this.gpbOperadores.Size = new System.Drawing.Size(239, 273);
            this.gpbOperadores.TabIndex = 3;
            this.gpbOperadores.TabStop = false;
            this.gpbOperadores.Text = "Operações";
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(34, 89);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(109, 22);
            this.rdbSubtracao.TabIndex = 7;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração(-)";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(34, 137);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(128, 22);
            this.rdbMultiplicacao.TabIndex = 8;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação(*)";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(35, 177);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(89, 22);
            this.rdbDivisao.TabIndex = 9;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão(/)";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(575, 98);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(197, 64);
            this.lblResultado.TabIndex = 8;
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(98, 94);
            this.txtV1.MaxLength = 50;
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 20);
            this.txtV1.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(575, 358);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(151, 72);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(575, 462);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 72);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(97, 161);
            this.txtV2.MaxLength = 50;
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 20);
            this.txtV2.TabIndex = 2;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpbOperadores);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitleResultado);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.gpbOperadores.ResumeLayout(false);
            this.gpbOperadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblTitleResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.GroupBox gpbOperadores;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtV2;
    }
}