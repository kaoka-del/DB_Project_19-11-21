using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOBDDEDE
{
    public partial class frmExcAluno : Form
    {
 
        SchoolManagerDataSetTableAdapters.AlunoTableAdapter alunoTA = new SchoolManagerDataSetTableAdapters.AlunoTableAdapter();

        public frmExcAluno()
        {
            InitializeComponent();
        }

        private void btn_EXC_Click(object sender, EventArgs e)
        {
            try {
                alunoTA.excluirAluno(txt_Ra.Text);

                MessageBox.Show("Tem certeza que deseja excluir o aluno?", "", MessageBoxButtons.YesNo);
            }

            catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir aluno! Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
