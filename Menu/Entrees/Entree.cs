/* Entree.cs
 * Author: Sam Waris
 * This is the entree class, it is the bas eclass for entrees.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree Class.
    /// </summary>
    public abstract class Entree : IMenuItem
    {
        /// <summary>
        /// This is the calories property.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// This is the price constructor.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This is the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }
    }
}
