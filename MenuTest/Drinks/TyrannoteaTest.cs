/* TyrannoteaTest.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void CorrectDefaultValue()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<double>(.99, t.Price);
            Assert.Equal<uint>(8, t.Calories);
            Assert.Equal<Size>(Size.Small, t.Size);
            Assert.True(t.Ice);
            Assert.False(t.Lemon);
            Assert.False(t.Sweet);
        }
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.Size = Size.Small;
            Assert.Equal<double>(.99, t.Price);

        }
        [Fact]
        public void CorrectcaloriesAfterSettingSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.Size = Size.Small;
            Assert.Equal<uint>(8, t.Calories);
        }
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<double>(1.49, t.Price);
        }
        [Fact]
        public void CorrectcaloriesAfterSettingMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
        }
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<double>(1.99, t.Price);
        }
        [Fact]
        public void CorrectcaloriesAfterSettingLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
        }
        [Fact]
        public void HoldIceCheck()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.False(t.Ice);
        }
        [Fact]
        public void AddLemonCheck()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.True(t.Lemon);
        }
        [Fact]
        public void SetSweetTrue()
        {
            Tyrannotea t = new Tyrannotea();
            t.Sweet = true;
            Assert.Equal<uint>(16, t.Calories);
            t.Size = Size.Medium;
            Assert.Equal<uint>(32, t.Calories);
            t.Size = Size.Large;
            Assert.Equal<uint>(64, t.Calories);
        }
        [Fact]
        public void SetSweetFalse()
        {
            Tyrannotea t = new Tyrannotea();
            t.Sweet = true;
            t.Sweet = false;
            t.Size = Size.Small;
            Assert.Equal<uint>(8, t.Calories);
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
        }
        [Fact]
        public void DefaultIngredients()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Contains<string>("Water", t.Ingredients);
            Assert.Contains<string>("Tea", t.Ingredients);
            Assert.Equal<int>(2, t.Ingredients.Count);
        }
        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaDescriptionTest(Size sz, bool sw)
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = sz;
            t.Sweet = sw;
            if (sw) Assert.Equal(sz + " Sweet Tyrannotea", t.Description);
            else Assert.Equal(sz + " Tyrannotea", t.Description);
        }
        [Fact]
        public void TyrannoTeaSpecialsTest()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Empty(t.Special);
            t.AddLemon();
            Assert.Contains("Add Lemon", t.Special);
            t.HoldIce();
            Assert.Contains("Hold Ice", t.Special);
        }
    }
}
