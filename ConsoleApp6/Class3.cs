using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceApp
{
    abstract class Inorganic : Being
    {
        public string food { get; set; }
        public bool IsAsleep { get; set; }

        public void StartUp()
        {
            this.IsAsleep = false;
            Console.WriteLine(this.IsAsleep);
        }

        public void WakeUp()
        {
            this.IsAsleep = false;
            Console.WriteLine(this.IsAsleep);
        }

        public void FallAsleep()
        {
            this.IsAsleep = true;
            Console.WriteLine(this.IsAsleep);
        }

        public void ShutDown()
        {
            this.IsAsleep = true;
            Console.WriteLine(this.IsAsleep);
        }
    }
}
