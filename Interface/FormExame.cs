using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace Interface
{
    public partial class frmExame : Form
    {
        public frmExame()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtID.Text);
            DateTime dataExame = Convert.ToDateTime(mskDataExame.Text);
            int glicemia = Convert.ToInt16(txtGlicemia.Text);
            int dosePrincipal = Convert.ToInt16(nmrDosePrincipal.Value);
            int doseSecundaria = Convert.ToInt16(nmrDoseSecundaria.Value);

            Exam exam = new Exam(id, dataExame, glicemia, dosePrincipal, doseSecundaria);

            try
            {
                exam.NewExam();
                MessageBox.Show("Resultado cadastrado com sucesso!", "Glicontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception error)
            {
                MessageBox.Show("Erro: " + error);
            }
        }

        private void frmExame_Load(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            txtID.Text = Convert.ToString(exam.ShowNextId());
            mskDataExame.Text = Convert.ToString(DateTime.Now);
        }
    }
}
