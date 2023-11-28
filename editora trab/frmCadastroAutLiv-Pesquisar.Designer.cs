namespace editora_trab
{
    partial class frmCadastroAutLiv_Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAutLiv_Pesquisar));
            this.btVoltar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.dgAutLiv = new System.Windows.Forms.DataGridView();
            this.CodAut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodLiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutLiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btVoltar.Location = new System.Drawing.Point(662, 453);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(96, 30);
            this.btVoltar.TabIndex = 10;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.btSelecionar.Location = new System.Drawing.Point(400, 375);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(171, 53);
            this.btSelecionar.TabIndex = 9;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // dgAutLiv
            // 
            this.dgAutLiv.AllowUserToAddRows = false;
            this.dgAutLiv.AllowUserToDeleteRows = false;
            this.dgAutLiv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(217)))));
            this.dgAutLiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutLiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodAut,
            this.CodLiv});
            this.dgAutLiv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgAutLiv.Enabled = false;
            this.dgAutLiv.Location = new System.Drawing.Point(243, 98);
            this.dgAutLiv.Name = "dgAutLiv";
            this.dgAutLiv.ReadOnly = true;
            this.dgAutLiv.RowHeadersWidth = 51;
            this.dgAutLiv.RowTemplate.Height = 24;
            this.dgAutLiv.Size = new System.Drawing.Size(499, 271);
            this.dgAutLiv.TabIndex = 8;
            // 
            // CodAut
            // 
            this.CodAut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodAut.DataPropertyName = "CodAut";
            this.CodAut.FillWeight = 300F;
            this.CodAut.HeaderText = "Codigo Autor";
            this.CodAut.MinimumWidth = 6;
            this.CodAut.Name = "CodAut";
            this.CodAut.ReadOnly = true;
            this.CodAut.Width = 125;
            // 
            // CodLiv
            // 
            this.CodLiv.DataPropertyName = "CodLiv";
            this.CodLiv.HeaderText = "Codigo Livro";
            this.CodLiv.MinimumWidth = 6;
            this.CodLiv.Name = "CodLiv";
            this.CodLiv.ReadOnly = true;
            this.CodLiv.Width = 130;
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(-2, -3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(230, 501);
            this.pb1.TabIndex = 15;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(96)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(234, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 54);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pesquisa Autores/Livros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastroAutLiv_Pesquisar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(770, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.dgAutLiv);
            this.MaximizeBox = false;
            this.Name = "frmCadastroAutLiv_Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroAutLiv_Pesquisar";
            this.Load += new System.EventHandler(this.frmCadastroAutLiv_Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAutLiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DataGridView dgAutLiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodAut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodLiv;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
    }
}