using WillFit_System.Data;

namespace WillFit_System.VIew.Professor
{
    public partial class Get_Professores : Form
    {
        public Get_Professores()
        {
            InitializeComponent();
        }

        private void btn_consulta_prof_Click(object sender, EventArgs e)
        {

            try
            {

                GMYContext db = new GMYContext();


                var prof = db.Professores.ToList();

                dataGridView1.DataSource = prof;

            }
            catch
            {

            }



        }

        private void txb_Cosulta_PROFS_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
