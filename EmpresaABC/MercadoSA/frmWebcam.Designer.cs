
namespace MercadoSA
{
    partial class frmWebcam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebcam));
            this.pctCapturarImagem = new System.Windows.Forms.PictureBox();
            this.cbbDispositivos = new System.Windows.Forms.ComboBox();
            this.lblDispositivos = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.sfdSalvarImagem = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCapturarImagem
            // 
            this.pctCapturarImagem.Location = new System.Drawing.Point(55, 38);
            this.pctCapturarImagem.Name = "pctCapturarImagem";
            this.pctCapturarImagem.Size = new System.Drawing.Size(447, 383);
            this.pctCapturarImagem.TabIndex = 0;
            this.pctCapturarImagem.TabStop = false;
            // 
            // cbbDispositivos
            // 
            this.cbbDispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDispositivos.FormattingEnabled = true;
            this.cbbDispositivos.Location = new System.Drawing.Point(55, 451);
            this.cbbDispositivos.Name = "cbbDispositivos";
            this.cbbDispositivos.Size = new System.Drawing.Size(447, 28);
            this.cbbDispositivos.TabIndex = 1;
            // 
            // lblDispositivos
            // 
            this.lblDispositivos.AutoSize = true;
            this.lblDispositivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivos.Location = new System.Drawing.Point(51, 424);
            this.lblDispositivos.Name = "lblDispositivos";
            this.lblDispositivos.Size = new System.Drawing.Size(113, 24);
            this.lblDispositivos.TabIndex = 2;
            this.lblDispositivos.Text = "Dispositivos:";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(519, 38);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(253, 75);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(519, 161);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(253, 75);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(519, 295);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(253, 75);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lblDispositivos);
            this.Controls.Add(this.cbbDispositivos);
            this.Controls.Add(this.pctCapturarImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWebcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam";
            this.Load += new System.EventHandler(this.frmWebcam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturarImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCapturarImagem;
        private System.Windows.Forms.ComboBox cbbDispositivos;
        private System.Windows.Forms.Label lblDispositivos;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.SaveFileDialog sfdSalvarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
    }
}