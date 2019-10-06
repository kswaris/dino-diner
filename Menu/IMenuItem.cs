/* IMenuItem.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// IMenuItem interface
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price Getter
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Calories Getter
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Ingredients Getter
        /// </summary>
        List<string> Ingredients { get; }
    }
}
