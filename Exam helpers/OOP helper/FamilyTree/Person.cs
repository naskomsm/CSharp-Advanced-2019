using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        public Person(string data) // if the input is data or name;
        {
            if (int.TryParse(data[0].ToString(),out _))
            {
                this.Birthdate = data;
            }
            else
            {
                this.Name = data; 
            }
        }


        public Person(string name,string birthday) // full info
        {
            this.Name = name;
            this.Birthdate = birthday;
        }

        public string Name { get; set; }

        public string Birthdate { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthdate}";
        }
    }
}
