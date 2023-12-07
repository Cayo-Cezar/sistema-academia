public class Treino
    {
        public int Id_treino { get; set; }

        public string Nome_Exercicio { get; set; } = string.Empty;

        public string Repeticoes { get; set; } = string.Empty;

        public string Equipamentos { get; set; } = string.Empty;

        public string Matricula_aluno { get; set; } = string.Empty;




        public Treino( string nome_Exercicio, string repeticoes, string equipamentos, string matricula_aluno)
        {
            
            Nome_Exercicio = nome_Exercicio;
            Repeticoes = repeticoes;
            Equipamentos = equipamentos;
            Matricula_aluno = matricula_aluno;
        }

        
        
    }

