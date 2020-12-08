using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            Console.WriteLine("Digite seu nome");
            pf.nome = Console.ReadLine();

            Console.WriteLine("Digite seu cpf");
            pf.cpf = Console.ReadLine();

            Console.WriteLine( pf.DarBoasVindas(pf.nome));
            Console.WriteLine( pf.ValidarCPF(pf.cpf));
        }
    }
}
