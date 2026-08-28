namespace Abstracao
{
    public class Carro
    {
        //ATRIBUTOS (CARACTERÍSTICAS)
        public string Marca;
        public string Modelo;
        public int Ano;
        public string Cor;

        //MÉTODO (COMPORTAMENTO)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}");
            Console.WriteLine($"Cor: {Cor}, Ano: {Ano}");
            Console.WriteLine("------------------------");
        }
    }
}
