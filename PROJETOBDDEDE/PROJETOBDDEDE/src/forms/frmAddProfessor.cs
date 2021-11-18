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
    public partial class frmAddProf : Form
    {
        SchoolManagerDataSetTableAdapters.ProfessorTableAdapter ProfTA = new SchoolManagerDataSetTableAdapters.ProfessorTableAdapter();

        public frmAddProf()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                ProfTA.Addprof(msk_Cpf.Text, txt_Nome.Text, txt_ClasseResp.Text, msk_txt_Tel.Text, txt_Email.Text, txt_Materia.Text);
                MessageBox.Show("Professor Cadastrado!", "", MessageBoxButtons.OK);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível adicionar o professor! Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
