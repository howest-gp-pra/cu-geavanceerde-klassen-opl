using System;

namespace Pra.AdvancedClasses.Core
{
    public abstract class Person
    {
        protected string name;
        protected int age;
        protected Guid id;

        public bool CanVote { get; set; } = true;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            id = Guid.NewGuid();
        }

        public void CelebrateBirthday()
        {
            Age++;
        }

        public abstract string ShowId();

    }
}

