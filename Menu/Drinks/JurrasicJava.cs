﻿/* JurrasicJava.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// This is the jurrassicJava Class
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// This is the basic no argument constructor.
        /// </summary>
        public JurrasicJava()
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
    }
}
