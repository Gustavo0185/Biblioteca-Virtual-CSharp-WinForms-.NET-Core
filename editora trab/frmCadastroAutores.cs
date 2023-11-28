using cldal;
using clmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editora_trab
{
    public partial class frmCadastroAutores : Form
    {
        public frmCadastroAutores()
        {
            InitializeComponent();
        }

        

        private void LimparTela()
        {
            tbCodigoAutores.Clear();
            tbNomeAutores.Clear();
            tbPseudonimo.Clear();
            tbObservacoesAutores.Clear();
        }
        private void btLimparAutores_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btSalvarAutores_Click(object sender, EventArgs e)
        {
            AutoresModel autores = new AutoresModel();
            AutoresDal autoresDal = new AutoresDal();

            try
            {
                if (tbCodigoAutores.Text.Trim() == String.Empty)
                {
                    autores.Codigo = 0;
                    autores.Nome = tbNomeAutores.Text.Trim();
                    autores.Pseu = tbPseudonimo.Text.Trim();
                    autores.Observacoes = tbObservacoesAutores.Text.Trim();

                    autoresDal.inserir(autores);
                    MessageBox.Show("Registro inserido com sucesso!");
                    LimparTela();

                }
                else
                {
                    autores.Codigo = int.Parse(tbCodigoAutores.Text.Trim());
                    autores.Nome = tbNomeAutores.Text.Trim();
                    autores.Pseu = tbPseudonimo.Text.Trim();
                    autores.Observacoes = tbObservacoesAutores.Text.Trim();

                    autoresDal.atualizar(autores);
                    MessageBox.Show("Registro Atualizado com sucesso!");
                    LimparTela();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btRemoverAutores_Click(object sender, EventArgs e)
        {
            AutoresDal autoresDal = new AutoresDal();


            try
            {
                if (tbCodigoAutores.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Selecione um registro para ser removido!");
                }
                else
                {
                    autoresDal.excluir(int.Parse(tbCodigoAutores.Text.Trim()));
                    MessageBox.Show("Registro Excluido com sucesso!");
                    LimparTela();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btPesquisarAutores_Click(object sender, EventArgs e)
        {
            frmCadastroAutores_Pesquisar frmu = new frmCadastroAutores_Pesquisar();
            frmu.ShowDialog();

            if (frmu.autores.Codigo > 0)
            {
                tbCodigoAutores.Text = frmu.autores.Codigo.ToString();
                tbNomeAutores.Text = frmu.autores.Nome.ToString();
                tbPseudonimo.Text = frmu.autores.Pseu.ToString();
                tbObservacoesAutores.Text = frmu.autores.Observacoes.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
