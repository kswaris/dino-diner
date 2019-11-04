/* DinoNuggetsCustomization.xaml.cs
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
    /// Interaction logic for DinoNuggetsCustomization.xaml
    /// </summary>
    public partial class DinoNuggetsCustomization : Page
    {
        private DinoNuggets dn;
        private CretaceousCombo cc;
        /// <summary>
        /// This is the dinonuggets constructor
        /// </summary>
        public DinoNuggetsCustomization()
        {
            InitializeComponent();
            if(DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets dinonuggets)
                    dn = dinonuggets;
        }
        /// <summary>
        /// This is the dinonuggetsconstructor
        /// </summary>
        /// <param name="c">This is a cretacous combo</param>
        public DinoNuggetsCustomization(CretaceousCombo c)
        {
            InitializeComponent();
            this.cc = c;
            this.dn = cc.Entree as DinoNuggets;
        }
        private void AddNuggetClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets dinonuggets)
                    dinonuggets.AddNugget();
            if (cc != null)
            {
                dn.AddNugget();
                cc.Entree = dn;
            }
        }
        private void DoneClick(object sender, RoutedEventArgs args)
        {
            if (cc != null)
                NavigationService.Navigate(new CustomizeCombo(cc));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
