﻿/* WaterTest.cs
 * Author: Sam Waris
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void DefaultWaterThings()
        {
            Water w = new Water();
            Assert.Equal<uint>(w.Calories, 0);
            Assert.Equal<double>(0.10, w.Price);
            Assert.Equal<Size>(Size.Small, w.Size);
            Assert.True(w.Ice);
        }
        [Fact]
        public void SwitchToSmall()
        {
            Water w = new Water();
            w.Size = Size.Large;
            w.Size = Size.Small;
            Assert.Equal<double>(0.1, w.Price);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<Size>(Size.Small, w.Size);
        }
        public void SwitchToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0.1, w.Price);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<Size>(Size.Medium, w.Size);
        }
        public void SwitchToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.1, w.Price);
            Assert.Equal<uint>(0, w.Calories);
            Assert.Equal<Size>(Size.Large, w.Size);
        }
        [Fact]
        public void HoldIceCheck()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }
        [Fact]
        public void AddLemonCheck()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }
    }
}
