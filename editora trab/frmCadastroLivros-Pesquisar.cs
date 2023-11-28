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
    public partial class frmCadastroLivros_Pesquisar : Form
    {
        public frmCadastroLivros_Pesquisar()
        {
            InitializeComponent();
        }

        public LivrosModel livros;
        public LivrosDal livrosDal;

        public void carregarGrid()
        {
            dgLivros.DataSource = livrosDal.listarTodosArray();
        }

        private void selecionarItem()
        {
            int i = 0;

            i = dgLivros.CurrentRow.Index;
            livros.Codigo = int.Parse(dgLivros[0, i].Value.ToString());
            livros.Nome = dgLivros[1, i].Value.ToString();
            livros.AnoPu = int.Parse(dgLivros[2, i].Value.ToString());
            livros.ISBN = int.Parse(dgLivros[3, i].Value.ToString());
            livros.Observacoes = dgLivros[4, i].Value.ToString();
            livros.CodigoEDi = int.Parse(dgLivros[5, i].Value.ToString());
        }

        private void frmCadastroLivros_Pesquisar_Load(object sender, EventArgs e)
        {
            this.livros = new LivrosModel();
            this.livrosDal = new LivrosDal();
            this.carregarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }

        private void dgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btVoltarLiv_Click(object sender, EventArgs e)
        {
            this.livros.Codigo = 0;
            this.Close();
        }
    }
}
