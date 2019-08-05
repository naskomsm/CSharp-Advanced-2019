using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Collection = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Collection { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.NumberOfBadges} {this.Collection.Count}";
        }
    }
}
