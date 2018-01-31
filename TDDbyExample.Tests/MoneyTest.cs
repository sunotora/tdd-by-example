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
        public void 足し算できる()
        {
            var five = Money.Dollar(5);
            var sum = five.Plus(five);
            var bank = new Bank();
            var reduced = bank.Reduce(sum, "USD");
            Assert.That(reduced, Is.EqualTo(Money.Dollar(10)));
        }

        [Test]
        public void PlusメソッドがSumクラスを返す()
        {
            var five = Money.Dollar(5);
            var result = five.Plus(five);
            var sum = (Sum)result;
            Assert.That(sum.Augend, Is.EqualTo(five));
            Assert.That(sum.Addend, Is.EqualTo(five));
        }

        [Test]
        public void Sumを単純な形に変形できる()
        {
            var sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            var bank = new Bank();
            var result = bank.Reduce(sum, "USD");
            Assert.That(result, Is.EqualTo(Money.Dollar(7)));
        }

        [Test]
        public void 比較できる()
        {
            Assert.Multiple(() =>
            {
                Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
                Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
                Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
            });
        }

        [Test]
        public void 通貨を取得できる()
        {
            Assert.That(Money.Dollar(1).Currency, Is.EqualTo("USD"));
            Assert.That(Money.Franc(1).Currency, Is.EqualTo("CHF"));
        }
    }
}
