using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GC_StorefrontEX
{
    public class StoreTesting
    {
        [Theory]
        [InlineData("Beef", true)]
        [InlineData("Chicken", false)] //Chicken is an item but I wanted to test if it'd show up as an item when it was marked as not being in stock
        [InlineData("Bread", true)]
        public void TestingStoreHasItem(string item, bool expected)
        {
            Register r = new Register();

            bool actual = r.HasItem(item);

            Assert.Equal(expected, actual);
        }

        [Fact] //Tested this method with items in the store to see if it was random. Placed an item from the store and either another item was pulled or it was true that called item
        // was returned
        public void TestingBuyingRandom()
        {
            Register r = new Register();

            string actual = r.BuyRandom();

            Assert.Equal("Chicken", actual);
        }

        //[Theory] //- Couldn't figure out how to test BuyingBulk. Know I need to pull the item and price, then multiply it by the amount
        //[InlineData(5, 8)]
        //public void TestingBuyingInBulk(int input, double amount)
        //{
        //    Register r = new Register();
        //    List<Item> items = new List<Item>();
        //    double actual = r.BuyInBulk([items].Price, amount);

        //    Assert.Equal(expected, actual);
        //}


        //[Fact] - Wasn't sure how to test this method. I understand it's role within the code but can't figure out how to test it
        //public void TestingSelectItem()
        //{
        //    Register r = new Register();

        //    string actual = r.HasItem);
        }

    }
}
