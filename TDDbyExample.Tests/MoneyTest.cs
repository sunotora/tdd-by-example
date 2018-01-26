using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDbyExample.Tests
{
    [TestFixture]
    public class MoneyTest
    {
        [Test]
        public void 掛け算できる()
        {
            var five = Money.Dollar(5);
            Assert.That(five.Times(2), Is.EqualTo(Money.Dollar(10)));
            Assert.That(five.Times(3), Is.EqualTo(Money.Dollar(15)));
        }

        [Test]
        public void Francも掛け算できる()
        {
            var five = Money.Franc(5);
            Assert.That(five.Times(2), Is.EqualTo(Money.Franc(10)));
            Assert.That(five.Times(3), Is.EqualTo(Money.Franc(15)));
        }

        [Test]
        public void 比較できる()
        {
            Assert.Multiple(() =>
            {
                Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
                Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
                Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
                Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
                Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
            });
        }

        [Test]
        public void 通貨を取得できる()
        {
            Assert.That(Money.Dollar(1).Currency, Is.EqualTo("USD"));
            Assert.That(Money.Franc(1).Currency, Is.EqualTo("CHF"));
        }

        [Test]
        public void 型が違っても通貨が同じ場合は比較できる()
        {
            var l = new Money(10, "CHF");
            var r = new Franc(10, "CHF");
            Assert.True(l.Equals(r));
        }
    }
}
