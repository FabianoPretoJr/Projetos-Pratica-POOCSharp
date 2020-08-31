using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    public class Pergunta
    {
        //public String testeA; //qualquer um pode acessar
        //private String testeB; //só de dentro dessa class pode acessar
        //protected String testeC; //as class que herdam essa podem acessar

        public Pergunta()
        {
            this.Texto = "";
            this.Resposta = "";
        }

        public Pergunta(String texto, String resposta)
        {
            this.Texto = texto;
            this.Resposta = resposta;
        }

        public String Texto { get; set; }

        public String Resposta { get; set; } //não precisa de uma variavel private, e o valor dela não muda
    }
}
