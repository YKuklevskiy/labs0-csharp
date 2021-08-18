using System;

namespace FiveSubClasses.Classes
{
    class Cat : Animal
    {

        public Cat(int age, bool domestic)
        {

            Name = "Кошка";
            Age = age;
            Genus = "Felis";
            Domestic = domestic;
            if(Domestic)
                Habitat = "Жилище хозяина";
            else
                Habitat = "Улица";

        }

        public override void Shelter()
        {

            if (Domestic)
                Console.WriteLine("Животное уже домашнее.\n");
            else
            {
                Domestic = true;
                Console.WriteLine("Животное приючено.\n");
                Habitat = "Жилище хозяина";
            }

        }

    }
}
