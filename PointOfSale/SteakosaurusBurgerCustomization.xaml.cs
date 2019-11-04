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
        private CretaceousCombo cc;
        /// <summary>
        /// This is the steakosaurusburger constructor
        /// </summary>
        public SteakosaurusBurgerCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                    sb = steakosaurusburger;
        }
        /// <summary>
        /// This is the doneclick method.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the object argument</param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
                NavigationService.Navigate(new CustomizeCombo(cc));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void BunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                    steakosaurusburger.HoldBun();
            if (cc != null)
            {
                sb.HoldBun();
                cc.Entree = sb;
            }
        }
        private void PickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                    steakosaurusburger.HoldPickle();
            if (cc != null)
            {
                sb.HoldPickle();
                cc.Entree = sb;
            }
        }
        private void MustardClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                    steakosaurusburger.HoldMustard();
            if (cc != null)
            {
                sb.HoldMustard();
                cc.Entree = sb;
            }
        }
        private void KetchupClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger steakosaurusburger)
                    steakosaurusburger.HoldKetchup();
            if (cc != null)
            {
                sb.HoldKetchup();
                cc.Entree = sb;
            }
        }
        /// <summary>
        /// This is the steakosaurusburger customizer.
        /// </summary>
        /// <param name="cc">this is the combo</param>
        public SteakosaurusBurgerCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.sb = cc.Entree as SteakosaurusBurger;
        }
    }
}
