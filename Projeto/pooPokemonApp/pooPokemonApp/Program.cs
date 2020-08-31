using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while(resp != 0)
            {
                resp = Menu(); //chamar o outro método/função, tá ali embaixo

                Console.Clear();

                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                else if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.Write("\n\nDigite o código do pokémon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    //pegaro pokémon do jogador
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];

                    //definir o pokémon do pc
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];

                    Console.Clear();

                    Console.WriteLine("\n\nDados dos pokémons que lutaram:");
                    Console.WriteLine("\n\nDados do seu pokémon");
                    pPlayer.ExibirDadosPokemonPlus();
                    Console.WriteLine("\n\nDados do PC");
                    pPC.ExibirDadosPokemonPlus();

                    //batalhar
                    if (pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("\n\nParabéns!!! Você ganhou.");
                    }
                    else
                    {
                        Console.WriteLine("\n\nQue pena!!! Você perdeu.");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }

            //não precisa mais desse modo, porque foi feito um automatico na class pokedex, o listar
            //Pokemon p = pokedex.Pokemons[2]; //puxa para exibir o pokemon da lista na pokedex
            //p.ExibirDadosPokemon();
            
            //coisas que eram uteis antes de fazer a class Pokedex
            //Pokemon p = new Pokemon();
            //p.Nome = "Bulbasauro";
            //p.Descricao = "Pokémon tipo planta.";
            //p.ExibirDadosPokemon(); //chama o metodo sem parametro
            ////p.ExibirDadosPokemon(true); //chama o metodo com parametro SOBRECARGA
        }

        static int Menu()
        {
            Console.WriteLine("\nPokémon---Jogo de Batalha");
            Console.WriteLine("\n\n0 - Sair da Pokédex");
            Console.WriteLine("1 - Listar todos os Pokémons da pokédex");
            Console.WriteLine("2 - Batalhar");
            Console.Write("\n\nO que deseja fazer? ");
            int resp = Convert.ToInt32(Console.ReadLine());

            return resp;

        }
    }
}
