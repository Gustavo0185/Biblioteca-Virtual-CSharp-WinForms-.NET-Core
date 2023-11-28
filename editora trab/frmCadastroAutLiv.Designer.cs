namespace editora_trab
{
    partial class frmCadastroAutLiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAutLiv));
            this.cbAut = new System.Windows.Forms.ComboBox();
            this.btPesquisarT = new System.Windows.Forms.Button();
            this.btSalvarT = new System.Windows.Forms.Button();
            this.btRemoverT = new System.Windows.Forms.Button();
            this.cbLiv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btLimparAT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAut
            // 
            this.cbAut.DisplayMember = "Nome";
            this.cbAut.FormattingEnabled = true;
            this.cbAut.Location = new System.Drawing.Point(467, 178);
            this.cbAut.Name = "cbAut";
            this.cbAut.Size = new System.Drawing.Size(255, 24);
            this.cbAut.TabIndex = 3;
            this.cbAut.ValueMember = "Codigo";
            // 
            // btPesquisarT
            // 
            this.btPesquisarT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btPesquisarT.Location = new System.Drawing.Point(445, 406);
            this.btPesquisarT.Name = "btPesquisarT";
            this.btPesquisarT.Size = new System.Drawing.Size(161, 49);
            this.btPesquisarT.TabIndex = 5;
            this.btPesquisarT.Text = "Pesquisar";
            this.btPesquisarT.UseVisualStyleBackColor = false;
            this.btPesquisarT.Click += new System.EventHandler(this.btPesquisarT_Click);
            // 
            // btSalvarT
            // 
            this.btSalvarT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btSalvarT.Location = new System.Drawing.Point(258, 338);
            this.btSalvarT.Name = "btSalvarT";
            this.btSalvarT.Size = new System.Drawing.Size(161, 49);
            this.btSalvarT.TabIndex = 6;
            this.btSalvarT.Text = "Salvar";
            this.btSalvarT.UseVisualStyleBackColor = false;
            this.btSalvarT.Click += new System.EventHandler(this.btSalvarT_Click);
            // 
            // btRemoverT
            // 
            this.btRemoverT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btRemoverT.Location = new System.Drawing.Point(445, 338);
            this.btRemoverT.Name = "btRemoverT";
            this.btRemoverT.Size = new System.Drawing.Size(161, 49);
            this.btRemoverT.TabIndex = 7;
            this.btRemoverT.Text = "Remover";
            this.btRemoverT.UseVisualStyleBackColor = false;
            this.btRemoverT.Click += new System.EventHandler(this.btRemoverT_Click);
            // 
            // cbLiv
            // 
            this.cbLiv.DisplayMember = "Nome";
            this.cbLiv.FormattingEnabled = true;
            this.cbLiv.Location = new System.Drawing.Point(467, 266);
            this.cbLiv.Name = "cbLiv";
            this.cbLiv.Size = new System.Drawing.Size(255, 24);
            this.cbLiv.TabIndex = 8;
            this.cbLiv.ValueMember = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(583, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "+";
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(-2, -4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(230, 501);
            this.pb1.TabIndex = 14;
            this.pb1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cadastrar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(253, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome Do Autor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(253, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome Do Livro :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(363, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 54);
            this.label6.TabIndex = 21;
            this.label6.Text = "Autor Do Livro";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btVoltar.Location = new System.Drawing.Point(643, 448);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(115, 35);
            this.btVoltar.TabIndex = 22;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btLimparAT
            // 
            this.btLimparAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btLimparAT.Location = new System.Drawing.Point(258, 406);
            this.btLimparAT.Name = "btLimparAT";
            this.btLimparAT.Size = new System.Drawing.Size(161, 49);
            this.btLimparAT.TabIndex = 23;
            this.btLimparAT.Text = "Limpar";
            this.btLimparAT.UseVisualStyleBackColor = false;
            this.btLimparAT.Click += new System.EventHandler(this.btLimparAT_Click);
            // 
            // frmCadastroAutLiv
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(770, 495);
            this.Controls.Add(this.btLimparAT);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbLiv);
            this.Controls.Add(this.cbAut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btRemoverT);
            this.Controls.Add(this.btSalvarT);
            this.Controls.Add(this.btPesquisarT);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.MaximizeBox = false;
            this.Name = "frmCadastroAutLiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroAutLiv";
            this.Load += new System.EventHandler(this.frmCadastroAutLiv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbAut;
        private System.Windows.Forms.Button btPesquisarT;
        private System.Windows.Forms.Button btSalvarT;
        private System.Windows.Forms.Button btRemoverT;
        private System.Windows.Forms.ComboBox cbLiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btLimparAT;
    }
}