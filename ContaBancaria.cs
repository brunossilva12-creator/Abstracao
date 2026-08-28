namespace Abstracao
{
    public class ContaBancaria
    {
        public string Titular;
        public int NumeroConta;
        public double Saldo;
        public double Deposito;
        public double Saque;

        public void Depositar()
        {
            Console.WriteLine($"Titular: {Titular}, Número da conta: {NumeroConta}");
            Console.WriteLine($"Seu saldo incial: {Saldo}, Seu depósito: {Deposito}, Seu saldo atual {Saldo + Deposito:F2}");
            Console.WriteLine("------------------------");
        }

        public void Sacar()
        {
            Console.WriteLine($"Titular: {Titular}, Número da conta: {NumeroConta}");

            if (Saque <= Saldo)
            {
                Console.WriteLine($"Seu saldo incial: {Saldo}, Seu valor Sacado {Saque}, Seu saldo atual {Saldo - Saque:F2}");
                Console.WriteLine("------------------------");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, deseja fazer um empréstimo bancário? (não responda)");
                Console.WriteLine("------------------------");
            }
        }
    }
}
