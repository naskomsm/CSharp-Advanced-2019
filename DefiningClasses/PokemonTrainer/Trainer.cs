using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name,int numberOfBadges, List<Pokemon> collection)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Collection = collection;
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Collection { get; set; }
    }
}
