using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.models
{
    internal class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow Meow .......");
        }
    }
}
