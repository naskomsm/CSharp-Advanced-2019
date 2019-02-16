namespace StrategyPattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;


    public class PersonNameComperer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int nameResult = first.Name.Length.CompareTo(second.Name.Length);
            if(nameResult == 0)
            {
                return first.Name.ToLower()[0].CompareTo(second.Name.ToLower()[0]);
            }
            return nameResult;
        }
    }
}
