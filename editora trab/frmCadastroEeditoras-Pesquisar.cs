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
using System.Data.SqlClient;

using cldal;
using clmodel;

namespace editora_trab
{
    public partial class frmCadastroEeditoras_Pesquisar : Form
    {
        public frmCadastroEeditoras_Pesquisar()
        {
            InitializeComponent();
        }

        public EditorasModel editora;
        public EditorasDal editoraDal;

        private void carregarGrid()
        {
            dgEditoras.DataSource = editoraDal.listarTodosArray();
 
        }

        private void selecionarItem()
        {
            int i = 0;

            i = dgEditoras.CurrentRow.Index;
            editora.Codigo = int.Parse(dgEditoras[0, i].Value.ToString());
            editora.Nome = dgEditoras[1, i].Value.ToString();
            editora.Sigla = dgEditoras[2, i].Value.ToString();
            editora.Observacoes = dgEditoras[3, i].Value.ToString();
        }

        private void frmCadastroEeditoras_Pesquisar_Load(object sender, EventArgs e)
        {
            this.editora = new EditorasModel();
            this.editoraDal = new EditorasDal();
            this.carregarGrid();

    
        }


        private void btSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.editora.Codigo = 0;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
