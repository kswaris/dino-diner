/* Menu.cs
 * Author: Sam Waris
 * This is the menu.cs class. It houses things.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This defines the menu class.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// This is the availableMenuItems list.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add((IMenuItem)AvailableEntrees);
                items.Add((IMenuItem)AvailableCombos);
                items.Add((IMenuItem)AvailableDrinks);
                items.Add((IMenuItem)AvailableSides);
                return items;
            }
        }
        /// <summary>
        /// This is the availabledrinks preopterty.
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> items = new List<Drink>();
                items.Add(new JurassicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());
                return items;
            }
        }
        /// <summary>
        /// This returns a list of possible sides.
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> s = new List<Side>();
                s.Add(new Fryceritops());
                s.Add(new MeteorMacAndCheese());
                s.Add(new MezzorellaSticks());
                s.Add(new Triceritots());
                return s;
            }
        }
        /// <summary>
        /// This is the available combos method.
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> cc = new List<CretaceousCombo>();
                for (int x = 0; x < AvailableEntrees.Count; x++)
                    cc.Add(new CretaceousCombo(AvailableEntrees[x]));
                return cc;
            }
        }
        /// <summary>
        /// This is the availableEntree list getter property.
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> e = new List<Entree>();
                e.Add(new Brontowurst());
                e.Add(new DinoNuggets());
                e.Add(new PrehistoricPBJ());
                e.Add(new SteakosaurusBurger());
                e.Add(new TRexKingBurger());
                e.Add(new PterodactylWings());
                e.Add(new VelociWrap());
                return e;
            }
        }
        /// <summary>
        /// This is the tostring override.
        /// </summary>
        /// <returns>This string contains information.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int x = 0; x < AvailableMenuItems.Count; x++)
                sb.Append(AvailableMenuItems[x] + "\n");
            return sb.ToString();
        }
    }
}
