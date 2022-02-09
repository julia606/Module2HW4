// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW4
{
    using System;

    /// <summary>
    /// Main class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Find animal with length greater 50.
        /// </summary>
        /// <param name = "animal" > Object Animal. </ param >
        /// <returns>All animals with lenght >50.</returns>
        public static bool AnimalWithLengthGreater50(Animal animal)
        {
            return animal.Length > 50;
        }

        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name = "args" > Object Animal. </ param >
        private static void Main(string[] args)
        {
            Random random = new Random();

            Animal animal1 = new AnimalWithDrySkin(random.Next(4, 9), random.Next(25, 150));
            Animal animal2 = new AnimalWithFeathers(random.Next(2, 4), random.Next(55, 70));
            Animal animal3 = new AnimalWithFur(random.Next(8, 30), random.Next(40, 90));
            Animal animal4 = new AnimalWithMoistSkin(random.Next(5, 40), random.Next(30, 80));
            Animal animal5 = new AnimalWithNoFeathers(random.Next(6, 20), random.Next(70, 110));
            Animal animal6 = new AnimalWithNoFur(random.Next(5, 28), random.Next(53, 100));

            Animal[] animals = new Animal[] { animal1, animal2, animal3, animal4, animal5, animal6 };

            Section section = new Section(animals);
            Array.Sort(animals);

            Console.WriteLine($"Количество различных типов животных в секции: {section.GetAnimalCount()}");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.TypeOfAnimal()} - {animal.Weight} кг");
            }

            Console.WriteLine();
            ExtentionClass.Find(animals, AnimalWithLengthGreater50);
        }
    }
}
