/* JurrasicJava.cs
 * Author: Sam Waris
 * This is the jurrasicJava class. It houses coffee things.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the jurrassicJava Class
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This is the basic no argument constructor.
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            RoomForCream = false;
            Decaf = false;
            Ice = false;
        }
        /// <summary>
        /// This is the size Size.
        /// </summary>
        private Size size;
        /// <summary>
        /// This is the roomforcream bool.
        /// </summary>
        private bool roomForCream;
        /// <summary>
        /// This is the roomforcream property.
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return this.roomForCream;
            }
            set
            {
                this.roomForCream = value;
                NotifyOfPropertyChanged("RoomForCream");
                NotifyOfPropertyChanged("Special");
            }
        }
        private bool decaf;
        /// <summary>
        /// This is the decaf property.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return this.decaf;
            }
            set
            {
                this.decaf = value;
                NotifyOfPropertyChanged("Decaf");
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// This is the addice method.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }
        /// <summary>
        /// This is the leaveroomforcream method.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// this is the size property.
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
                switch (size)
                {
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// This is the ingredients property. it returns it.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Coffee",
                    "Water"
                };
                return ingredients;
            }
        }
        /// <summary>
        /// This is the tostring method.
        /// </summary>
        /// <returns>This is the overriden string.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.size.ToString());
            if (decaf) sb.Append(" Decaf");
            sb.Append(" Jurassic Java");
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
                if (this.Ice) info.Add("Add Ice");
                if (this.roomForCream) info.Add("Leave Room For Cream");
                return info.ToArray();
            }
        }
    }
}
