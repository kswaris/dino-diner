/* TyrannoteaTest.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

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
    }
}
