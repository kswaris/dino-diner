/*SideSelection.xaml.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// This is the order variable
        /// </summary>
        public Order order = new Order();
        /// <summary>
        /// This is the sideselection method.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds fryceritops
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Routed event args</param>
        public void AddFryceritops(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Items.Add(new Fryceritops());
            }
        }
    }
}
