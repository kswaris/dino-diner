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
            JurrasicJava jj = new JurrasicJava();
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
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            jj.Size = Size.Small;
            Assert.Equal<double>(.59, jj.Price);
            Assert.Equal<uint>(2, jj.Calories);
            Assert.Equal<Size>(jj.Size, Size.Small);
        }
        [Fact]
        public void CorrectAfterSettingMedium()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(.99, jj.Price);
            Assert.Equal<uint>(4, jj.Calories);
            Assert.Equal<Size>(jj.Size, Size.Medium);
        }
        [Fact]
        public void CorrectAfterSettingLarge()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
            Assert.Equal<uint>(8, jj.Calories);
            Assert.Equal<Size>(jj.Size, Size.Large);
        }
        [Fact]
        public void AddIceCheck()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }
        public void LeaveSpaceForCreamCheck()
        {
            JurrasicJava jj = new JurrasicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.RoomForCream);
        }

    }
}
