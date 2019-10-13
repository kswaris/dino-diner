/* MenuCategorySelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// This is the menucategoryselection constructor
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the comboselect method.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the argument object</param>
        public void ComboSelect(Object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        /// <summary>
        /// This is the entreeselect method.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the argument object</param>
        public void EntreeSelect(Object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// This is the sideselect method.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the argument object</param>
        public void SideSelect(Object sender,RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// This is the drinkselect method.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the argument object</param>
        public void DrinkSelect(Object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
