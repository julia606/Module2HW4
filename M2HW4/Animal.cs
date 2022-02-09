// <copyright file="Animal.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW4
{
    using System;

    /// <summary>
    /// Class Animal.
    /// </summary>
    internal class Animal : IComparable<Animal>
    {
        private readonly double _weight;
        private readonly double _length;

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name = "weight" > Weight of animal. </ param >
        /// <param name = "length" > Length of animal. </ param >
        public Animal(double weight, double length)
        {
            _weight = weight;
            _length = length;
        }

        /// <summary>
        /// Gets weight.
        /// </summary>
        /// <value>
        /// Weight.
        /// </value>
        public double Weight
        {
            get
            {
                return _weight;
            }
        }

        /// <summary>
        /// Gets length.
        /// </summary>
        /// <value>
        /// Length.
        /// </value>
        public double Length
        {
            get
            {
                return _length;
            }
        }

        /// <summary>
        /// Compares objects.
        /// </summary>
        /// <param name = "animal" > Object Animal. </ param >
        /// <returns>Integer.</returns>
#nullable enable
        public int CompareTo(Animal? animal)
        {
            if (animal is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            return Weight.CompareTo(animal.Weight);
        }

        /// <summary>
        /// Method for a type of animal.
        /// </summary>
        /// <returns>Return type of animal.</returns>
        public virtual string TypeOfAnimal()
        {
            return "Тип животного";
        }
    }
}
