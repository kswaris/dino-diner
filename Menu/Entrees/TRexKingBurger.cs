/* TRexKingBurger.cs
 * Author: Sam Waris
 * This is the trexkingburger. It houses things about the burger and extends entree.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the trexkingburger class
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This is the bun bool
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// this is the lettuce bool.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// This is the tomato bool.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// This is the onion bool.
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// This is the pickle bool.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// This is the ketchup bool.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// This is the mustard bool.
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// This is the mayo bool.
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// This is the ingredients list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int x = 0; x < 3; x++)
                    ingredients.Add("Steakburger Pattie");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// This is the description string override.
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// This is the string special override.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> info = new List<string>();
                if (!this.bun) info.Add("Hold Whole Wheat Bun");
                if (!this.lettuce) info.Add("Hold Lettuce");
                if (!this.tomato) info.Add("Hold Tomato");
                if (!this.onion) info.Add("Hold Onion");
                if (!this.pickle) info.Add("Hold Pickle");
                if (!this.ketchup) info.Add("Hold Ketchup");
                if (!this.mustard) info.Add("Hold Mustard");
                if (!this.mayo) info.Add("Hold Mayo");
                return info.ToArray();
            }
        }

        /// <summary>
        /// This is the constructor.
        /// </summary>
        public TRexKingBurger()
        {
            Calories = 728;
            Price = 8.45;
        }
        /// <summary>
        /// This is the bun.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// this holds the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This holds the tomato.
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This holds the onion.
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This holds the pickle.
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// this holds the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This holds the mustard.
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This holds the mayo.
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This is the overridden tostring method.
        /// </summary>
        /// <returns>This is the string</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
