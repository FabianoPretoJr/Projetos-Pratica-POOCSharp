using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaExercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pes = new Pessoa();

            Console.Write("Digite seu nome: ");
            pes.Nome = Console.ReadLine();
            Console.Write("Digite sua data de nascimento: ");
            pes.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            pes.Altura = Convert.ToDouble(Console.ReadLine());

            pes.ImprimirDados();

            Console.ReadKey();
        }
    }
}
