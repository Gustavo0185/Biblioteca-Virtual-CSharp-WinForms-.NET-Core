using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using editora_trab;

namespace Login
{
    public partial class Form1 : Form
    {
        SqlConnection Conexao = new SqlConnection("Data Source=GABRIELLE\\SQLEXPRESS; Initial Catalog=db_SisEditoras;Integrated Security=true;");

        public Form1()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                Conexao.Open();
                string query = "SELECT * FROM Usuarios WHERE Username = '" + tbUsuario + "' AND Password = '" + tbSenha + "' ";
                SqlConnection connection = new SqlConnection();

                SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    frmPrincipal principal = new frmPrincipal();
                    this.Hide();
                    principal.Show();
                    

                }
                else
                {
                    MessageBox.Show("Usuario ou Senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSenha.Text = "";
                    tbUsuario.Text = "";
                }

                Conexao.Close();
            }
            catch ( Exception ex)
            {
                throw;
            }
        }
    }
}
