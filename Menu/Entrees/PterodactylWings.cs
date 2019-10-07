/* PterodactylWings.cs
 * Author: Sam Waris
 * This is the pterodactyl wings class. It has details about the wings.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the pterodacylwings class
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem
    {
        /// <summary>
        /// This is the ingredients, it returns the list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Chicken",
                    "Wing Sauce"
                };
                return ingredients;
            }
        }
        /// <summary>
        /// This is pterodactylWings constructor.
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
