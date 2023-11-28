namespace editora_trab
{
    partial class frmCadastroEditoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEditoras));
            this.btPesquisarEditoras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoEditora = new System.Windows.Forms.TextBox();
            this.tbObservacoesEdi = new System.Windows.Forms.TextBox();
            this.tbSiglaEditora = new System.Windows.Forms.TextBox();
            this.tbNomeEditora = new System.Windows.Forms.TextBox();
            this.btSalvarEditoras = new System.Windows.Forms.Button();
            this.btRemoverEditoras = new System.Windows.Forms.Button();
            this.btLimparEditoras = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPesquisarEditoras
            // 
            this.btPesquisarEditoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btPesquisarEditoras.Location = new System.Drawing.Point(454, 405);
            this.btPesquisarEditoras.Name = "btPesquisarEditoras";
            this.btPesquisarEditoras.Size = new System.Drawing.Size(161, 46);
            this.btPesquisarEditoras.TabIndex = 0;
            this.btPesquisarEditoras.Text = "Pesquisar";
            this.btPesquisarEditoras.UseVisualStyleBackColor = false;
            this.btPesquisarEditoras.Click += new System.EventHandler(this.btPesquisarEditoras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(252, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCodigoEditora
            // 
            this.tbCodigoEditora.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbCodigoEditora.Enabled = false;
            this.tbCodigoEditora.Location = new System.Drawing.Point(373, 137);
            this.tbCodigoEditora.Multiline = true;
            this.tbCodigoEditora.Name = "tbCodigoEditora";
            this.tbCodigoEditora.Size = new System.Drawing.Size(348, 29);
            this.tbCodigoEditora.TabIndex = 2;
            this.tbCodigoEditora.TextChanged += new System.EventHandler(this.tbCodigoEditora_TextChanged);
            // 
            // tbObservacoesEdi
            // 
            this.tbObservacoesEdi.Location = new System.Drawing.Point(427, 265);
            this.tbObservacoesEdi.Multiline = true;
            this.tbObservacoesEdi.Name = "tbObservacoesEdi";
            this.tbObservacoesEdi.Size = new System.Drawing.Size(294, 29);
            this.tbObservacoesEdi.TabIndex = 3;
            this.tbObservacoesEdi.TextChanged += new System.EventHandler(this.tbObservacoesEdi_TextChanged);
            // 
            // tbSiglaEditora
            // 
            this.tbSiglaEditora.Location = new System.Drawing.Point(351, 222);
            this.tbSiglaEditora.Multiline = true;
            this.tbSiglaEditora.Name = "tbSiglaEditora";
            this.tbSiglaEditora.Size = new System.Drawing.Size(370, 29);
            this.tbSiglaEditora.TabIndex = 4;
            this.tbSiglaEditora.TextChanged += new System.EventHandler(this.tbSiglaEditora_TextChanged);
            // 
            // tbNomeEditora
            // 
            this.tbNomeEditora.Location = new System.Drawing.Point(481, 178);
            this.tbNomeEditora.Multiline = true;
            this.tbNomeEditora.Name = "tbNomeEditora";
            this.tbNomeEditora.Size = new System.Drawing.Size(240, 29);
            this.tbNomeEditora.TabIndex = 5;
            this.tbNomeEditora.TextChanged += new System.EventHandler(this.tbNomeEditora_TextChanged);
            // 
            // btSalvarEditoras
            // 
            this.btSalvarEditoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btSalvarEditoras.Location = new System.Drawing.Point(454, 326);
            this.btSalvarEditoras.Name = "btSalvarEditoras";
            this.btSalvarEditoras.Size = new System.Drawing.Size(161, 46);
            this.btSalvarEditoras.TabIndex = 9;
            this.btSalvarEditoras.Text = "Salvar";
            this.btSalvarEditoras.UseVisualStyleBackColor = false;
            this.btSalvarEditoras.Click += new System.EventHandler(this.btSalvarEditoras_Click);
            // 
            // btRemoverEditoras
            // 
            this.btRemoverEditoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btRemoverEditoras.Location = new System.Drawing.Point(257, 405);
            this.btRemoverEditoras.Name = "btRemoverEditoras";
            this.btRemoverEditoras.Size = new System.Drawing.Size(161, 46);
            this.btRemoverEditoras.TabIndex = 10;
            this.btRemoverEditoras.Text = "Remover";
            this.btRemoverEditoras.UseVisualStyleBackColor = false;
            this.btRemoverEditoras.Click += new System.EventHandler(this.btRemoverEditoras_Click);
            // 
            // btLimparEditoras
            // 
            this.btLimparEditoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btLimparEditoras.ForeColor = System.Drawing.Color.Black;
            this.btLimparEditoras.Location = new System.Drawing.Point(257, 326);
            this.btLimparEditoras.Name = "btLimparEditoras";
            this.btLimparEditoras.Size = new System.Drawing.Size(161, 46);
            this.btLimparEditoras.TabIndex = 11;
            this.btLimparEditoras.Text = "Limpar";
            this.btLimparEditoras.UseVisualStyleBackColor = false;
            this.btLimparEditoras.Click += new System.EventHandler(this.btLimparEditoras_Click);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(-5, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(230, 501);
            this.pb1.TabIndex = 12;
            this.pb1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(252, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome da Editora: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(252, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sigla:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(252, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Observações:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.button5.Location = new System.Drawing.Point(645, 452);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 31);
            this.button5.TabIndex = 16;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(295, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 54);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cadastro Editoras";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastroEditoras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(770, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btLimparEditoras);
            this.Controls.Add(this.btRemoverEditoras);
            this.Controls.Add(this.btSalvarEditoras);
            this.Controls.Add(this.tbNomeEditora);
            this.Controls.Add(this.tbSiglaEditora);
            this.Controls.Add(this.tbObservacoesEdi);
            this.Controls.Add(this.tbCodigoEditora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPesquisarEditoras);
            this.MaximizeBox = false;
            this.Name = "frmCadastroEditoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Cadastro Editoras ::..";
            this.Load += new System.EventHandler(this.frmCadastroEditoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPesquisarEditoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoEditora;
        private System.Windows.Forms.TextBox tbObservacoesEdi;
        private System.Windows.Forms.TextBox tbSiglaEditora;
        private System.Windows.Forms.TextBox tbNomeEditora;
        private System.Windows.Forms.Button btSalvarEditoras;
        private System.Windows.Forms.Button btRemoverEditoras;
        private System.Windows.Forms.Button btLimparEditoras;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}