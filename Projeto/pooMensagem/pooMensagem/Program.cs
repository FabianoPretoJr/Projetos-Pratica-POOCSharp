using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1 = new Mensagem();
            Mensagem msg2 = new Mensagem();

            msg1.TextoMensagem = "Hello World";
            msg1.ExibirMensagem();
            //msg1.ExibirMensagem();

            //msg2.setTextoMensagem("Bye World");
            //msg2.ExibirMensagem();

            msg2.TextoMensagem = "Bye World";
            msg2.ExibirMensagem();

            Console.ReadKey();
        }
    }
}
