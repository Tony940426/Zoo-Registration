using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Registration
{
    public abstract class Animal
    {
       public int id { get; }
       public string name { get; set; }
       public int age { get; set; }

       private static int idCounter = 0;    

        protected Animal(string Name, int Age)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            };

            if (Age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            };

            this.id = ++idCounter;
            this.name = Name;
            this.age = Age;
        }
    }
}
