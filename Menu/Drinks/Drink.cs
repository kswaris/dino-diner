/* Drink.cs
 * Author: Sam Waris
 * This is the drink.cs class It houses drink things.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Drinks class.
    /// </summary>
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// This is the price double, it holds the price.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This is the calories uint, it has properties.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// This is the ingreidents list. It has a getter.
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// This is the size property.
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// This is the ice getter/setter.
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// THis holds the ice.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
