namespace editora_trab
{
    partial class frmCadastroAutores_Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAutores_Pesquisar));
            this.btVoltar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.dgAutores = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pseu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btVoltar.Location = new System.Drawing.Point(828, 445);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(109, 38);
            this.btVoltar.TabIndex = 6;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btSelecionar.Location = new System.Drawing.Point(500, 384);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(188, 51);
            this.btSelecionar.TabIndex = 5;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // dgAutores
            // 
            this.dgAutores.AllowUserToAddRows = false;
            this.dgAutores.AllowUserToDeleteRows = false;
            this.dgAutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.dgAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Pseu,
            this.Observacoes});
            this.dgAutores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgAutores.Location = new System.Drawing.Point(261, 94);
            this.dgAutores.Name = "dgAutores";
            this.dgAutores.ReadOnly = true;
            this.dgAutores.RowHeadersWidth = 51;
            this.dgAutores.RowTemplate.Height = 24;
            this.dgAutores.Size = new System.Drawing.Size(649, 271);
            this.dgAutores.TabIndex = 4;
            this.dgAutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAutores_CellContentClick);
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
            this.Codigo.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 130;
            // 
            // Pseu
            // 
            this.Pseu.DataPropertyName = "Pseu";
            this.Pseu.HeaderText = "Pseudonimo";
            this.Pseu.MinimumWidth = 6;
            this.Pseu.Name = "Pseu";
            this.Pseu.ReadOnly = true;
            this.Pseu.Width = 140;
            // 
            // Observacoes
            // 
            this.Observacoes.DataPropertyName = "Observacoes";
            this.Observacoes.HeaderText = "Observacoes";
            this.Observacoes.MinimumWidth = 6;
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.ReadOnly = true;
            this.Observacoes.Width = 200;
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(0, -3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(230, 501);
            this.pb1.TabIndex = 14;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(252, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 54);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pesquisa Autores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastroAutores_Pesquisar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(949, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.dgAutores);
            this.MaximizeBox = false;
            this.Name = "frmCadastroAutores_Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Pesquisar Autores ::..";
            this.Load += new System.EventHandler(this.frmCadastroAutores_Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DataGridView dgAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pseu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
    }
}