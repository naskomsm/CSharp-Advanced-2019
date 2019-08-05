namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();
            
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

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName); // gives a trainer or Null;

                if (trainer == null) // just check if the trainer exist in the list
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }
                trainer.Collection.Add(pokemon);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if(trainer.Collection.Any(x=>x.Element == input))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        ReduceHealth(trainer.Collection);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,trainers.OrderByDescending(x=>x.NumberOfBadges)));

        }

        static void ReduceHealth(List<Pokemon> pokemons)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                Pokemon pokemon = pokemons[i];// get the first pokemon
                pokemon.Health -= 10;

                if (IsDead(pokemon.Health))
                {
                    pokemons.RemoveAt(i);
                    i--;
                }
            }
        }
        
        static bool IsDead(int pokemonHealth)
        {
            return pokemonHealth <= 0;
        }

    }
}