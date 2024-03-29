﻿
namespace Pra.AdvancedClasses.Core
{
    public class Employee : Person
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, int age, decimal salary) : base(name, age)
        {
            Salary = salary;
        }

        public override string ShowId()
        {
            string teenagerText = age < 20 ? "is a" : "is not a";
            return $"{Name} has id {id} and {teenagerText} teenager. (Salary: {salary})";
        }

    }
}

