// <copyright file="ExtentionClass.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW4
{
    using System;

    /// <summary>
    /// Class Animal.
    /// </summary>
    internal static class ExtentionClass
    {
        /// <summary>
        /// Compares objects.
        /// </summary>
        /// <param name = "animals" > Array of Animal. </ param >
        /// /// <param name = "match" > Matching condition. </ param >
        public static void Find(this Animal[] animals, Predicate<Animal> match)
        {
            foreach (var animal in animals)
            {
                if (match(animal))
                {
                    Console.WriteLine($"Найдено животное длиной больше 50  : {animal.TypeOfAnimal()}");
                }
            }
        }
    }
}
