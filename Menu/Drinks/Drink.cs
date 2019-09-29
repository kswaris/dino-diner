/* Drink.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// This is the size enum. IT houses the size
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// Small drink enum.
        /// </summary>
        Small,
        /// <summary>
        /// Medium Drink enum.
        /// </summary>
        Medium,
        /// <summary>
        /// Large drink enum.
        /// </summary>
        Large
    }
    /// <summary>
    /// Drinks class.
    /// </summary>
    public abstract class Drink
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
