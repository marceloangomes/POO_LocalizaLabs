

// See https://aka.ms/new-console-template for more information


using ExemploPOO.Models;

Pessoa p1 = new Pessoa();
p1.Nome="João";
p1.Idade=30;

p1.Apresentar();

Retangulo r = new Retangulo();
r.DefinirMedidas(10,5);
System.Console.WriteLine($"Área: {r.ObterArea()}");




