using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceApp
{
    class Robot : Inorganic, IPet
    {
        public new string Name { get; set; }
        public new DateTime Birthday { get; set; }
        public int VersionNumber { get; set; }
        public string OwnersName { get; set; }
        private new bool IsAsleep { get; set; }
        public Robot(string name)
        {
            Name = name;
            Birthday = DateTime.Now;
            IsAsleep = false;
            int count = 0;
            count++;
            VersionNumber = count;
        }

        public void GetWakeState()
        {
            if (this.IsAsleep == true)
            {
                Console.WriteLine($"{this.Name} is asleep");
            }
            else
            {
                this.SayHello();
            }

        }
        public new void StartUp()
        {
            IsAsleep = false;
        }
        public new void ShutDown()
        {
            IsAsleep = true;
        }
        public new void SayHello()
        {
            Console.WriteLine("IAM BRANIAC");
        }

        public override string ToString()
        {
            return $"Robot: {Name} {Birthday} {VersionNumber}";
        }
    }
}
