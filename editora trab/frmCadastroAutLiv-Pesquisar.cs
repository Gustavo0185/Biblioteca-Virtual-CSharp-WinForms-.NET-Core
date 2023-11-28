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
    public partial class frmCadastroAutLiv_Pesquisar : Form
    {
        public frmCadastroAutLiv_Pesquisar()
        {
            InitializeComponent();
        }

        public AutLivModel autliv;
        public AutLivDal autlivDal;

        private void carregarGrid()
        {
            dgAutLiv.DataSource = autlivDal.listarTodosArray();

        }

        private void selecionarItem()
        {
            int i = 0;

            i = dgAutLiv.CurrentRow.Index;
            autliv.CodAut = int.Parse(dgAutLiv[0, i].Value.ToString());
            autliv.CodLiv = int.Parse(dgAutLiv[1, i].Value.ToString());

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.autliv.CodAut = 0;
            this.Close();
        }

        private void frmCadastroAutLiv_Pesquisar_Load(object sender, EventArgs e)
        {
            this.autliv = new AutLivModel();
            this.autlivDal = new AutLivDal();
            this.carregarGrid();

        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            this.selecionarItem();
            this.Close();
        }
    }
}
