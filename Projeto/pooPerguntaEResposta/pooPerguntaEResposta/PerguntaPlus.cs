using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    public class PerguntaPlus:Pergunta //isso significa que o PerguntaPlus herdou tudo da class Pergunta
    {
        //não precisa implementar todas mesmas propriedades de novo, pode puxar de Pergunta (texto, resposta)
        //aqui será possivel ver as variaveis de tipo public e protected, as privete não


        //construtor

        public PerguntaPlus():base() //to chamando o construtor da class base (pai)
        {
            this.Dica = ""; //aqui adc a propriedade a mais que essa class possui
        }

        //sobrecarga

        public PerguntaPlus(String texto, String resposta, String dica):base(texto, resposta) //a sobrecarga tbm vem dá class "pai", no base devesse passar os parametros dela
        {
            this.Dica = dica;
        }

        public String Dica { get; set; }
    }
}
