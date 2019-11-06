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
        /// <summary>
        /// This is the trexkingburger construcotr
        /// </summary>
        public TRexKingBurgerCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the trex constructor
        /// </summary>
        /// <param name="tr">this is the trex</param>
        public TRexKingBurgerCustomization(TRexKingBurger tr)
        {
            this.tr = tr;
            InitializeComponent();
        }
        private void KetchupClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    tr.HoldKetchup();
        }
        private void MustardClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    tr.HoldMustard();
        }
        private void PickleClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                tr.HoldPickle();
        }
        private void BunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    tr.HoldBun();
        }
        private void OnionClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                tr.HoldOnion();
        }
        private void MayoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    tr.HoldMayo();
        }
        private void LettuceClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    tr.HoldLettuce(); 
        }
        private void TomatoClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                tr.HoldTomato();
        }
        /// <summary>
        /// This is the done method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is the argument</param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
