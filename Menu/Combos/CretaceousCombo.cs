/* CretaceousCombo.cs
 * Author: Nathan Bean / Sam Waris
 * This is The Cretaceous Combo class.
 */
using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Entree entre steakosaurus by default
        /// </summary>
        private Entree entre = new SteakosaurusBurger();
        /// <summary>
        /// Fryceritops side default.
        /// </summary>
        private Side sid = new Fryceritops();
        /// <summary>
        /// Drink default set to sodasaurus
        /// </summary>
        private Drink drin = new Sodasaurus();
        /// <summary>
        /// The propertychanged eventhandler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Size Property.
        /// </summary>
        private Size size;
        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree {
            get
            {
                return entre;
            }
            set
            {
                entre = value;
                entre.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Entree");
            }
        }
        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side
        {
            get
            {
                return sid;
            }
            set
            {
                sid = value;
                sid.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Side");
            }
        }
        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drin;
            }
            set
            {
                drin = value;
                drin.Size = this.Size;
                drin.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Drink");
            }
        }
        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }
        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Drink");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }
        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
                        NotifyOfPropertyChanged("Entree");

        }
        /// <summary>
        /// This override sthe tostring method and prints it out.
        /// </summary>
        /// <returns>This is the overridden tostring.</returns>
        public override string ToString()
        {
            return this.Entree.ToString() + " Combo";
        }
        /// <summary>
        /// This is the description implementation.
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// This is the special getter property.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> info = new List<string>();
                info.AddRange(this.Entree.Special);
                info.Add(this.Side.Description);
                info.AddRange(this.Side.Special);
                info.Add(this.Drink.Description);
                info.AddRange(this.Drink.Special);
                return info.ToArray();
            }
        }
        /// <summary>
        /// This notifys of the property  changed.
        /// </summary>
        /// <param name="name"></param>
        protected void NotifyOfPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Description");
        }
    }
}