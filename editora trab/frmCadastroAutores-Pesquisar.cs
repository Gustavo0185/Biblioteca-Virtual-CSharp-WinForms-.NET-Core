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
    public partial class frmCadastroAutores_Pesquisar : Form
    {
        public frmCadastroAutores_Pesquisar()
        {
            InitializeComponent();
        }

        public AutoresModel autores;
        public AutoresDal autoresDal;

        private void carregarGrid()
        {
            dgAutores.DataSource = autoresDal.listarTodosArray();

        }

        private void selecionarItem()
        {
            int i = 0;

            i = dgAutores.CurrentRow.Index;
            autores.Codigo = int.Parse(dgAutores[0, i].Value.ToString());
            autores.Nome = dgAutores[1, i].Value.ToString();
            autores.Pseu = dgAutores[2, i].Value.ToString();
            autores.Observacoes = dgAutores[3, i].Value.ToString();
        }
        private void btSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }

        private void frmCadastroAutores_Pesquisar_Load(object sender, EventArgs e)
        {
            this.autores = new AutoresModel();
            this.autoresDal = new AutoresDal();
            this.carregarGrid();

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.autores.Codigo = 0;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
