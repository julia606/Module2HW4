// <copyright file="Section.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW4
{
    /// <summary>
    /// Class for section with animals.
    /// </summary>
    internal class Section : ISection
    {
        private Animal[] _animals = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Section"/> class.
        /// </summary>
        /// <param name = "animals" > Array of animals. </ param >
        public Section(Animal[] animals)
        {
            _animals = animals;
        }

        /// <summary>
        /// Animal count.
        /// </summary>
        /// <returns>Count animals.</returns>
        public int GetAnimalCount()
        {
            int count = 0;

            for (int i = 1; i < _animals.Length; i++)
            {
                if (_animals[i].Equals(_animals[i - 1]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
