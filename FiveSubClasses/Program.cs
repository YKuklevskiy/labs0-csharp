using System;
using FiveSubClasses.Classes;

// Реализовать базовый класс, 3 функции и 5 свойств. 
// Наследовать их в другие 5 классов.

namespace FiveSubClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Lion lion = new Lion(6, false);
            Elephant elephant = new Elephant(12, false);
            Otter otter = new Otter(3, false);
            Dog dog = new Dog(5, true);
            Cat cat = new Cat(2, false);

            lion.ShowInfo();
            elephant.ShowInfo();
            otter.ShowInfo();
            dog.ShowInfo();
            cat.ShowInfo();
            cat.Shelter();
            cat.GrowUp();
            cat.ShowInfo();

            Console.ReadKey();

        }
    }
}
