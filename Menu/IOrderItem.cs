/* IOrderItem.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the iorderitem interface.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// This is the price double getter property.
        /// </summary>
        double Price { get; }
        /// <summary>
        /// This is the description getter property.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// This is the special string array getter property.
        /// </summary>
        string[] Special { get; }
    }
}
