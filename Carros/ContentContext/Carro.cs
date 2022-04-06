namespace Carros.ContentContext
{
    internal class Carro
    {
        public bool situacao = false;

        public int distancia = 0;
        public string Nome { get; set; }
        public int Peso{ get; set; }
        public string Modelo { get; set; }

        public Carro(string nome,int peso,string modelo)
        {
            Nome = nome;
            Peso = peso;
            Modelo = modelo; 
        }

        public void andar()
        {
            this.distancia++;
        }

        public void re()
        {
            this.distancia--;
        }

        public void ligar()
        {
            this.situacao = true;
        }

        public void desligar()
        {
            this.situacao = false;
        }
    }
}
