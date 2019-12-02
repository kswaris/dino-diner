/* Menu.cshtml.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
namespace Website.Pages
{
    /// <summary>
    /// This is the menumodel class.
    /// </summary>
    public class MenuModel : PageModel
    {
        /// <summary>
        /// This is the menu menu.
        /// </summary>
        public Menu Menu { get; set; } = new Menu();
        /// <summary>
        /// This is the list of items, that is a list of imenuitme.s
        /// </summary>
        public List<IMenuItem>[] items;
        /// <summary>
        /// This is the removedIngredientslist.
        /// </summary>
        [BindProperty]
        public List<string> removedIngredients { get; set; } = new List<string>();
        /// <summary>
        /// This is the max price float.
        /// </summary>
        [BindProperty]
        public float? maxprice { get; set; } = null;
        /// <summary>
        /// This is the minprice float.
        /// </summary>
        [BindProperty]
        public float? minprice { get; set; } = null;
        /// <summary>
        /// This is the menucategory list.
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        /// <summary>
        /// This is the searchingredients bool.
        /// </summary>
        [BindProperty]
        public bool SearchIngredients { get; set; } = false;
        /// <summary>
        /// This is the search string.
        /// </summary>
        [BindProperty]
        public string search { get; set; } = null;
        /// <summary>
        /// This is the private item setup method.
        /// </summary>
        private void ItemSetup()
        {
            items = new List<IMenuItem>[4];
            items[0] = new List<IMenuItem>();
            items[0].AddRange(Menu.AvailableCombos);
            items[1] = new List<IMenuItem>();
            items[1].AddRange(Menu.AvailableEntrees);
            items[2] = new List<IMenuItem>();
            items[2].AddRange(Menu.AvailableSides);
            items[3] = new List<IMenuItem>();
            items[3].AddRange(Menu.AvailableDrinks);
        }
        /// <summary>
        /// This is the onget method.
        /// </summary>
        public void OnGet()
        {
            ItemSetup();
        }
        /// <summary>
        /// This is used for checking if the list of items is completely empty.
        /// </summary>
        public bool EmptyItems
        {
            get
            {
                if (items[0].Count == 0 && items[1].Count == 0 && items[2].Count == 0 && items[3].Count == 0)
                    return true;
                else
                    return false;
            }
        }
        /// <summary>
        /// This is the method that handles search button clicks.
        /// </summary>
        public void OnPost()
        {
            ItemSetup();
            if(menuCategory.Count > 0)
                items = Menu.CategoryFilter(items, menuCategory);
            if (minprice is float min && maxprice is float max)
            {
                items = Menu.PriceFilter(items, min, max);
            }            
            else if (maxprice is float max1)
            {
                items = Menu.PriceFilter(items, float.MinValue, max1);
            }
            else if (minprice is float min1)
            {
                items = Menu.PriceFilter(items, min1, float.MaxValue);
            }
            if (search != null && search != "")
                items = Menu.SearchWithPhrase(items, search, SearchIngredients);
        }
    }
}