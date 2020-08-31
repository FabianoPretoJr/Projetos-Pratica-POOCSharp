using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
        //construtor

        public Pokedex()
        {
            this.InicializaLista();
        }

        private List<PokemonPlus> pokemons; //tipo um array com a classe pokemon
        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
            //não precisa de set
        }

        private void InicializaLista() //metodo que só funciona dentro da class, por ser private, ele cadastra os pokemons
        {
            // Instanciar a lista
            this.pokemons = new List<PokemonPlus>();

            PokemonPlus p = new PokemonPlus("Bulbasauro", "tipo planta", 100);
            this.pokemons.Add(p); //adicionar na lista o pokémon
            p = new PokemonPlus("Pikachu", "tipo elétrico", 500);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "tipo fodão", 1000);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "tipo fodão", 2000);
            this.pokemons.Add(p);
            p = new PokemonPlus("Giratina", "tipo léndario fantama", 50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Flygon", "tipo dragão", 120);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "tipo aço", 300);
            this.pokemons.Add(p);
            p = new PokemonPlus("Muk", "tipo mental", 250);
            this.pokemons.Add(p);
            p = new PokemonPlus("Raiuchu", "tipo elétrico", 400);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pid", "tipo áerio", 280);
            this.pokemons.Add(p);
        }

        //metodos

        public void ListarPokemons()
        {
            for(int i = 0; i < this.Pokemons.Count; i++) //Count funciona como um lenght
            {
                Console.WriteLine("\n\nCódigo do pokémon: " + i);

                //forma mais longa
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDadosPokemon();

                //forma mais longa
                this.Pokemons[i].ExibirDadosPokemon();
            }
        }
    }
}
