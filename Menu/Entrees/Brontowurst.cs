/* Brontowurst.cs
 * Author: Sam Waris
 */
using System.Collections.Generic;
namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        /// <summary>
        /// This is the private variable, bun. It is whether or not you hold the bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// This is the private variable, pepper. It is whether or not you hold the peppers.
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// This is the private onions variable. It is whether not you hold the onions.
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// This is the double price. It has getters and setters.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This is the uint calories. It has getters and setters.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This is the public ingredients property.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// This is the brontowurst constructor.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// This is the holdbun method. It holds the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// This is the holdpeppers method. It holds the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// This is the holdonions method. It holds the onions.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}
