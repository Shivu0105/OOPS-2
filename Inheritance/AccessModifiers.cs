using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersBasics
{

    // public, private, protected, internal
    class AccessModifiers
    {
        private string Name = "Shivam";

        protected string surName = "Dalal";   // same class/ Child class access
        public string NameGetter
        {
            get { return Name; }
            set { Name = value; }
        }

        public void FullName()
        {
            Console.WriteLine($"{Name} {surName}");
        }
    }

    class Manjiri : AccessModifiers
    {
        private string name = "Manjiri";

        public string NameGetter
        {
            get { return name; }
            set { name = value; }
        }

        public void FullName()
        {
            Console.WriteLine($"{name} {surName}");
        }

    }
    class Minakshi : AccessModifiers
    {
        private string name = "Minakshi";

        public string GetName
        {
            get { return name; }
            set { name = value; }
        }
        public void FullName()
        {
            Console.WriteLine($"{name} {surName}");
        }
    }
}
