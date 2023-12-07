using WillFit_System.Data;


namespace WillFit_System.VIew.Treinos
{
    public partial class Criar_Treino : Form
    {
        public Criar_Treino()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CRIAR_TREINO_Click(object sender, EventArgs e)
        {
            try
            {
                GMYContext db = new GMYContext();

                var NomeTreino = TXB_NOME_TREINO.Text;
                var Reps = TXB_REPETICOES.Text;
                var equipamentos = TXB_EQUIPAMENTOS.Text;
                var MatAluno = TXB_MAT_ALUNO_TREINO.Text;


                Treino treino = new Treino(NomeTreino, Reps, equipamentos, MatAluno);




                db.Add(treino);


                db.SaveChanges();
                MessageBox.Show("Treino Cadastrado");
            }
            catch { } 

            
            
           

        }
    }
}
