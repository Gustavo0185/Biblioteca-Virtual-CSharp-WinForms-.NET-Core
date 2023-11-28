namespace editora_trab
{
    partial class frmCadastroLivros_Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroLivros_Pesquisar));
            this.btVoltarLiv = new System.Windows.Forms.Button();
            this.btSelecionarLiv = new System.Windows.Forms.Button();
            this.dgLivros = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoPu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoEdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarLiv
            // 
            this.btVoltarLiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btVoltarLiv.Location = new System.Drawing.Point(958, 444);
            this.btVoltarLiv.Name = "btVoltarLiv";
            this.btVoltarLiv.Size = new System.Drawing.Size(111, 39);
            this.btVoltarLiv.TabIndex = 6;
            this.btVoltarLiv.Text = "Voltar";
            this.btVoltarLiv.UseVisualStyleBackColor = false;
            this.btVoltarLiv.Click += new System.EventHandler(this.btVoltarLiv_Click);
            // 
            // btSelecionarLiv
            // 
            this.btSelecionarLiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btSelecionarLiv.Location = new System.Drawing.Point(580, 387);
            this.btSelecionarLiv.Name = "btSelecionarLiv";
            this.btSelecionarLiv.Size = new System.Drawing.Size(153, 49);
            this.btSelecionarLiv.TabIndex = 5;
            this.btSelecionarLiv.Text = "Selecionar";
            this.btSelecionarLiv.UseVisualStyleBackColor = false;
            this.btSelecionarLiv.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // dgLivros
            // 
            this.dgLivros.AllowUserToAddRows = false;
            this.dgLivros.AllowUserToDeleteRows = false;
            this.dgLivros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.dgLivros.ColumnHeadersHeight = 29;
            this.dgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.AnoPu,
            this.ISBN,
            this.Observacoes,
            this.CodigoEdi});
            this.dgLivros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgLivros.Location = new System.Drawing.Point(240, 99);
            this.dgLivros.Name = "dgLivros";
            this.dgLivros.ReadOnly = true;
            this.dgLivros.RowHeadersWidth = 51;
            this.dgLivros.RowTemplate.Height = 24;
            this.dgLivros.Size = new System.Drawing.Size(829, 271);
            this.dgLivros.TabIndex = 4;
            this.dgLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLivros_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.FillWeight = 300F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 85;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 135;
            // 
            // AnoPu
            // 
            this.AnoPu.DataPropertyName = "AnoPu";
            this.AnoPu.HeaderText = "Ano Publicação";
            this.AnoPu.MinimumWidth = 6;
            this.AnoPu.Name = "AnoPu";
            this.AnoPu.ReadOnly = true;
            this.AnoPu.Width = 120;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 130;
            // 
            // Observacoes
            // 
            this.Observacoes.DataPropertyName = "Observacoes";
            this.Observacoes.HeaderText = "Observacoes";
            this.Observacoes.MinimumWidth = 6;
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.ReadOnly = true;
            this.Observacoes.Width = 160;
            // 
            // CodigoEdi
            // 
            this.CodigoEdi.DataPropertyName = "CodigoEdi";
            this.CodigoEdi.HeaderText = "CodigoEdi";
            this.CodigoEdi.MinimumWidth = 6;
            this.CodigoEdi.Name = "CodigoEdi";
            this.CodigoEdi.ReadOnly = true;
            this.CodigoEdi.Width = 80;
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(-7, -4);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(230, 507);
            this.pb1.TabIndex = 14;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(229, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 54);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pesquisa Livros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastroLivros_Pesquisar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1081, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btVoltarLiv);
            this.Controls.Add(this.btSelecionarLiv);
            this.Controls.Add(this.dgLivros);
            this.MaximizeBox = false;
            this.Name = "frmCadastroLivros_Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Cadastro Livros ::..";
            this.Load += new System.EventHandler(this.frmCadastroLivros_Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltarLiv;
        private System.Windows.Forms.Button btSelecionarLiv;
        private System.Windows.Forms.DataGridView dgLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoPu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoEdi;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
    }
}