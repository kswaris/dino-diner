/* FlavorSelection.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// This is the flavor selection default constructor
        /// </summary>
        private CretaceousCombo cc;
        private Sodasaurus soda;
        /// <summary>
        /// This is the no argument constructor.
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the flavor selection with an argument
        /// </summary>
        /// <param name="cc">this the combo</param>
        public FlavorSelection(CretaceousCombo cc)
        {
            this.cc = cc;
            this.soda = cc.Drink as Sodasaurus;
            InitializeComponent();
        }
        /// <summary>
        /// This is the cola click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void ColaClick(object sender, RoutedEventArgs args)
        {
            if(cc != null)
            {
                soda.Flavor = SodasaurusFlavor.Cola;
                cc.Drink = soda;
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
                soda.Flavor = SodasaurusFlavor.Cola;
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the orange click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void OrangeClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
            {
                soda.Flavor = SodasaurusFlavor.Orange;
                cc.Drink = soda;
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
                soda.Flavor = SodasaurusFlavor.Orange;
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the vanilla click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void VanillaClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
            {
                soda.Flavor = SodasaurusFlavor.Vanilla;
                cc.Drink = soda;
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
                soda.Flavor = SodasaurusFlavor.Vanilla;
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the chocolate click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void ChocolateClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
            {
                soda.Flavor = SodasaurusFlavor.Chocolate;
                cc.Drink = soda;
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
                soda.Flavor = SodasaurusFlavor.Chocolate;
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the rootbeer click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void RootBeerClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
            {
                soda.Flavor = SodasaurusFlavor.RootBeer;
                cc.Drink = soda;
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
                soda.Flavor = SodasaurusFlavor.RootBeer;
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the cherry click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void CherryClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
            {
                soda.Flavor = SodasaurusFlavor.Cherry;
                cc.Drink = soda;
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
                soda.Flavor = SodasaurusFlavor.Cherry;
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This is the lime click 
        /// </summary>
        /// <param name="sender">useless sender</param>
        /// <param name="args">useless arguments</param>
        public void LimeClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
            {
                soda.Flavor = SodasaurusFlavor.Lime;
                cc.Drink = soda;
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
                soda.Flavor = SodasaurusFlavor.Lime;
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
        /// <summary>
        /// This returns to the menu
        /// </summary>
        /// <param name="sender">This is the useless sender</param>
        /// <param name="args">This is the useless args</param>
        public void ReturnToMenu(object sender, RoutedEventArgs args)
        {
            NavigationService?.Navigate(new DrinkSelection());
        }
    }
}
