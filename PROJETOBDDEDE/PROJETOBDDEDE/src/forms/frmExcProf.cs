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
    public partial class frmExcProf : Form
    {
        Form1 frm1 = new Form1();

        SchoolManagerDataSetTableAdapters.ProfessorTableAdapter profTA = new SchoolManagerDataSetTableAdapters.ProfessorTableAdapter();
        public frmExcProf()
        {
            InitializeComponent();
        }

        private void btn_EXC_Click(object sender, EventArgs e)
        {
            try
            {
                profTA.ExcProf(txt_CPF.Text);

                MessageBox.Show("Tem certeza que deseja excluir o professor?", "", MessageBoxButtons.YesNo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir professor! Erro:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
