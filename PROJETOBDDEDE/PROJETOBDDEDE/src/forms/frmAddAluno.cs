using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace PROJETOBDDEDE
{
    public partial class frmAddAluno : Form
    {
        SchoolManagerDataSetTableAdapters.AlunoTableAdapter AlunoTA = new SchoolManagerDataSetTableAdapters.AlunoTableAdapter();

        public frmAddAluno()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoTA.AddAluno(
                    txt_RA.Text,
                    txt_RM.Text,
                    txt_Classe.Text,
                    textBox1.Text,
                    txt_Email.Text,
                    txt_Nome.Text,
                    dt_DataNasc.Value,
                    txt_Resp.Text,
                    txt_Resp2.Text);

                MessageBox.Show("Aluno Cadastrado com Sucesso! :)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno! Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
