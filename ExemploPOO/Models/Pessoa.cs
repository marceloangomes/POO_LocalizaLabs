namespace ExemploPOO.Models
{
    public abstract class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {this.Nome} e tenho {this.Idade} anos.");
        }
    }
}