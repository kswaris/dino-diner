/* DrinkSelection.cs
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
using System.Drawing;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// This is the holdice/addice/addlemon/sweet/decaf/flavor line. It has private variables.
        /// </summary>
        private Button HoldIce, AddIce, AddLemon, Sweet, Decaf, Flavor;
        /// <summary>
        /// This is the default constructor without arguments
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            ButtonSetup();
        }
        /// <summary>
        /// This is the buttonsetup method.
        /// </summary>
        private void ButtonSetup()
        {
            List<Button> b = new List<Button>();
            HoldIce = new Button();
            AddIce = new Button();
            AddLemon = new Button();
            Sweet = new Button();
            Decaf = new Button();
            Flavor = new Button();
            b.Add(HoldIce);
            b.Add(AddIce);
            b.Add(AddLemon);
            b.Add(Sweet);
            b.Add(Decaf);
            b.Add(Flavor);
            foreach(Button bb in b)
            {
                bb.Margin = new System.Windows.Thickness(5);
                bb.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                bb.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                bb.BorderThickness = new Thickness(1);
                bb.Height = 69;
            }
            HoldIce.Content = "Hold Ice";
            AddIce.Content = "Add Ice";
            AddLemon.Content = "Add Lemon";
            Sweet.Content = "Sweeten";
            Decaf.Content = "Decaf";
            Flavor.Content = "Flavor";
            Flavor.Click += ToFlavors;
        }
        /// <summary>
        /// This is the tyrannotea setup method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is hte object arguments</param>
        private void TyrannoteaSetup(object sender, RoutedEventArgs args)
        {
            Clearout();
            FillPanel2.Children.Add(Sweet);
            FillPanel3.Children.Add(AddLemon);
            FillPanel4.Children.Add(HoldIce);
        }
        /// <summary>
        /// This is the sodasaurus setup method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is hte object arguments</param>
        private void SodasaurusSetup(object sender, RoutedEventArgs args)
        {
            Clearout();
            FillPanel2.Children.Add(Flavor);
            FillPanel3.Children.Add(AddLemon);
            FillPanel4.Children.Add(HoldIce);
        }
        /// <summary>
        /// This is the jurassicjava setup method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is hte object arguments</param>
        private void JurassicJavaSetup(object sender, RoutedEventArgs args)
        {
            Clearout();
            FillPanel2.Children.Add(Decaf);
            FillPanel3.Children.Add(AddIce);
        }
        /// <summary>
        /// This is the water setup method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is hte object arguments</param>
        private void WaterSetup(object sender, RoutedEventArgs args)
        {
            Clearout();
            FillPanel2.Children.Add(AddLemon);
            FillPanel3.Children.Add(HoldIce);
        }
        /// <summary>
        /// This is the clearoutmethod.
        /// </summary>
        private void Clearout()
        {
            FillPanel2.Children.Clear();
            FillPanel3.Children.Clear();
            FillPanel4.Children.Clear();
            FillPanel5.Children.Clear();
        }
        /// <summary>
        /// This is the toflavors method.
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the routedevent argument object</param>
        public void ToFlavors(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

    }
}
