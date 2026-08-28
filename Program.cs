namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO O OBJETO (INSTANCIAÇÃO)
            Carro MeuFusca = new Carro();

            MeuFusca.Marca = "Volkswagen";
            MeuFusca.Modelo = "Fusca";
            MeuFusca.Ano = 1975;
            MeuFusca.Cor = "Azul";

            Carro CarroVizinho = new Carro();

            CarroVizinho.Marca = "Fiat";
            CarroVizinho.Modelo = "Uno";
            CarroVizinho.Ano = 2010;
            CarroVizinho.Cor = "Prata";

            Console.WriteLine("Informações do meu carro: ");
            MeuFusca.ExibirInformacoes();

            Console.WriteLine("Informações do carro do meu vizinho: ");
            CarroVizinho.ExibirInformacoes();


            //EXERCÍCIO 1

            Produtos Produto1 = new Produtos();
            Produto1.Nome = "Caneta";
            Produto1.Preco = 3.99;
            Produto1.QuantidadeEstoque = 500;

            Console.WriteLine("Informações do produto: ");
            Produto1.ExibirDados();

            Produtos Produto2 = new Produtos();
            Produto2.Nome = "Caderno";
            Produto2.Preco = 39.99;
            Produto2.QuantidadeEstoque = 200;

            Console.WriteLine("Informações do produto: ");
            Produto2.ExibirDados();

            Console.ReadKey();
        }
    }
}