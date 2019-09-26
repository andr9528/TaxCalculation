using System;
using NSpec;
using NSpecInNUnit;
using NUnit.Framework;


namespace TaxCalculation.Test
{
    public class TaxTest : nspec_as_nunit<TaxTest>
    {
        public void Describe_The_Examples()
        {
            it["Should Work"] = () => Assert.That(2, Is.EqualTo(2));
        }
    }
}
