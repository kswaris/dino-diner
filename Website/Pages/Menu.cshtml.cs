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
        /// /This is the menu model.
         /// </summary>
        public Menu Menu { get; } = new Menu();

        /// <summary>
        /// This is the onget class.
        /// </summary>
        public void OnGet()
        {

        }
    }
}