using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using clmodel;
using cldal;

namespace editora_trab
{
    public partial class frmCadastroLivros : Form
    {

        private EditorasDal editorasDal;


        private void carregarComboEditoras()
        {
            cbEDI.DataSource = editorasDal.listarTodosArray();
        }

        public frmCadastroLivros()
        {
            InitializeComponent();
  

        }

        private void LimparTela()
        {
            tbAnoPuLivros.Clear();
            tbCodigoLivros.Clear();
            tbISBN.Clear();
            tbNomeLivros.Clear();
            tbObsLivros.Clear();
        }
        private void frmCadastroLivros_Load(object sender, EventArgs e)
        {
            editorasDal = new EditorasDal();
            carregarComboEditoras();

        }

        private void btPesquisarLivros_Click(object sender, EventArgs e)
        {
            frmCadastroLivros_Pesquisar frm = new frmCadastroLivros_Pesquisar();
            frm.ShowDialog();



            if (frm.livros.Codigo > 0)
            {
                tbCodigoLivros.Text = frm.livros.Codigo.ToString();
                tbNomeLivros.Text = frm.livros.Nome.ToString();
                tbAnoPuLivros.Text = frm.livros.AnoPu.ToString();
                tbISBN.Text = frm.livros.ISBN.ToString();
                tbObsLivros.Text = frm.livros.Observacoes.ToString();
                


            }
        }

        private void btLimparLivros_Click(object sender, EventArgs e)
        {
            LimparTela();
            
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            LivrosModel livro = new LivrosModel();
            LivrosDal livroDal = new LivrosDal();
            int resultado = int.Parse(cbEDI.SelectedValue.ToString());

            if (tbCodigoLivros.Text.Trim() == String.Empty)
                {


                    livro.Codigo = 0;
                    livro.Nome = tbNomeLivros.Text.Trim();
                    livro.AnoPu = int.Parse(tbAnoPuLivros.Text.Trim());
                    livro.ISBN = int.Parse(tbISBN.Text.Trim());
                    livro.Observacoes = tbObsLivros.Text.Trim();
                    livro.CodigoEDi = resultado;

                    livroDal.inserirL(livro);
                    MessageBox.Show("Registro inserido com sucesso!");
                    LimparTela();

                }
                else
                {
                    livro.Codigo = int.Parse(tbCodigoLivros.Text.Trim());
                    livro.Nome = tbNomeLivros.Text.Trim();
                    livro.AnoPu = int.Parse(tbAnoPuLivros.Text.Trim());
                    livro.ISBN = int.Parse(tbISBN.Text.Trim());
                    livro.Observacoes = tbObsLivros.Text.Trim();
                    livro.CodigoEDi = resultado;

                    livroDal.atualizarL(livro);
                    MessageBox.Show("Registro Atualizado com sucesso!");
                    LimparTela();
                }
           
        }

        private void cbEDI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btRemoverLivros_Click(object sender, EventArgs e)
        {
            LivrosDal livroDal = new LivrosDal();


            try
            {
                if (tbCodigoLivros.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Selecione um registro para ser removido!");
                }
                else
                {
                    livroDal.excluirL(int.Parse(tbCodigoLivros.Text.Trim()));
                    MessageBox.Show("Registro Excluido com sucesso!");
                    LimparTela();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void tbObsLivros_TextChanged(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
