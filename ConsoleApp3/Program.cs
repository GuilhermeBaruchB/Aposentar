using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;

            Console.WriteLine("Digite o nome do(a) funcionario(a):");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do(a) " + nome + ":");
            double idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantos anos o(a) " + nome + " trabalha na empresa:");
            double tempo = double.Parse(Console.ReadLine());

            if (idade >= 65)
            {
                Console.WriteLine("O funcionario(a) " + nome + " está qualificado para se aposentar");
            }
            else if (tempo >= 30)
            {
                Console.WriteLine("O funcionario(a) " + nome + " está qualificado para se aposentar");
            }
            else if (idade >= 60 && tempo >= 25)
            {
                Console.WriteLine("O funcionario(a) " + nome + " está qualificado para se aposentar");
            }
            else if (idade < 65 || tempo < 30 ||  idade < 60 && tempo <25)
            {
                Console.WriteLine("O funcionario(a) " + nome + " não está qualificado para se aposentar ainda");
            }

            Console.ReadKey();
        }
    }
}
