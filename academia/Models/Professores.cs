

//namespace

    public class Professores
    {
        public int id {get; set;} 
        public string? nome { get;  set;}
        public string? cpf { get;  set;}
        public string? phone { get; set;}

       



       public  Professores( string? nome, string? cpf, string? phone)
        {
           
            this.nome = nome;
            this.cpf = cpf;
            this.phone = phone;            
        }

        public Professores()
        {

        }

      
    }

