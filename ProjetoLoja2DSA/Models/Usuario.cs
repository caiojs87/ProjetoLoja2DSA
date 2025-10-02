namespace ProjetoLoja2DSA.Models
{
    public class Usuario
    {
        public int Id { get; set; } // realizando o emcapsulamento dos dados 
        public string ?Nome { get; set; } 
        public string ?Email  { get; set; }
        public string ?Senha { get; set; }

    }
}
