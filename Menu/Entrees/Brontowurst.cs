/* Brontowurst.cs
 * Author: Sam Waris
 * This is the brontowurst class. It houses things about a brontowurst.
 */
using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the brontowurst class.
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// This is the public ingredients property.
        /// </summary>
        public override List<string> Ingredients
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
            Price = 5.36;
            Calories = 498;
        }
        /// <summary>
        /// This is the holdbun method. It holds the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This is the holdpeppers method. It holds the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This is the holdonions method. It holds the onions.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
        /// <summary>
        /// This is the description overridden.
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// This is the special override.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> info = new List<string>();
                if (!this.bun) info.Add("Hold Bun");
                if (!this.peppers) info.Add("Hold Peppers");
                if (!this.onion) info.Add("Hold Onions");
                return info.ToArray();
            }
        }
    }
}
