namespace Abstracao
{
    public class Produtos
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;
        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade em estoque {QuantidadeEstoque}");
            Console.WriteLine("------------------------");
        }
    }
}
