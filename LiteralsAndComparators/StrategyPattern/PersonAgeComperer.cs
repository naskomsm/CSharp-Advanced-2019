namespace StrategyPattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class PersonAgeComperer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            return first.Age - second.Age;
        }
    }
}
