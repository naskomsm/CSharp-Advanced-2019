namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();


            List<Pokemon> removedPokemons = new List<Pokemon>();
            while (true) // info about pokemon and trainer
            {
                string input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }

                string[] splittedInput = input.Split();


                string trainerName = splittedInput[0];

                string pokemonName = splittedInput[1];
                string pokemonElement = splittedInput[2];
                int pokemonHealth = int.Parse(splittedInput[3]);

                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer newTrainer = new Trainer(trainerName, 0, new List<Pokemon>());

                if (!trainers.ContainsKey(trainerName))
                {
                    newTrainer.Collection.Add(newPokemon);
                    trainers.Add(trainerName,newTrainer);
                }
                else
                {
                    trainers[trainerName].Collection.Add(newPokemon);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                operation(input, trainers,removedPokemons);
            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Key.ToString()} {trainer.Value.NumberOfBadges.ToString()} {trainer.Value.Collection.Where(x=> !removedPokemons.Contains(x)).Count()}");
            }

        }
        
        public  static void operation(string word, Dictionary<string,Trainer> dict,List<Pokemon> removedpoke)
        {
            foreach (var trainer in dict)
            {
                int elementCount = 0;
                foreach (var pokemon in trainer.Value.Collection)
                {
                    if (pokemon.Element == word)
                    {
                        elementCount++;
                    }
                }
                if (elementCount >= 1)
                {
                    trainer.Value.NumberOfBadges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Value.Collection)
                    {
                        pokemon.Health -= 10;
                        if (pokemon.Health <= 0)
                        {
                            removedpoke.Add(pokemon);
                        }
                    }
                }
            }
        }
    }
}
