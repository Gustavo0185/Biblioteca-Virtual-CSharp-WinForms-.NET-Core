using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using cldal;
using clmodel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace editora_trab
{
    public partial class frmLogin : Form
    {
        private LoginDal loginDal = new LoginDal();
        public string tbUsuario1;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLimparLogin_Click(object sender, EventArgs e)
        {
            tbSenha.Clear();
            tbUsuario.Clear();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string usuario1 = tbUsuario.Text;
            string senha1 = tbSenha.Text;

            bool achou = loginDal.ObterUsriario(usuario1, senha1);

            if (!achou)
            {
                MessageBox.Show("Não existe este usuario.");
                return;
            }
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }
        private void btCadastre_Click(object sender, EventArgs e)
        {
            frmLoginCadastro frmLoginCadastro = new frmLoginCadastro();
            frmLoginCadastro.ShowDialog();
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbSenha.PasswordChar = '*';
        }
    }
    }

