using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count
        {
            get { return data.Count; }
        }

        public void Add(Hero hero)
        {
            data.Add(hero);
        }

        public int Remove(string name)
        {
            data.Remove(data.FirstOrDefault(x => x.Name == name));
            return data.Count();
        }

        public Hero GetHeroWithHighestStrength()
        {
            int biggestStr = 0;
            foreach (var item in data)
            {
                if(item.Item.Strength > biggestStr)
                {
                    biggestStr = item.Item.Strength;
                }
            }
            Hero heroToReturn = data.FirstOrDefault(x => x.Item.Strength == biggestStr);
            return heroToReturn;
        }

        public Hero GetHeroWithHighestAbility()
        {
            int biggestAbility = 0;
            foreach (var item in data)
            {
                if (item.Item.Ability > biggestAbility)
                {
                    biggestAbility = item.Item.Ability;
                }
            }
            Hero heroToReturn = data.FirstOrDefault(x => x.Item.Ability == biggestAbility);
            return heroToReturn;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            int biggestInt = 0;
            foreach (var item in data)
            {
                if (item.Item.Intelligence > biggestInt)
                {
                    biggestInt = item.Item.Intelligence;
                }
            }
            Hero heroToReturn = data.FirstOrDefault(x => x.Item.Intelligence == biggestInt);
            return heroToReturn;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Count; i++)
            {
                if(i == data.Count)
                {
                    sb.Append(data[i].ToString());
                }
                sb.AppendLine(data[i].ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
