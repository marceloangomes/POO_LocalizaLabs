namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {this.Nome} e tenho {this.Idade} anos, Salário: {this.Salario}");
        }
    }
}