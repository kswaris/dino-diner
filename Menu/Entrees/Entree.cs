/* Entree.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Entree Class.
    /// </summary>
    public abstract class Entree
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
