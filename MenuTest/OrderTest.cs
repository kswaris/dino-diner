using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void OrderTotalCostTest()
        {
            Order o = new Order();
            Brontowurst bw = new Brontowurst();
            MeteorMacAndCheese mc1 = new MeteorMacAndCheese();
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            o.Items.Add(bw);
            o.Items.Add(mc1);
            o.Items.Add(ft);
            o.Items.Add(s);
            double taxed = (bw.Price + mc1.Price + ft.Price + s.Price) * o.SalesTaxRate;
            double expectTotal = bw.Price + mc1.Price + ft.Price + s.Price;
            Assert.Equal(expectTotal + taxed, o.TotalCost);
        }
        [Fact]
        public void OrderSalesTaxTest()
        {
            Order o = new Order();
            Brontowurst bw = new Brontowurst();
            MeteorMacAndCheese mc1 = new MeteorMacAndCheese();
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            o.Items.Add(bw);
            o.Items.Add(mc1);
            o.Items.Add(ft);
            o.Items.Add(s);
            double taxed = (bw.Price + mc1.Price + ft.Price + s.Price) * o.SalesTaxRate;
            Assert.Equal(taxed, o.SalesTaxCost);
        }
        [Fact]
        public void NegativeTest()
        {
            Order o = new Order();
            Brontowurst bw = new Brontowurst();
            MeteorMacAndCheese mc1 = new MeteorMacAndCheese();
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            bw.Price = -100;
            mc1.Price = -100;
            ft.Price = -100;
            s.Price = -100;
            o.Items.Add(bw);
            o.Items.Add(mc1);
            o.Items.Add(ft);
            o.Items.Add(s);
            Assert.True(o.SubtotalCost >= 0);
        }
        public void OrderSubTotalTest()
        {
            Order o = new Order();
            Brontowurst bw = new Brontowurst();
            MeteorMacAndCheese mc1 = new MeteorMacAndCheese();
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            o.Items.Add(bw);
            o.Items.Add(mc1);
            o.Items.Add(ft);
            o.Items.Add(s);
            double subtotal = bw.Price + ft.Price + mc1.Price + s.Price;
            Assert.Equal(subtotal, o.SubtotalCost);
        }
    }
}
