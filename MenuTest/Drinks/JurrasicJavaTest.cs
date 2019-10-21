/* JurrasicJavaTest.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void DefaultValues()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<Size>(jj.Size, Size.Small);
            Assert.False(jj.Ice);
            Assert.False(jj.RoomForCream);
            Assert.False(jj.Decaf);
            Assert.Equal<double>(jj.Price, .59);
            Assert.Equal<uint>(jj.Calories, 2);
        }
        [Fact]
        public void CorrectAfterSettingSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            jj.Size = Size.Small;
            Assert.Equal<double>(.59, jj.Price);
            Assert.Equal<uint>(2, jj.Calories);
            Assert.Equal<Size>(jj.Size, Size.Small);
        }
        [Fact]
        public void CorrectAfterSettingMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(.99, jj.Price);
            Assert.Equal<uint>(4, jj.Calories);
            Assert.Equal<Size>(jj.Size, Size.Medium);
        }
        [Fact]
        public void CorrectAfterSettingLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
            Assert.Equal<uint>(8, jj.Calories);
            Assert.Equal<Size>(jj.Size, Size.Large);
        }
        [Fact]
        public void AddIceCheck()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }
        [Fact]
        public void LeaveSpaceForCreamCheck()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }
        [Fact]
        public void DefaultIngredients()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Contains("Water", jj.Ingredients);
            Assert.Contains<string>("Coffee", jj.Ingredients);
            Assert.Equal<int>(2, jj.Ingredients.Count);
        }
        [Theory]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        public void JurassicJavaDescriptionTest(Size s, bool d)
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = s;
            jj.Decaf = d;
            if (d) Assert.Equal(s + " Decaf Jurassic Java", jj.Description);
            else Assert.Equal(s + " Jurassic Java", jj.Description);
        }
        [Fact]
        public void JurassicJavaSpecialTest()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Empty(jj.Special);
            jj.AddIce();
            Assert.Contains("Add Ice", jj.Special);
            jj.LeaveRoomForCream();
            Assert.Contains("Leave Room For Cream", jj.Special);
        }
    }
}
