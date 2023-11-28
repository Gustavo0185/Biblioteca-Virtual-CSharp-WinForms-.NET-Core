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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEditoras frmEdi = new frmCadastroEditoras();
            frmEdi.ShowDialog();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroLivros frmLiv = new frmCadastroLivros();
            frmLiv.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAutores frmAut = new frmCadastroAutores();
            frmAut.ShowDialog();
        }

        private void autoresLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAutLiv frmAutLiv = new frmCadastroAutLiv();
            frmAutLiv.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroEditoras frm = new frmCadastroEditoras();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCadastroLivros frm1 = new frmCadastroLivros();
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastroAutores frm2 = new frmCadastroAutores();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastroAutLiv frm3 = new frmCadastroAutLiv();
            frm3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmInfo frm = new frmInfo();
            frm.Show();
        }
    }
}
