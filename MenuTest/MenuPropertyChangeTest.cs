using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MenuPropertyChangeTest
    {
        [Fact]
        public void CretaceousComboPropertyChanges()
        {
            CretaceousCombo cc = new CretaceousCombo(new TRexKingBurger());
            Assert.PropertyChanged(cc, "Special", () => cc.Entree = new PrehistoricPBJ());
            Assert.PropertyChanged(cc, "Entree", () => cc.Entree = new PrehistoricPBJ());
            Assert.PropertyChanged(cc, "Special", () => cc.Side = new MezzorellaSticks());
            Assert.PropertyChanged(cc, "Side", () => cc.Side = new MezzorellaSticks());
            Assert.PropertyChanged(cc, "Special", () => cc.Drink = new Water());
            Assert.PropertyChanged(cc, "Drink", () => cc.Drink = new Water());
        }
        [Fact]
        public void JurassicJavaPropertyChanges()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Size", () => jj.Size = Size.Large);
            Assert.PropertyChanged(jj, "Price", () => jj.Size = Size.Large);
            Assert.PropertyChanged(jj, "Calories", () => jj.Size = Size.Large);
            Assert.PropertyChanged(jj, "Description", () => jj.Size = Size.Large);
            Assert.PropertyChanged(jj, "RoomForCream", () => jj.RoomForCream = true);
            Assert.PropertyChanged(jj, "Special", () => jj.RoomForCream = true);
            Assert.PropertyChanged(jj, "Decaf", () => jj.Decaf = true);
            Assert.PropertyChanged(jj, "Description", () => jj.Decaf = true);
            Assert.PropertyChanged(jj, "Ice", () => jj.Ice = true);
            Assert.PropertyChanged(jj, "Special", () => jj.Ice = true);
        }
        [Fact]
        public void SodasaurusPropertyChanges()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.PropertyChanged(ss, "Description", () => ss.Flavor = SodasaurusFlavor.Cherry);
            Assert.PropertyChanged(ss, "Flavor", () => ss.Flavor = SodasaurusFlavor.Cherry);
            Assert.PropertyChanged(ss, "Ice", () => ss.Ice = true);
            Assert.PropertyChanged(ss, "Special", () => ss.Ice = true);
            Assert.PropertyChanged(ss, "Size", () => ss.Size = Size.Large);
            Assert.PropertyChanged(ss, "Price", () => ss.Size = Size.Large);
            Assert.PropertyChanged(ss, "Calories", () => ss.Size = Size.Large);
            Assert.PropertyChanged(ss, "Description", () => ss.Size = Size.Large);
        }
        [Fact]
        public void TyrannoteaPropertyChanges()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Sweet", () => tt.Sweet = true);
            Assert.PropertyChanged(tt, "Lemon", () => tt.Lemon = true);
            Assert.PropertyChanged(tt, "Special", () => tt.Lemon = true);
            Assert.PropertyChanged(tt, "Ice", () => tt.Ice = true);
            Assert.PropertyChanged(tt, "Special", () => tt.Ice = true);
            Assert.PropertyChanged(tt, "Size", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Price", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Calories", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Description", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Description", () => tt.Sweet = true);
            Assert.PropertyChanged(tt, "Calories", () => tt.Sweet = false);
        }
        [Fact]
        public void WaterPropertyChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Description", () => w.Size = Size.Large);
            Assert.PropertyChanged(w, "Size", () => w.Size = Size.Large);
            Assert.PropertyChanged(w, "Lemon", () => w.Lemon = true);
            Assert.PropertyChanged(w, "Special", () => w.Lemon = true);
            Assert.PropertyChanged(w, "Ice", () => w.Ice = true);
            Assert.PropertyChanged(w, "Special", () => w.Ice = true);
        }
        [Fact]
        public void BrontowurstPropertyChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () => bw.HoldBun());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldOnion());
            Assert.PropertyChanged(bw, "Special", () => bw.HoldPeppers());
        }
        [Fact]
        public void DinoNuggetsPropertyChange()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, "Special", () => dn.AddNugget());
            Assert.PropertyChanged(dn, "Price", () => dn.AddNugget());
            Assert.PropertyChanged(dn, "Calories", () => dn.AddNugget());
        }
        [Fact]
        public void PrehistoricPBJPropertyChanges()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.PropertyChanged(pbj, "Special", () => pbj.HoldPeanutButter());
            Assert.PropertyChanged(pbj, "Special", () => pbj.HoldJelly());
        }
        [Fact]
        public void SteakosaurusBurgerPropertyChanges()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.PropertyChanged(sb, "Special", () => sb.HoldPickle());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldBun());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldMustard());
            Assert.PropertyChanged(sb, "Special", () => sb.HoldKetchup());
        }
        [Fact]
        public void TRexKingBurgerPropertyChanges()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => trex.HoldBun());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldPickle());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldKetchup());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldMustard());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldTomato());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldOnion());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldMayo());
            Assert.PropertyChanged(trex, "Special", () => trex.HoldLettuce());
        }
        [Fact]
        public void VelociWrapPropertyChanges()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () => vw.HoldCheese());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldDressing());
            Assert.PropertyChanged(vw, "Special", () => vw.HoldLettuce());
        }
        [Fact]
        public void FryceritopsPropertyChanges()
        {
            Fryceritops ft = new Fryceritops();
            Assert.PropertyChanged(ft, "Size", () => ft.Size = Size.Large);
            Assert.PropertyChanged(ft, "Price", () => ft.Size = Size.Large);
            Assert.PropertyChanged(ft, "Calories", () => ft.Size = Size.Large);
            Assert.PropertyChanged(ft, "Description", () => ft.Size = Size.Large);
        }
        [Fact]
        public void MeteorMacAndCheeseProperty()
        {
            MeteorMacAndCheese mc = new MeteorMacAndCheese();
            Assert.PropertyChanged(mc, "Size", () => mc.Size = Size.Large);
            Assert.PropertyChanged(mc, "Price", () => mc.Size = Size.Large);
            Assert.PropertyChanged(mc, "Calories", () => mc.Size = Size.Large);
            Assert.PropertyChanged(mc, "Description", () => mc.Size = Size.Large);
        }
        [Fact]
        public void MezzorellaSticksProperty()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, "Size", () => ms.Size = Size.Large);
            Assert.PropertyChanged(ms, "Price", () => ms.Size = Size.Large);
            Assert.PropertyChanged(ms, "Calories", () => ms.Size = Size.Large);
            Assert.PropertyChanged(ms, "Description", () => ms.Size = Size.Large);
        }
        [Fact]
        public void TriceritotsPropertyChanges()
        {
            Triceritots tt = new Triceritots();
            Assert.PropertyChanged(tt, "Size", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Price", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Calories", () => tt.Size = Size.Large);
            Assert.PropertyChanged(tt, "Description", () => tt.Size = Size.Large);
        }
    }
}
