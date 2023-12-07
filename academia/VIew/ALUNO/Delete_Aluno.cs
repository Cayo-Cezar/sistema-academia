using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using WillFit_System.Data;

namespace WillFit_System.VIew.ALUNO
{
    public partial class Delete_Aluno : Form
    {
        public Delete_Aluno()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_aluno_Click(object sender, EventArgs e)
        {
            GMYContext db = new GMYContext();

            string pesqu;
            pesqu = txb_cpf_delete_aluno.Text;


            var alunos = db.Alunos.Where(a => a.name.Contains(pesqu)).ToList();

            dataGridView1.DataSource = alunos;
            // db.Alunos.Find(lbl_delete_aluno);


        }

        private void btn_deletar_aluno_Click(object sender, EventArgs e)
        {
            GMYContext db = new GMYContext();

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["_matricula"].Value);

                var aluno = db.Alunos.Where(a => a.matricula.Contains(cellValue)).First();



                db.Alunos.Where(a => a.matricula == cellValue).ExecuteDelete();
                db.SaveChanges();

                MessageBox.Show("Aluno Deletado Com Sucesso !");

                  
            }


        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
