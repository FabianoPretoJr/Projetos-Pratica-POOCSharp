using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
        public Pessoa(String nomePessoa, int anoNascimentoPessoa) //parece um interface, aqui se chama construtor, parece uma boa prática interessante
        {//é passado esses parâmetros para não dar xapu e eexecutar tudo de uma vez
            this.Nome = nomePessoa;
            this.AnoNascimento = anoNascimentoPessoa;
            this.CalcularIdade();
        }

        private int anoNascimento;
        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        private String nome;
        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        //Vamos melhorar o projeto criando uma propriedade para idade

        private int idade;
        public int Idade
        {
            get {
                this.CalcularIdade();
                return this.idade;
            }
            //não precisa de set
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            //this.CalcularIdade();
            Console.WriteLine("Idade: " + this.Idade);
        }

        private void CalcularIdade() //sempre escrever o nome do método com verbo, por ser uma ação
        {
            DateTime data = DateTime.Now; //receber a data atual do sistemas

            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;

            //antes de melhorar esse método ele era void
            //return idade; //como não é void ele retorna alguma coisa, no caso a IDADE
        }
    }
}
