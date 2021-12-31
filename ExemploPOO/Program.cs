

// See https://aka.ms/new-console-template for more information


using ExemploPOO.Helper;
using ExemploPOO.Models;

Retangulo r = new Retangulo();
r.DefinirMedidas(10,5);
System.Console.WriteLine($"Área: {r.ObterArea()}");

//Herança
// Pessoa p1 = new Pessoa();
// p1.Nome="João";
// p1.Idade=30;
// p1.Apresentar();

Aluno p2 = new Aluno();
p2.Nome="Mané";
p2.Idade=40;
p2.Nota=9;
p2.Apresentar();

Professor p3 = new Professor();
p3.Nome="Crioulo";
p3.Idade=50;
p3.Salario=10900;
p3.Apresentar();

//Sobrecarga
Calculadora calc = new Calculadora();
System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(10,10)}" );
System.Console.WriteLine($"Resultado da segunda soma: {calc.Somar(10,10,10)}" );
System.Console.WriteLine($"Resultado da segunda multiplicar: {calc.Multiplicar(10,10)}" );
System.Console.WriteLine($"Resultado da segunda dividir: {calc.Dividir(10,10)}" );

//Classe Abstrata
Corrente c = new Corrente();
c.Creditar(100);
c.ExibirSaldo();

//Classe pai Object C#
Computador comput = new Computador();
System.Console.WriteLine(comput.ToString());


//Arquivos
var caminho=".\\";
var listaString = new List<string>{"Linha 1","Linha 2", "Linha 3"};
var listaStringCont =  new List<string>{"Linha 4","Linha 5","Linha 6"};
FileHelper helper = new FileHelper();
System.Console.WriteLine("Listar diretórios");
helper.ListarDiretorios(caminho);
System.Console.WriteLine("Listar Arquivos");
helper.ListarArquivos(caminho);
System.Console.WriteLine("Criar Diretorio");
helper.CriarDiretorio(caminho);
System.Console.WriteLine("Criar Arquivo");
helper.CriarArquivoTexto(Path.Combine(caminho,"NovoDiretorio","arquivo-teste.txt"),"Tem uma mosca na sopa");
System.Console.WriteLine("Criar Arquivo Stream");
helper.CriarArquivoTextoStream(Path.Combine(caminho,"NovoDiretorio","arquivo-teste-Stream.txt"), listaString);
System.Console.WriteLine("Adicionar Arquivo Stream");
helper.AdicionarArquivoTextoStream (Path.Combine(caminho,"NovoDiretorio","arquivo-teste-Stream.txt"),listaStringCont);
System.Console.WriteLine("Ler Arquivo  ");
helper.LerArquivo (Path.Combine(caminho,"NovoDiretorio","arquivo-teste-Stream.txt"));
System.Console.WriteLine("Ler Arquivo Stream");
helper.LerArquivoStream (Path.Combine(caminho,"NovoDiretorio","arquivo-teste-Stream.txt"));
System.Console.WriteLine("Mover Arquivo");
helper.MoverArquivo(Path.Combine(caminho,"NovoDiretorio","arquivo-teste-Stream.txt"),Path.Combine(caminho,"NovoDiretorio1","arquivo-teste-Stream.txt"));
System.Console.WriteLine("Copiar Arquivo");
helper.CopiarArquivo(Path.Combine(caminho,"NovoDiretorio","arquivo-teste-Stream.txt"),Path.Combine(caminho,"NovoDiretorio1","arquivo-teste-Stream.txt"));
System.Console.WriteLine("Apagar Diretorio");
helper.ApagarDiretorio(caminho);
System.Console.WriteLine("Apagar Arquivo");
helper.DeletarArquivo(caminho);









