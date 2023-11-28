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
    public partial class frmCadastroEditoras : Form
    {

        private void LimparTela()
        {
            tbCodigoEditora.Clear();
            tbNomeEditora.Clear();
            tbSiglaEditora.Clear();
            tbObservacoesEdi.Clear();
        }

        public frmCadastroEditoras()
        {
            InitializeComponent();
        }


        
        private void btPesquisarEditoras_Click(object sender, EventArgs e)
        {
            frmCadastroEeditoras_Pesquisar frm = new frmCadastroEeditoras_Pesquisar();
            frm.ShowDialog();

            if(frm.editora.Codigo > 0)
            {
                tbCodigoEditora.Text = frm.editora.Codigo.ToString();
                tbNomeEditora.Text = frm.editora.Nome.ToString();
                tbSiglaEditora.Text = frm.editora.Sigla.ToString();
                tbObservacoesEdi.Text = frm.editora.Observacoes.ToString();

            }

        }

        private void btRemoverEditoras_Click(object sender, EventArgs e)
        {

            EditorasDal editorasDal = new EditorasDal();


            try
            {
                if(tbCodigoEditora.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Selecione um registro para ser removido!");
                }
                else
                {
                    editorasDal.excluir(int.Parse(tbCodigoEditora.Text.Trim()));
                    MessageBox.Show("Registro Excluido com sucesso!");
                    LimparTela();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbNomeEditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSiglaEditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbObservacoesEdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCodigoEditora_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLimparEditoras_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btSalvarEditoras_Click(object sender, EventArgs e)
        {
            EditorasModel editora = new EditorasModel();
            EditorasDal editorasDal = new EditorasDal();

            try
            {
                if ( tbCodigoEditora.Text.Trim () == String.Empty)
                {
                    editora.Codigo = 0;
                    editora.Nome = tbNomeEditora.Text.Trim();
                    editora.Sigla = tbSiglaEditora.Text.Trim();
                    editora.Observacoes = tbObservacoesEdi.Text.Trim();

                    editorasDal.inserir(editora);
                    MessageBox.Show("Registro inserido com sucesso!");
                    LimparTela();
                    
                }
                else
                {
                    editora.Codigo = int.Parse(tbCodigoEditora.Text.Trim());
                    editora.Nome = tbNomeEditora.Text.Trim();
                    editora.Sigla = tbSiglaEditora.Text.Trim();
                    editora.Observacoes = tbObservacoesEdi.Text.Trim();

                    editorasDal.atualizar(editora);
                    MessageBox.Show("Registro Atualizado com sucesso!");
                    LimparTela();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmCadastroEditoras_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
