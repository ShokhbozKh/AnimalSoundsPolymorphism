using ConsoleApp4.models;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Sound();

            Dog dog = new Dog();
            dog.Sound();
            
            Cat cat = new();
            cat.Sound();
            
            Duck duck = new();
            duck.Sound();
            
        }
    }
}