namespace editora_trab
{
    partial class frmCadastroEeditoras_Pesquisar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEeditoras_Pesquisar));
            this.dgEditoras = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEditoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEditoras
            // 
            this.dgEditoras.AllowUserToAddRows = false;
            this.dgEditoras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.dgEditoras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEditoras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.dgEditoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEditoras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEditoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Sigla,
            this.Observacoes});
            this.dgEditoras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgEditoras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(207)))), ((int)(((byte)(196)))));
            this.dgEditoras.Location = new System.Drawing.Point(245, 99);
            this.dgEditoras.Name = "dgEditoras";
            this.dgEditoras.ReadOnly = true;
            this.dgEditoras.RowHeadersWidth = 51;
            this.dgEditoras.RowTemplate.Height = 24;
            this.dgEditoras.Size = new System.Drawing.Size(672, 233);
            this.dgEditoras.TabIndex = 0;
            this.dgEditoras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Sigla
            // 
            this.Sigla.DataPropertyName = "Sigla";
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.MinimumWidth = 6;
            this.Sigla.Name = "Sigla";
            this.Sigla.ReadOnly = true;
            this.Sigla.Width = 140;
            // 
            // Observacoes
            // 
            this.Observacoes.DataPropertyName = "Observacoes";
            this.Observacoes.HeaderText = "Observacao";
            this.Observacoes.MinimumWidth = 6;
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.ReadOnly = true;
            this.Observacoes.Width = 200;
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btSelecionar.Location = new System.Drawing.Point(507, 350);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(140, 52);
            this.btSelecionar.TabIndex = 1;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btVoltar.Location = new System.Drawing.Point(802, 446);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(115, 35);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(-2, -2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(230, 501);
            this.pb1.TabIndex = 13;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(247, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 54);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pesquisa Editoras";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastroEeditoras_Pesquisar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(928, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.dgEditoras);
            this.MaximizeBox = false;
            this.Name = "frmCadastroEeditoras_Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroEeditoras - Pesquisar";
            this.Load += new System.EventHandler(this.frmCadastroEeditoras_Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEditoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEditoras;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
    }
}