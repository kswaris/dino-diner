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
        /// <summary>
        /// This is the dinonuggets constructor
        /// </summary>
        public DinoNuggetsCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the brontowurst constructor
        /// </summary>
        /// <param name="d">this is the nugget</param>
        public DinoNuggetsCustomization(DinoNuggets d)
        {
            dn = d;
            InitializeComponent();
        }
        private void AddNuggetClick(object sender, RoutedEventArgs arsg)
        {
            if (DataContext is Order order)
                    dn.AddNugget();
        }
        private void DoneClick(object sender, RoutedEventArgs args)
        {
                NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
