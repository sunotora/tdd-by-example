﻿using NUnit.Framework;
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
            var five = new Dollar(5);
            Assert.That(five.Times(2), Is.EqualTo(new Dollar(10)));
            Assert.That(five.Times(3), Is.EqualTo(new Dollar(15)));
        }

        [Test]
        public void 比較できる()
        {
            Assert.Multiple(() =>
            {
                Assert.True(new Dollar(5).Equals(new Dollar(5)));
                Assert.False(new Dollar(5).Equals(new Dollar(6)));
            });
        }
    }
}
