/* BrontowurstCustomization.xaml.cs
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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        private CretaceousCombo cc;
        private Brontowurst bw;
        /// <summary>
        /// This is the brontowusrt construcotr
        /// </summary>
        public BrontowurstCustomization()
        {
            InitializeComponent();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst brontowurst)
                    bw = brontowurst;
            }
        }
        /// <summary>
        /// This is the constructor
        /// </summary>
        /// <param name="c">This is the combo</param>
        public BrontowurstCustomization(CretaceousCombo c)
        {
            InitializeComponent();
            this.cc = c;
            this.bw = c.Entree as Brontowurst;
        }
        private void PepperClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst brontowurst)
                    brontowurst.HoldPeppers();
            if (cc != null)
            {
                bw.HoldPeppers();
                cc.Entree = bw;
            }
        }
        private void BunClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst brontowurst)
                    brontowurst.HoldBun();
            if (cc != null)
            {
                bw.HoldBun();
                cc.Entree = bw;
            }
        }
        private void OnionClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst brontowurst)
                    brontowurst.HoldOnion();
            if (cc != null)
            {
                bw.HoldOnion();
                cc.Entree = bw;
            }
        }
        private void DoneClick(object sender, RoutedEventArgs arsg)
        {
            if (cc != null)
                NavigationService.Navigate(new CustomizeCombo(cc));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
