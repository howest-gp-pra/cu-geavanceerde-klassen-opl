﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.AdvancedClasses.Core
{
    public abstract class Person
    {
        protected string name;
        protected int age;
        protected Guid identificationId = Guid.NewGuid();

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
            identificationId = Guid.NewGuid();
        }

        public void CelebrateBirthday()
        {
            Age++;
        }

        public abstract string ShowId();

    }
}

