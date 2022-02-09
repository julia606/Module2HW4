// <copyright file="AnimalWithNoFeathers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW4
{
    /// <summary>
    /// Class for Animal with no feathers.
    /// </summary>
    internal class AnimalWithNoFeathers : AnimalWithNoFur
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimalWithNoFeathers"/> class.
        /// </summary>
        /// <param name = "weight" > Weight of animal. </ param >
        /// <param name = "length" > Length of animal. </ param >
        public AnimalWithNoFeathers(double weight, double length)
            : base(weight, length)
        {
        }

        /// <summary>
        /// Getting type of animal.
        /// </summary>
        /// <returns>Type of animal to string.</returns>
        public override string TypeOfAnimal()
        {
            return "Животное без перьев";
        }
    }
}
