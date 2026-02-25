using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo_Registration
{
    public class Mammal : Animal
    {
        public string FurColor { get; set; }
        public bool IsCarnivore { get; set; }

        public Mammal(string name, int age, string furColor, bool isCarnivore) : base(name,age)
        {
            if (string.IsNullOrEmpty(furColor))
            {
                throw new ArgumentException("FurColor cannot be null or empty.");
            };

            this.FurColor = furColor;
            this.IsCarnivore = isCarnivore;
        }
    }
}
