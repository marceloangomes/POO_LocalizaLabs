namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public  override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {this.Nome} e tenho {this.Idade} anos, Nota: {this.Nota}");
        }
    }
}