﻿
namespace Projeto_Zoologico
{
    partial class frmPesquisarAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarAnimal));
            this.ltbPesquisar = new System.Windows.Forms.ListBox();
            this.gpbPesquisar = new System.Windows.Forms.GroupBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbPesquisar
            // 
            this.ltbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPesquisar.FormattingEnabled = true;
            this.ltbPesquisar.ItemHeight = 20;
            this.ltbPesquisar.Location = new System.Drawing.Point(463, 32);
            this.ltbPesquisar.Name = "ltbPesquisar";
            this.ltbPesquisar.Size = new System.Drawing.Size(329, 344);
            this.ltbPesquisar.TabIndex = 7;
            this.ltbPesquisar.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisar_SelectedIndexChanged);
            // 
            // gpbPesquisar
            // 
            this.gpbPesquisar.Controls.Add(this.lblDescricao);
            this.gpbPesquisar.Controls.Add(this.rdbCodigo);
            this.gpbPesquisar.Controls.Add(this.txtDescricao);
            this.gpbPesquisar.Controls.Add(this.rdbTipo);
            this.gpbPesquisar.Controls.Add(this.rdbNome);
            this.gpbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisar.Location = new System.Drawing.Point(24, 32);
            this.gpbPesquisar.Name = "gpbPesquisar";
            this.gpbPesquisar.Size = new System.Drawing.Size(407, 212);
            this.gpbPesquisar.TabIndex = 0;
            this.gpbPesquisar.TabStop = false;
            this.gpbPesquisar.Text = "Pesquisar por:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(151, 130);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(20, 46);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(20, 153);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(355, 26);
            this.txtDescricao.TabIndex = 4;
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.Location = new System.Drawing.Point(306, 46);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(57, 24);
            this.rdbTipo.TabIndex = 3;
            this.rdbTipo.Text = "Tipo";
            this.rdbTipo.UseVisualStyleBackColor = true;
            this.rdbTipo.CheckedChanged += new System.EventHandler(this.rdbTipo_CheckedChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(162, 46);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(69, 24);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(24, 261);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(188, 170);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(237, 261);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(194, 170);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(463, 393);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(329, 38);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmPesquisarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gpbPesquisar);
            this.Controls.Add(this.ltbPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisarAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Animal";
            this.gpbPesquisar.ResumeLayout(false);
            this.gpbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbPesquisar;
        private System.Windows.Forms.GroupBox gpbPesquisar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}