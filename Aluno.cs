namespace Abstracao
{
    public class Aluno
    {
        public string Nome;
        public int Matricula;
        public double Nota1;
        public double Nota2;

        public void ExibirInformacoesAluno()
        {
            Console.WriteLine($"Nome: {Nome}, Registro de matrícula: {Matricula}");
            Console.WriteLine($"Nota 1: {Nota1}, Nota 2: {Nota2}, Media: {(Nota1 + Nota2) / 2}");
        }
    }
}
