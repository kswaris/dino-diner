/* TRexKingBurgerCustomization.xaml.cs
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
    /// Interaction logic for TRexKingBurgerCustomization.xaml
    /// </summary>
    public partial class TRexKingBurgerCustomization : Page
    {
        private TRexKingBurger tr;
        private CretaceousCombo cc;
        /// <summary>
        /// This is the trexkingburger construcotr
        /// </summary>
        public TRexKingBurgerCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    tr = trexkingburger;
        }
        /// <summary>
        /// This is the construcotr
        /// </summary>
        /// <param name="cc">this is hte combo you are passing</param>
        public TRexKingBurgerCustomization(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
            this.tr = cc.Entree as TRexKingBurger;
        }
        private void KetchupClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    trexkingburger.HoldKetchup();
            if (cc != null)
            {
                tr.HoldKetchup();
                cc.Entree = tr;
            }
        }
        private void MustardClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    trexkingburger.HoldMustard();
            if (cc != null)
            {
                tr.HoldMustard();
                cc.Entree = tr;
            }
        }
        private void PickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    trexkingburger.HoldPickle();
            if (cc != null)
            {
                tr.HoldPickle();
                cc.Entree = tr;
            }
        }
        private void BunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    trexkingburger.HoldBun();
            if (cc != null)
            {
                tr.HoldBun();
                cc.Entree = tr;
            }
        }
        private void OnionClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    trexkingburger.HoldOnion();
            if (cc != null)
            {
                tr.HoldOnion();
                cc.Entree = tr;
            }
        }
        private void MayoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    trexkingburger.HoldMayo();
            if (cc != null)
            {
                tr.HoldMayo();
                cc.Entree = tr;
            }
        }
        private void LettuceClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    trexkingburger.HoldLettuce();
            if (cc != null)
            {
                tr.HoldLettuce();
                cc.Entree = tr;
            }
        }
        private void TomatoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger trexkingburger)
                    trexkingburger.HoldTomato();
            if (cc != null)
            {
                tr.HoldTomato();
                cc.Entree = tr;
            }
        }
        /// <summary>
        /// This is the done method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the argument</param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
                NavigationService.Navigate(new CustomizeCombo(cc));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
