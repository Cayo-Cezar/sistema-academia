namespace WillFit_System.Models
{
    public class Alunos
    {
        #region attributes
        public int Id { get; set; }
        public string? _name { get; set; }
        public string? _cpf { get; set; }
        public string? _phone { get; set; }

        public string? _matricula { get; set; }
    
            
            #endregion

            #region properties
            public string name
            {
                get { return _name; }
                set
                {
                    if (value == null || value == "") throw new ArgumentNullException(null, "O nome não pode ser nulo ");
                    if (value.Length <= 2) throw new ArgumentOutOfRangeException(null, "Nome pequeno demais");
                    _name = value.ToUpper();
                }
            }

            public string cpf
            {
                get { return _cpf; }
                 set
                {
                     _cpf = value;
                }
            }
            public string? phone
            {
                get { return _phone; }
                 set
                {
                    _phone = value;
                }
            }

           

           

            public string matricula
             {
                        get { return _matricula; }

                    set => _matricula = value;

            }

        


        #endregion

        #region Constructors


        public Alunos( string? name, string? cpf, string? phone ,string? matricula)
        {
            _name = name;
            _cpf = cpf;
            _phone = phone;
            _matricula = matricula;
        }






        #endregion
        #region methods

        #endregion
    }
    }



