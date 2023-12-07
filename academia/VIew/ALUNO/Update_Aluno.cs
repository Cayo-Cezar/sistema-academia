using WillFit_System.Data;
using WillFit_System.Models;

namespace WillFit_System.VIew.Aluno
{
    public partial class Update_Aluno : Form
    {
        public Update_Aluno()
        {
            InitializeComponent();
        }

        private void BTN_ATUALIZAR_Click(object sender, EventArgs e)
        {
            var db = new GMYContext();

            var name = TXB_NOME_UPDATE.Text;
            var cpf = TXB_CPF_UPDATE.Text;
            var phone = TXB_TELEFONE_UPDATE.Text;
            var matricula = TXB_MATRICULA_UPDATE.Text;

            var pesq = db.Alunos.Where(a => a.cpf.Equals(cpf)).FirstOrDefault();

            if (pesq != null)
            {
                pesq.name = name;
                pesq.phone = phone;
                pesq.matricula = matricula;


                db.SaveChanges();

                MessageBox.Show("Informações Atualizadas");

            }
            else
            {



            }



        }

        private void TXB_NOME_UPDATE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXB_CPF_UPDATE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXB_TELEFONE_UPDATE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXB_MATRICULA_UPDATE_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
