using System;

// Реализовать класс персона(2 приватных поля, 3 свойства и 2 функции) 
// и класс животное(2 приватных поля, 4 св-ва, 2 функции) 
// В основной программе написать взаимодействие между классами

namespace TwoClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal simba = new Animal("Симба", 3.5f, "Лев", false);
            Animal bobyk = new Animal("Бобик", 1.5f, "Пёс", true);
            Person valera = new Person("Валера", 13, 167);
            Person kostya = new Person("Константин", 21, 184);

            simba.ShowInfo();

            valera.ShelterAnimal(bobyk);
            kostya.ShelterAnimal(simba);
            kostya.ShelterAnimal(bobyk);
            
            valera.ShowInfo();
            kostya.ShowInfo();

            Console.ReadKey();

        }
    }
}
