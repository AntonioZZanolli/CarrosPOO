using Carros.ContentContext;

var carro = new Carro("Sandero", 1000, "Renault");
carro.ligar();

Console.WriteLine(carro.situacao);

carro.andar();
carro.andar();
carro.andar();

carro.re();

carro.desligar();

Console.WriteLine(carro.situacao);
Console.WriteLine(carro.Nome);
Console.WriteLine(carro.Peso);
Console.WriteLine(carro.Modelo);
Console.WriteLine(carro.distancia);