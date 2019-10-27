/* Sodasaurus.cs
 * Author: Sam Waris
 * This is the Flavor Sodasaurus class. It has things.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Enum Flavor
    /// </summary>
    public enum SodasaurusFlavor
    {
        /// <summary>
        /// Cola Flavor
        /// </summary>
        Cola,
        /// <summary>
        /// Orange Flavor
        /// </summary>
        Orange,
        /// <summary>
        /// Vanilla Flavor
        /// </summary>
        Vanilla,
        /// <summary>
        /// Chocolate Flavor
        /// </summary>
        Chocolate,
        /// <summary>
        /// RootBeer Flavor
        /// </summary>
        RootBeer,
        /// <summary>
        /// Cherry flavor
        /// </summary>
        Cherry,
        /// <summary>
        /// Lime flavor
        /// </summary>
        Lime
    }
    /// <summary>
    /// This is the sodasaurus class.
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Private Size, size.
        /// </summary>
        private Size size;
        /// <summary>
        /// Flavor for sodasaurus.
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// This is the flavor property.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                this.flavor = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Flavor");
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
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// Sodasaurus Constructor
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Flavor = SodasaurusFlavor.Cola;
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
                    "Natural Flavors",
                    "Cane Sugar"
                };
                return ingredients;
            }
        }
        /// <summary>
        /// This is the tostring method.
        /// </summary>
        /// <returns>This overrides the tostring.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.size.ToString());
            sb.Append(" ");
            sb.Append(this.flavor.ToString());
            sb.Append(" Sodasaurus");
            return sb.ToString();
        }
        /// <summary>
        /// This is the overridden description method.
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
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
                return info.ToArray();
            }
        }
    }
}
