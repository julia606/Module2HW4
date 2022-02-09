// <copyright file="AnimalWithDrySkin.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW4
{
    /// <summary>
    /// Class for Animal with dry skin.
    /// </summary>
    internal class AnimalWithDrySkin : AnimalWithNoFeathers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimalWithDrySkin"/> class.
        /// </summary>
        /// <param name = "weight" > Weight of animal. </ param >
        /// <param name = "length" > Length of animal. </ param >
        public AnimalWithDrySkin(double weight, double length)
            : base(weight, length)
        {
        }

        /// <summary>
        /// Getting type of animal.
        /// </summary>
        /// <returns>Type of animal to string.</returns>
        public override string TypeOfAnimal()
        {
            return "Животное с сухой кожей";
        }
    }
}
