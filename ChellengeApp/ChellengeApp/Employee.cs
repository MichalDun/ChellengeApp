﻿namespace ChellengeApp
{
    internal class Employee
    {
        private List<int> rating = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.rating.Sum();
            }
        }
        public void AddRating(int score)
        {
            this.rating.Add(score);
        }
    }
}
