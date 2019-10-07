/* Tyrannotea.cs
 * Author: Sam Waris
 * This is the tyrannotea class. It has things that relate to tea.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Tyrannotea class
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
    {
        /// <summary>
        /// This is the sweet bool.
        /// </summary>
        private bool sweet;
        /// <summary>
        /// This is the lemon bool.
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// This is the Size, size.
        /// </summary>
        private Size size;
        /// <summary>
        /// This is the trannotea constructor with no arguments.
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            Sweet = false;
            Lemon = false;
            Ice = true;
        }
        /// <summary>
        /// This is the sweet property. YOu can get/set the tea's sweetness
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                this.sweet = value;
                Size = this.size;
            }
        }
        /// <summary>
        /// This is the lemon property, you can get/set the lemon.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
            set
            {
                this.lemon = value;
            }
        }
        /// <summary>
        /// This is the size property, it has getters/setters for the size
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
                switch(size)
                {
                    case Size.Small:
                        Price = .99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
                if (sweet)
                    Calories *= 2;
            }
        }
        /// <summary>
        /// This is the ingredients method, it returns the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Water",
                    "Tea"
                };
                if (sweet) ingredients.Add("Cane Sugar");
                if (lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        /// <summary>
        /// This is the addlemon method, it adds a lemon.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.size.ToString());
            if (sweet) sb.Append(" Sweet");
            sb.Append(" Tyrannotea");
            return sb.ToString();
        }
    }
}
