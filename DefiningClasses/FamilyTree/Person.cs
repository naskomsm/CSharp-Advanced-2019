using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        private string name;
        private string birthday;
        private List<Parent> parents;
        private List<Child> children;
        
        public Person(string name,string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public string Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name)
                .AppendLine(" " + this.Birthday)
                .AppendLine("Parents:");
            
            if (this.Parents.Count != 0)
            {
                foreach (Parent parent in this.Parents)
                {
                    sb.AppendLine(parent.ToString());
                }
            }
            
            sb.AppendLine("Children:");
            if (this.Children.Count != 0)
            {
                foreach (Child child in this.Children)
                {
                    sb.AppendLine(child.ToString());
                }
            }

            return sb.ToString().Trim();
        }
    }
}
