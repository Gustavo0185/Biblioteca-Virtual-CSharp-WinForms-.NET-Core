namespace Login
{
    partial class Form1
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
            this.btLimparLogin = new System.Windows.Forms.Button();
            this.btCadastre = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLimparLogin
            // 
            this.btLimparLogin.Location = new System.Drawing.Point(217, 189);
            this.btLimparLogin.Name = "btLimparLogin";
            this.btLimparLogin.Size = new System.Drawing.Size(107, 30);
            this.btLimparLogin.TabIndex = 16;
            this.btLimparLogin.Text = "Limpar";
            this.btLimparLogin.UseVisualStyleBackColor = true;
            // 
            // btCadastre
            // 
            this.btCadastre.Location = new System.Drawing.Point(148, 225);
            this.btCadastre.Name = "btCadastre";
            this.btCadastre.Size = new System.Drawing.Size(107, 35);
            this.btCadastre.TabIndex = 15;
            this.btCadastre.Text = "Cadasre-se";
            this.btCadastre.UseVisualStyleBackColor = true;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(87, 146);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(237, 22);
            this.tbSenha.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(87, 101);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(237, 22);
            this.tbUsuario.TabIndex = 10;
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(87, 189);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(107, 30);
            this.btEntrar.TabIndex = 9;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 317);
            this.Controls.Add(this.btLimparLogin);
            this.Controls.Add(this.btCadastre);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btEntrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimparLogin;
        private System.Windows.Forms.Button btCadastre;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button btEntrar;
    }
}

