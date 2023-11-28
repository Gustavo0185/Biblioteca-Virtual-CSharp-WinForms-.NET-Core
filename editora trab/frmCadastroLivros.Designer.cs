namespace editora_trab
{
    partial class frmCadastroLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroLivros));
            this.btLimparLivros = new System.Windows.Forms.Button();
            this.btRemoverLivros = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.tbNomeLivros = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbAnoPuLivros = new System.Windows.Forms.TextBox();
            this.tbCodigoLivros = new System.Windows.Forms.TextBox();
            this.btPesquisarLivros = new System.Windows.Forms.Button();
            this.tbObsLivros = new System.Windows.Forms.TextBox();
            this.cbEDI = new System.Windows.Forms.ComboBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btLimparLivros
            // 
            this.btLimparLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btLimparLivros.Location = new System.Drawing.Point(324, 437);
            this.btLimparLivros.Name = "btLimparLivros";
            this.btLimparLivros.Size = new System.Drawing.Size(139, 46);
            this.btLimparLivros.TabIndex = 23;
            this.btLimparLivros.Text = "Limpar";
            this.btLimparLivros.UseVisualStyleBackColor = false;
            this.btLimparLivros.Click += new System.EventHandler(this.btLimparLivros_Click);
            // 
            // btRemoverLivros
            // 
            this.btRemoverLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btRemoverLivros.Location = new System.Drawing.Point(480, 437);
            this.btRemoverLivros.Name = "btRemoverLivros";
            this.btRemoverLivros.Size = new System.Drawing.Size(130, 46);
            this.btRemoverLivros.TabIndex = 22;
            this.btRemoverLivros.Text = "Remover";
            this.btRemoverLivros.UseVisualStyleBackColor = false;
            this.btRemoverLivros.Click += new System.EventHandler(this.btRemoverLivros_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.Salvar.Location = new System.Drawing.Point(324, 385);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(139, 46);
            this.Salvar.TabIndex = 21;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // tbNomeLivros
            // 
            this.tbNomeLivros.Location = new System.Drawing.Point(440, 148);
            this.tbNomeLivros.Multiline = true;
            this.tbNomeLivros.Name = "tbNomeLivros";
            this.tbNomeLivros.Size = new System.Drawing.Size(300, 29);
            this.tbNomeLivros.TabIndex = 17;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(335, 193);
            this.tbISBN.Multiline = true;
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(405, 29);
            this.tbISBN.TabIndex = 16;
            // 
            // tbAnoPuLivros
            // 
            this.tbAnoPuLivros.Location = new System.Drawing.Point(480, 242);
            this.tbAnoPuLivros.Multiline = true;
            this.tbAnoPuLivros.Name = "tbAnoPuLivros";
            this.tbAnoPuLivros.Size = new System.Drawing.Size(260, 29);
            this.tbAnoPuLivros.TabIndex = 15;
            // 
            // tbCodigoLivros
            // 
            this.tbCodigoLivros.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbCodigoLivros.Enabled = false;
            this.tbCodigoLivros.Location = new System.Drawing.Point(358, 100);
            this.tbCodigoLivros.Multiline = true;
            this.tbCodigoLivros.Name = "tbCodigoLivros";
            this.tbCodigoLivros.Size = new System.Drawing.Size(382, 29);
            this.tbCodigoLivros.TabIndex = 14;
            // 
            // btPesquisarLivros
            // 
            this.btPesquisarLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btPesquisarLivros.Location = new System.Drawing.Point(480, 385);
            this.btPesquisarLivros.Name = "btPesquisarLivros";
            this.btPesquisarLivros.Size = new System.Drawing.Size(130, 46);
            this.btPesquisarLivros.TabIndex = 12;
            this.btPesquisarLivros.Text = "Pesquisar";
            this.btPesquisarLivros.UseVisualStyleBackColor = false;
            this.btPesquisarLivros.Click += new System.EventHandler(this.btPesquisarLivros_Click);
            // 
            // tbObsLivros
            // 
            this.tbObsLivros.Location = new System.Drawing.Point(423, 336);
            this.tbObsLivros.Multiline = true;
            this.tbObsLivros.Name = "tbObsLivros";
            this.tbObsLivros.Size = new System.Drawing.Size(317, 29);
            this.tbObsLivros.TabIndex = 24;
            this.tbObsLivros.TextChanged += new System.EventHandler(this.tbObsLivros_TextChanged);
            // 
            // cbEDI
            // 
            this.cbEDI.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbEDI.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbEDI.DisplayMember = "Nome";
            this.cbEDI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEDI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEDI.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbEDI.Location = new System.Drawing.Point(371, 286);
            this.cbEDI.Name = "cbEDI";
            this.cbEDI.Size = new System.Drawing.Size(369, 24);
            this.cbEDI.TabIndex = 26;
            this.cbEDI.ValueMember = "Codigo";
            this.cbEDI.SelectedIndexChanged += new System.EventHandler(this.cbEDI_SelectedIndexChanged);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(-4, -2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(230, 501);
            this.pb1.TabIndex = 28;
            this.pb1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(315, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 54);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cadastro Livros";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(252, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "Codigo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label9.Location = new System.Drawing.Point(254, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nome Do Livro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(254, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "ISBN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(254, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ano de Publicação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(254, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Editora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(254, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Observações:";
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btVoltar.Location = new System.Drawing.Point(643, 448);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(115, 35);
            this.btVoltar.TabIndex = 36;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // frmCadastroLivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(770, 495);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.tbAnoPuLivros);
            this.Controls.Add(this.cbEDI);
            this.Controls.Add(this.tbObsLivros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNomeLivros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btLimparLivros);
            this.Controls.Add(this.btRemoverLivros);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbCodigoLivros);
            this.Controls.Add(this.btPesquisarLivros);
            this.MaximizeBox = false;
            this.Name = "frmCadastroLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Cadastro Livros ::..";
            this.Load += new System.EventHandler(this.frmCadastroLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimparLivros;
        private System.Windows.Forms.Button btRemoverLivros;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox tbNomeLivros;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbAnoPuLivros;
        private System.Windows.Forms.TextBox tbCodigoLivros;
        private System.Windows.Forms.Button btPesquisarLivros;
        private System.Windows.Forms.TextBox tbObsLivros;
        private System.Windows.Forms.ComboBox cbEDI;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVoltar;
    }
}