using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    
    public class SodasaurusTest
    {
        [Fact]
        public void CorrectFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
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
        [Fact]
        public void DefaultIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }
        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodasaurusDescriptionTest(Size s, SodasaurusFlavor f)
        {
            Sodasaurus ss = new Sodasaurus();
            ss.Size = s;
            ss.Flavor = f;
            Assert.Equal(s.ToString() + " " + f.ToString() + " Sodasaurus", ss.Description);
        }
        [Fact]
        public void SodasaurusSpecialTest()
        {
            Sodasaurus ss = new Sodasaurus();
            Assert.Empty(ss.Special);
            ss.HoldIce();
            Assert.Contains("Hold Ice", ss.Special);
        }
    }
}
