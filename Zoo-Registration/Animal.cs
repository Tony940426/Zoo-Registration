using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Registration
{
    public abstract class Animal
    {
       public int Id { get; }
       public string Name { get; set; }
       public int Age { get; set; }

       private static int IdCounter = 0;    
        
       List<Animal> animals = new List<Animal>();
        protected Animal(string Name, int Age)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            };

            if (Age < 0)
            {
                throw new ArgumentException("Age must be greated than zero");
            };

            this.Id = ++IdCounter;
            this.Name = Name;
            this.Age = Age;
        }



        public virtual void DisplayDetails()
        {
            Console.Write($"ID: {Id} | Name: {Name} | Age: {Age} | ");
        }
    }
}
