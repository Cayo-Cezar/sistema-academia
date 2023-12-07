using WillFit_System.Data;

namespace WillFit_System.VIew.ALUNO
{
    public partial class Get_Aluno : Form
    {
        public Get_Aluno()
        {
            InitializeComponent();
        }

        private void btn_pesq_delete_aluno_Click(object sender, EventArgs e)
        {
            GMYContext db = new GMYContext();

            string? pesqu = label1.Text;

            try
            {


                var alunos = db.Alunos.ToList();

                dataGridView1.DataSource = alunos;


            }
            catch (Exception ex) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_voltar_Aluno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
