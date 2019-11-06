/* SteakosaurusBurgerCustomization.xaml.cs
 * Author: sam Waris
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
    /// Interaction logic for SteakosaurusBurgerCustomization.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomization : Page
    {
        private SteakosaurusBurger sb;
        /// <summary>
        /// This is the steakosaurusburger constructor
        /// </summary>
        public SteakosaurusBurgerCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the doneclick method.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the object argument</param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void BunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    sb.HoldBun();
        }
        private void PickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    sb.HoldPickle();
        }
        private void MustardClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    sb.HoldMustard();
        }
        /// <summary>
         /// This is the steakburger constructor
         /// </summary>
         /// <param name="bw">this is the wurst</param>
        public SteakosaurusBurgerCustomization(SteakosaurusBurger sb)
        {
            this.sb = sb;
            InitializeComponent();
        }
        private void KetchupClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    sb.HoldKetchup();
        }
    }
}
