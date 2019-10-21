/* Water.cs
 * Author: Sam Waris
 * This is the water class, it does the bare minimum.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the water class.
    /// </summary>
    public class Water : Drink, IMenuItem, IOrderItem
    {
        /// <summary>
        /// This is the no argument constructor.
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Lemon = false;

        }
        private bool lemon;
        private Size size;
        /// <summary>
        /// This is the lemon property.
        /// </summary>
        public bool Lemon
        {
            get { return this.lemon; }
            set { this.lemon = value; }
        }
        /// <summary>
        /// This is the size property.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                this.size = value;
                this.Price = 0.10;
                this.Calories = 00;
            }
        }
        /// <summary>
        /// This is the ingredients property, it brings things.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        /// <summary>
        /// This is the add lemon method.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
        /// <summary>
        /// This is the major tostring
        /// </summary>
        /// <returns>this is the string you return.</returns>
        public override string ToString()
        {
            return this.size.ToString() + " Water";
        }
        /// <summary>
        /// This is the overridden description method.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// This is the special information array return.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> info = new List<string>();
                if (!this.Ice) info.Add("Hold Ice");
                if (this.Lemon) info.Add("Add Lemon");
                return info.ToArray();
            }
        }
    }
}
