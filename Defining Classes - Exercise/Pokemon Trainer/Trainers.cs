using System;
using System.Collections.Generic;


namespace PokemonTrainer
{
    public class Trainers
    {
        public string Name { get; set; }
        public int NumOfbadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainers(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
        }

       
        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void DecreaseHealth()
        {
            foreach (var pokemon in this.Pokemons)
            {
                pokemon.Health -= 10;

            }
        }

       
        public override string ToString()
        {
            return $"{this.Name} {this.NumOfbadges} {this.Pokemons.Count}";
        }
    }
}
