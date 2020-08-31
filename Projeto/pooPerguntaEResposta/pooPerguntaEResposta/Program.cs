using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    class Program
    {
        static void Main(string[] args)
        {
            //trabalhar com herança
            //aqui será possivel somente as variaveis do tipo public, as private e protected não

            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Qual o seu celular?";
            p.Resposta = "mi8 lite";
            p.Dica = "Xiaomi";

            Console.WriteLine("Tente advinhar a pergunta");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.WriteLine("Resposta: ");
            String resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabéns!!! Você acertou.");
            }
            else
            {
                Console.WriteLine("Que pena!!! Você errou.");
                Console.WriteLine("Resposta correta: " + p.Resposta);
            }

            Console.ReadKey();
        }
    }
}
