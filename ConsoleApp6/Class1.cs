using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceApp
{
    class Being
    {
        public string Name { get; set; } = "name";
        public DateTime Birthday { get; set; } = new DateTime(1970, 8, 24);
        public string greeting { get; set; } = "Hello!";
        private bool IsAsleep { get; set; } = true;

        public void SayHello()
        {
            Console.WriteLine($"{greeting}");
        }

        public override string ToString()
        {
            return $"{greeting} My name is {this.GetType().Name} I was born on {Birthday} I {(IsAsleep ? "am asleep" : "am not asleep")}";
        }
    }
}
