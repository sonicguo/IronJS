// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDatePrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DatePrototypeGetHoursTests : SputnikTestFixture
    {
        public DatePrototypeGetHoursTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.5_Properties_of_the_Date_Prototype_Object\15.9.5.18_Date.prototype.getHours")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.18")]
        [TestCase("S15.9.5.18_A1_T1.js", Description = "The Date.prototype property \"getHours\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.18_A1_T2.js", Description = "The Date.prototype property \"getHours\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.18_A1_T3.js", Description = "The Date.prototype property \"getHours\" has { DontEnum } attributes")]
        public void TheDatePrototypePropertyGetHoursHasDontEnumAttributes(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.18")]
        [TestCase("S15.9.5.18_A2_T1.js", Description = "The \"length\" property of the \"getHours\" is 0")]
        public void TheLengthPropertyOfTheGetHoursIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.18")]
        [TestCase("S15.9.5.18_A3_T1.js", Description = "The Date.prototype.getHours property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.18_A3_T2.js", Description = "The Date.prototype.getHours property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.18_A3_T3.js", Description = "The Date.prototype.getHours property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void TheDatePrototypeGetHoursPropertyLengthHasReadOnlyDontDeleteDontEnumAttributes(string file)
        {
            RunFile(file);
        }
    }
}