using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokemon
    {
        //construtor

        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        //sobrecarga (bom para fazer filtro)

        public Pokemon(String nome, String descricao)
        {
            this.nome = nome;
            this.descricao = descricao;
        }

        //propriedades

        private String nome;
        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private String descricao;
        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value.ToUpper(); }
        }

        //metodos

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }

        public void ExibirDadosPokemon(Boolean formatado) //caso seja passsado esse parametro ele cai na sobrecarga desse metodo
        {
            if(formatado == true)
            {
                Console.WriteLine("Pokémon " + this.Nome + ": " + this.descricao.ToLower());
            }
            else
            {
                Console.WriteLine("Nome do Pokémon: " + this.Nome);
                Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
            }
        }
    }
}
