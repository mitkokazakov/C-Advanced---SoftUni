using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainers> listTrainers = new List<Trainers>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] inputInfo = input.Split();
                string trainerName = inputInfo[0];
                string pokemonName = inputInfo[1];
                string pokemonElement = inputInfo[2];
                int pokemonHealth = int.Parse(inputInfo[3]);

                Pokemon pokemon = new Pokemon(pokemonName,pokemonElement,pokemonHealth);
                
                Trainers existTrainer = listTrainers.Find(x => x.Name == trainerName);

                if (existTrainer != null)
                {
                    existTrainer.AddPokemon(pokemon);
                }
                else
                {

                    Trainers trainers = new Trainers(trainerName);
                    trainers.AddPokemon(pokemon);
                    listTrainers.Add(trainers);
                }

                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                foreach (var trainer in listTrainers)
                {
                    if (trainer.Pokemons.Any(x => x.Eelement == commands))
                    {
                        trainer.NumOfbadges += 1;
                    }
                    else
                    {
                        trainer.DecreaseHealth();
                        
                    }

                    
                }
                commands = Console.ReadLine();
            }

            foreach (var trainer in listTrainers)
            {
                trainer.Pokemons.RemoveAll(x => x.Health <= 0);
            }

            //var removedPokemons = listTrainers.Where(x => x.Pokemons.All(h => h.Health > 0));

            var result = listTrainers.OrderByDescending(x => x.NumOfbadges);

            Console.WriteLine(String.Join(Environment.NewLine,result));
            
        }
    }
}
