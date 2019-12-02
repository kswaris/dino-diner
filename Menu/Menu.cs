/* Menu.cs
 * Author: Sam Waris
 * This is the menu.cs class. It houses things.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

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
        /// This is the possible ingredients method. It 
        /// </summary>
        public HashSet<string> PossibleIngredients
        {
            get
            {
                HashSet<string> possibleIngredients = new HashSet<string>();
                /*
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    foreach (string ingredient in item.Ingredients)
                    {
                        possibleIngredients.Add(ingredient);
                    }
                }
                return possibleIngredients;*/
                foreach (Entree e in AvailableEntrees)
                {
                    possibleIngredients.UnionWith(e.Ingredients);
                }

                foreach (Side s in AvailableSides)
                {
                    possibleIngredients.UnionWith(s.Ingredients);
                }

                foreach (Drink d in AvailableDrinks)
                {
                    possibleIngredients.UnionWith(d.Ingredients);
                }
                return possibleIngredients;
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
        /// <summary>
        /// This is used for filtering by category
        /// </summary>
        /// <param name="items">These are the items you're searching by</param>
        /// <param name="search">This is the term you're searching with</param>
        /// <returns>This is the list of results.</returns>
        public List<IMenuItem>[] CategoryFilter(List<IMenuItem>[] items, List<string> search)
        {
            List<IMenuItem>[] results = new List<IMenuItem>[4];
            for (int i = 0; i < results.Length; i++)
                results[i] = new List<IMenuItem>();
            if (search.Contains("Combo", StringComparer.OrdinalIgnoreCase))
                results[0].AddRange(items[0]);
            if (search.Contains("Entree", StringComparer.OrdinalIgnoreCase))
                results[1].AddRange(items[1]);
            if (search.Contains("Side", StringComparer.OrdinalIgnoreCase))
                results[2].AddRange(items[2]);
            if (search.Contains("Drink", StringComparer.OrdinalIgnoreCase))
                results[3].AddRange(items[3]);

            return results;
        }
        /// <summary>
        /// This is the pricefilter method.
        /// </summary>
        /// <param name="items">This is the list of items you're searching through</param>
        /// <param name="minPrice">This is the minimum price you want.</param>
        /// <param name="maxPrice">This is the maxmimum price you want</param>
        /// <returns>This is the list of results.</returns>
        public List<IMenuItem>[] PriceFilter(List<IMenuItem>[] items, float minPrice, float maxPrice)
        {
            List<IMenuItem>[] results = new List<IMenuItem>[4];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = new List<IMenuItem>();

                foreach (IMenuItem item in items[i])
                    if (item.Price <= maxPrice && item.Price >= minPrice)
                        results[i].Add(item);
            }
            return results;
        }
        /// <summary>
        /// This is the filter by ingredients method.
        /// </summary>
        /// <param name="items">This is the list you're filtering.</param>
        /// <param name="removedIngredients">This is the listblacklist</param>
        /// <returns></returns>
        public List<IMenuItem>[] IngredientsFilter(List<IMenuItem>[] items, List<string> removedIngredients)
        {
            List<IMenuItem>[] results = new List<IMenuItem>[4];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = new List<IMenuItem>();
                foreach (IMenuItem menuItem in items[i])
                    if (menuItem is IOrderItem item)
                    {
                        bool has = false;
                        foreach (string ing in removedIngredients)
                            if (item.Ingredients.Contains(ing, StringComparer.OrdinalIgnoreCase))
                            {
                                has = true;
                                break;
                            }
                        if (has == false)
                            results[i].Add(menuItem);


                    }
            }
            return results;
        }
        /// <summary>
        /// This is the search with phrase method.
        /// </summary>
        /// <param name="items">This is the items you're searching throug</param>
        /// <param name="phrase">This is the phrase you're searching with</param>
        /// <param name="ingredients">This is the list of ingredients.</param>
        /// <returns></returns>
        public List<IMenuItem>[] SearchWithPhrase(List<IMenuItem>[] items, string phrase, bool ingredients)
        {
            List<IMenuItem>[] results = new List<IMenuItem>[4];
            for (int x = 0; x < results.Length; x++)
                results[x] = new List<IMenuItem>();
            foreach (IMenuItem menuItem in items[0])
                if (menuItem is CretaceousCombo combo)
                {
                    if (combo.Description.IndexOf(phrase, StringComparison.OrdinalIgnoreCase) >= 0 || combo.Side.Description.IndexOf(phrase, StringComparison.OrdinalIgnoreCase) >= 0 || combo.Drink.Description.IndexOf(phrase, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        results[0].Add(combo);
                        continue;
                    }
                    if (ingredients)
                        if (combo.Ingredients.Contains(phrase, StringComparer.OrdinalIgnoreCase))
                            results[0].Add(combo);
                }
            for (int x = 1; x < items.Length; x++)
                foreach (IMenuItem menuItem in items[x])
                    if (menuItem is IOrderItem item)
                    {
                        if (item.Description.IndexOf(phrase, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            results[x].Add(menuItem);
                            continue;
                        }
                        if (ingredients)
                            if (item.Ingredients.Contains(phrase, StringComparer.OrdinalIgnoreCase))
                                results[x].Add(menuItem);
                    }
            return results;
        }

    }
}
