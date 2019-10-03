using System;
using NSpec;
using NSpecInNUnit;
using NUnit.Framework;

//http://nspec.org/

namespace TaxCalculation.Test
{
    public class TaxTest : nspec_as_nunit<TaxTest>
    {
        private string scenario1 = "Should do stuff";
        private string scenario2 = "Should do other stuff";
        private string scenario3 = "Should do something special";

        private int number = 1;
        public void Describe_The_Examples1()
        {
            it["Should Work"] = () => Assert.That(2, Is.EqualTo(2));
        }

        public void Describe_The_Examples2()
        {
            it[scenario1] = () => Assert.That(2, Is.EqualTo(2));
        }

        public void Describe_The_Examples3()
        {
            before = () => number = 1;
            
            it[scenario1] = () => Assert.That(2, Is.EqualTo(number + 1));
            it[scenario2] = () => Assert.That(4, Is.EqualTo(number + 3));
            it[scenario3] = () => Assert.That(10, Is.EqualTo(number + 9));
        }

        public void Describe_The_Examples4()
        {
            it["throws expected exception type"] = expect<ArgumentException>(() => { throw new ArgumentException(); });
        }
    }
}
