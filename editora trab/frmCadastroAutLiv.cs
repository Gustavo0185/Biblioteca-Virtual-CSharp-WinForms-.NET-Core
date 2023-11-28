using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cldal;
using clmodel;

namespace editora_trab
{
    public partial class frmCadastroAutLiv : Form
    {

        private AutoresDal autoresDal;
        private LivrosDal livrosDal;

        private void carregarComboAut()
        {
            cbAut.DataSource = autoresDal.listarTodosArray();
        }

        private void carregarComboLiv()
        {
            cbLiv.DataSource = livrosDal.listarTodosArray();
        }

        public frmCadastroAutLiv()
        {
            InitializeComponent();
        }

        public void frmCadastroAutLiv_Load(object sender, EventArgs e)
        {
            autoresDal = new AutoresDal();
            livrosDal = new LivrosDal();
            carregarComboAut();
            carregarComboLiv();

        }

        private void btPesquisarT_Click(object sender, EventArgs e)
        {
            frmCadastroAutLiv_Pesquisar frm = new frmCadastroAutLiv_Pesquisar();
            frm.Show();


        }

        private void btSalvarT_Click(object sender, EventArgs e)
        {
            AutLivModel autliv = new AutLivModel();
            AutLivDal autlivDal = new AutLivDal();
            int resultado = int.Parse(cbAut.SelectedValue.ToString());
            int resultado1 = int.Parse(cbLiv.SelectedValue.ToString());



            autliv.CodAut = resultado;
            autliv.CodLiv = resultado1;

            autlivDal.inserir(autliv);
            MessageBox.Show("Registro inserido com sucesso!");
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimparAT_Click(object sender, EventArgs e)
        {
            cbAut = null;
        }

        private void btRemoverT_Click(object sender, EventArgs e)
        {
            AutLivDal AutLDal = new AutLivDal();
            int resultado = int.Parse(cbAut.SelectedValue.ToString());
            int resultado1 = int.Parse(cbLiv.SelectedValue.ToString());

            try
            {

                    AutLDal.excluir(resultado);
                    MessageBox.Show("Registro Excluido com sucesso!");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

