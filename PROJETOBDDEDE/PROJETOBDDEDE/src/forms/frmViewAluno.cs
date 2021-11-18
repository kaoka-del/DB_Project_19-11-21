using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOBDDEDE.src.forms
{
    public partial class frmViewAluno : Form
    {
        SchoolManagerDataSetTableAdapters.AlunoTableAdapter KOKO = new SchoolManagerDataSetTableAdapters.AlunoTableAdapter();
        public frmViewAluno()
        {
            InitializeComponent();
        }

        private void frmViewAluno_Load(object sender, EventArgs e)
        {
            DataGV_Main.DataSource = KOKO.get_alunos();
        }
    }
}
