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
using DinoDiner.Menu;

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
        private Button HoldIce, AddIce, AddLemon, Sweet, Decaf, Flavor, RoomForCreamButton;
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
            RoomForCreamButton = new Button();
            b.Add(HoldIce);
            b.Add(AddIce);
            b.Add(AddLemon);
            b.Add(Sweet);
            b.Add(Decaf);
            b.Add(Flavor);
            b.Add(RoomForCreamButton);
            foreach (Button bb in b)
            {
                bb.Margin = new System.Windows.Thickness(5);
                bb.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                bb.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                bb.BorderThickness = new Thickness(1);
                bb.Height = 69;
            }
            HoldIce.Content = "Hold Ice";
            HoldIce.Click += IceClick;
            AddIce.Content = "Add Ice";
            AddIce.Click += IceClick;
            AddLemon.Content = "Add Lemon";
            AddLemon.Click += LemonClick;
            Sweet.Content = "Sweeten";
            Sweet.Click += SweetClick;
            Decaf.Content = "Decaf";
            Decaf.Click += DecafClick;
            Flavor.Content = "Flavor";
            RoomForCreamButton.Content = "Room For Cream";
            RoomForCreamButton.Click += RoomForCreamClick;
            Flavor.Click += ToFlavors;
        }
        /// <summary>
        /// This is the tyrannotea setup method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is hte object arguments</param>
        private void TyrannoteaSetup(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new Tyrannotea());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                Clearout();
                FillPanel2.Children.Add(Sweet);
                FillPanel3.Children.Add(AddLemon);
                FillPanel4.Children.Add(HoldIce);
            }
        }
        /// <summary>
        /// This is the sodasaurus setup method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is hte object arguments</param>
        private void SodasaurusSetup(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new Sodasaurus());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                Clearout();
                FillPanel2.Children.Add(Flavor);
                FillPanel3.Children.Add(HoldIce);
            }
        }
        /// <summary>
        /// This is the jurassicjava setup method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is hte object arguments</param>
        private void JurassicJavaSetup(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new JurassicJava());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                Clearout();
                FillPanel2.Children.Add(Decaf);
                FillPanel3.Children.Add(AddIce);
                FillPanel4.Children.Add(RoomForCreamButton);
            }
        }
        /// <summary>
        /// This is the water setup method.
        /// </summary>
        /// <param name="sender">this is the sender</param>
        /// <param name="args">this is hte object arguments</param>
        private void WaterSetup(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new Water());
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                Clearout();
                FillPanel2.Children.Add(AddLemon);
                FillPanel3.Children.Add(HoldIce);
            }
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
        /// <summary>
        /// This is the SideMakeSmall method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void DrinkMakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                    drink.Size = DinoDiner.Menu.Size.Small;
        }
        /// <summary>
        /// This is the SideMakeMedium method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void DrinkMakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                    drink.Size = DinoDiner.Menu.Size.Medium;
        }
        /// <summary>
        /// This is the SideMakeLarge method
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">These are arguments.</param>
        public void DrinkMakeLarge(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                    drink.Size = DinoDiner.Menu.Size.Large;
        }
        /// <summary>
        /// This is the iceclick modifier. It adds/removes ice.
        /// </summary>
        /// <param name="sender">This is the sender object.</param>
        /// <param name="args">This is the arguments</param>
        public void IceClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                    drink.Ice = !drink.Ice;
        }
        /// <summary>
        /// This is the Lemon Click modifier.
        /// </summary>
        /// <param name="sender">This is the sender object.</param>
        /// <param name="args">This is the arguments</param>
        public void LemonClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea t)
                    t.Lemon = !t.Lemon;
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water w)
                    w.Lemon = !w.Lemon;
            }
        }
        /// <summary>
        /// This is the sweet click modifier.
        /// </summary>
        /// <param name="sender">This is the sender object.</param>
        /// <param name="args">This is the arguments</param>
        public void SweetClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea t)
                    t.Sweet = !t.Sweet;
        }
        /// <summary>
        /// This is the decaf click modifier.
        /// </summary>
        /// <param name="sender">This is the sender object.</param>
        /// <param name="args">This is the arguments</param>
        public void DecafClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava jj)
                    jj.Decaf = !jj.Decaf;
        }
        /// <summary>
        /// This is the flavorsclick modifier
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the routed event arguments argument</param>
        public void FlavorsClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
        /// <summary>
        /// This is the roomForCream modifier
        /// </summary>
        /// <param name="sender">This is the sender object</param>
        /// <param name="args">This is the routed event arguments argument</param>
        public void RoomForCreamClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava jj)
                    jj.RoomForCream = !jj.RoomForCream;
        }
        /// <summary>
        /// This returns to the menu
        /// </summary>
        /// <param name="sender">This is the useless sender</param>
        /// <param name="args">This is the useless args</param>
        public void ReturnToMenu(object sender, RoutedEventArgs args)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }
    }
}
