/* ComboSelection.cs
 * Author: Sam Waris
 */
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{ 
    /// <summary>
    /// This is the partial class comboselection
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// This is the default constructor
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the buildcombo method.
        /// </summary>
        /// <param name="sender">This is the sender</param>
        /// <param name="args">This is the argument</param>
        public void BuildCombo(object sender, RoutedEventArgs args)
        {       
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}