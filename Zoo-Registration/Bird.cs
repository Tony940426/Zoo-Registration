using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Registration
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public bool CanFly { get; set; }
        public Bird(string name, int age, double wingSpan, bool canFly) : base(name, age)
        {
            if (wingSpan < 0)
            {
                throw new ArgumentException("WingSpan must be greater than zero");
            }
            this.WingSpan = wingSpan;
            this.CanFly = canFly;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"WingSpan: {WingSpan} | CanFly: {CanFly}");
        }
    }
}
