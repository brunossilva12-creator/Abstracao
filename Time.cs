namespace Abstracao
{
    public class Time
    {
        public string NomeDoTime;
        public List<Jogador> ListaJogadores = new List<Jogador>();

        public void AdicionarJogador(Jogador Jogador)
        {
            ListaJogadores.Add(Jogador);
        }

        public void ListarJogadores()
        {
            Console.WriteLine("Time: " + NomeDoTime);
            Console.WriteLine("Escalação:");

            foreach (Jogador Jogador in ListaJogadores)
            {
                Console.WriteLine("Camisa " + Jogador.NumeroCamisa + " - " + Jogador.Nome + " - " + Jogador.Posicao);
            }
        }
    }
}
