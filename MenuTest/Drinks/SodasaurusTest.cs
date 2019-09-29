using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    
    public class SodasaurusTest
    {
        [Fact]
        public void CorrectFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = Flavor.Cola;
            Assert.Equal<Flavor>(Flavor.Cola, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = Flavor.Orange;
            Assert.Equal<Flavor>(Flavor.Orange, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = Flavor.Vanilla;
            Assert.Equal<Flavor>(Flavor.Vanilla, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = Flavor.Chocolate;
            Assert.Equal<Flavor>(Flavor.Chocolate, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = Flavor.RootBeer;
            Assert.Equal<Flavor>(Flavor.RootBeer, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = Flavor.Cherry;
            Assert.Equal<Flavor>(Flavor.Cherry, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = Flavor.Lime;
            Assert.Equal<Flavor>(Flavor.Lime, soda.Flavor);
        }
        [Fact]
        public void CorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(soda.Price, 1.50);
        }
        [Fact]
        public void CorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(soda.Calories, 112);
        }
        [Fact]
        public void CorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }
        [Fact]
        public void CorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Small;
            Assert.Equal<double>(soda.Price, 1.50);
        }
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Small;
            Assert.Equal<uint>(soda.Calories, 112);
        }
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Medium;
            Assert.Equal<double>(soda.Price, 2.00);
        }
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Medium;
            Assert.Equal<uint>(soda.Calories, 156);
        }
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<double>(soda.Price, 2.50);
        }
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<uint>(soda.Calories, 208);
        }
        [Fact]
        public void HoldIceCheck()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
    }
}
