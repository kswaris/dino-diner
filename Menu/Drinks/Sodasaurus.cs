/* Sodasaurus.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks 
{
   
    /// <summary>
    /// This is the sodasaurus class.
    /// </summary>
    public class Sodasaurus : Drink
    {
        private Size size;
        private Flavor flavor;
        /// <summary>
        /// This is the flavor property.
        /// </summary>
        public Flavor Flavor
        {
            get
            {
                return this.flavor;
            }
            set
            {
                this.flavor = value;    
            }
        }
        /// <summary>
        /// This is the size property.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
                switch(size)
                {
                    case Size.Small: 
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }
        /// <summary>
        /// Sodasaurus Constructor
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Flavor = Flavor.Cola;
            Ice = true;
        }
        /// <summary>
        /// This is the ingredients override.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Water",
                    "Natural Flavor",
                    "Cane Sugar"
                };
                return ingredients;
            }
        }
    }
}
