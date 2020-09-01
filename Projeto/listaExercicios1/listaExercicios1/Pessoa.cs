using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaExercicios1
{
    public class Pessoa
    {
        private String _nome;
        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        private double _altura;
        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Data de nascimento: " + Convert.ToString(this.DataNascimento).Replace(" 00:00:00", " "));
            Console.WriteLine("Idade: " + this.CalcularIdade());
        }

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;

            int dia = data.Day;
            int mes = data.Month;
            int ano = data.Year;

            if (this.DataNascimento.Month >= mes)
            {
                if (this.DataNascimento.Day <= dia)
                {
                    int res = ano - this.DataNascimento.Year;
                    return res;
                }      
                else
                {
                    int res = (ano - this.DataNascimento.Year) - 1;
                    return res;
                }
            }
            else
            {
                int res = ano - this.DataNascimento.Year;
                return res;
            }

        }
    }
}
