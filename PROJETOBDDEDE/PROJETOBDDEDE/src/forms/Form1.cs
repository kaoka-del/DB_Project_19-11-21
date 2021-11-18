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
    public partial class Form1 : Form 
    {
        frmAddAluno frmAddAluno = new frmAddAluno();
        frmAddProf frmAddProf = new frmAddProf();
        /* frmExcAluno frmExcAluno = new frmExcAluno();
         frmExcProf frmExcProf = new frmExcProf();*/

        private void invisibleGroup(GroupBox x)
        {
            x.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        //////// CADASTRAR ///////
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            gp_Cadastro.Visible = true;

            invisibleGroup(gp_EXC);
            invisibleGroup(gp_Mod);
            invisibleGroup(gp_Visu);
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            frmAddAluno.ShowDialog();
        }
        
        private void btnCadProf_Click(object sender, EventArgs e)
        {
            frmAddProf.ShowDialog();
        }
        /////////////////////////////////////

        //////// Excluir ///////
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            gp_EXC.Visible = true;

            invisibleGroup(gp_Cadastro);
            invisibleGroup(gp_Mod);
            invisibleGroup(gp_Visu);
        }

        private void btn_exc_Aluno_Click(object sender, EventArgs e)
        {
           // frmExcAluno.ShowDialog();
        }

        private void btn_exc_Prof_Click(object sender, EventArgs e)
        {
           // frmExcProf.ShowDialog();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            new src.forms.frmViewAluno().ShowDialog(); 
        }

        /////////////////////////////////////
    }
}

