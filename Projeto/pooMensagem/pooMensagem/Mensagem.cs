using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        //JEITO MAIS DEMORADO DE FAZER

        /*private String TextoMensagem;

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem); //jeito de exibir mensagem
        }

        public String getTextoMensagem()
        {
            return this.TextoMensagem; //outra forma de exibir mensagem, pelo get
        }

        public void setTextoMensagem(String valor) //salvar valor dá mensagem respeitando conceito de encapsulamento e modificador de acesso private
        {
            this.TextoMensagem = valor.ToUpper(); //método toUpper deixa todas letras maiusculas
        }*/

        //JEITO RESUMIDO

        private String textoMensagem;
        public String TextoMensagem
        {
            get { return this.textoMensagem; }
            set { this.textoMensagem = value; } //pode tratar dados atráves do set, como usando o toUpper()
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem); //jeito de exibir mensagem com método
        }
    }
}
