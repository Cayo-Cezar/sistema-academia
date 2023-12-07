using WillFit_System.Data;

namespace WillFit_System.VIew.Treinos
{
    public partial class Get_Treino : Form
    {
        public Get_Treino()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_PESQU_TREINOS_Click(object sender, EventArgs e)
        {

            GMYContext db = new GMYContext();

            var treinos = db.Treinos.ToList();

            dataGridView_TREINO.DataSource = treinos;
            
           
            
        }
    }
}
