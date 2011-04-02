// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.ValuePropertiesOfTheMathObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class LOG10ETests : SputnikTestFixture
    {
        public LOG10ETests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.1_Value_Properties_of_the_Math_Object\15.8.1.5_LOG10E")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.5")]
        [TestCase("S15.8.1.5_A1.js", Description = "Math.LOG10E is approximately 0.4342944819032518")]
        public void MathLOG10EIsApproximately04342944819032518(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.5")]
        [TestCase("S15.8.1.5_A2.js", Description = "Value Property LOG10E of the Math Object has the attribute DontEnum")]
        public void ValuePropertyLOG10EOfTheMathObjectHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.5")]
        [TestCase("S15.8.1.5_A3.js", Description = "Value Property LOG10E of the Math Object has the attribute DontDelete")]
        public void ValuePropertyLOG10EOfTheMathObjectHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.5")]
        [TestCase("S15.8.1.5_A4.js", Description = "Value Property LOG10E of the Math Object has the attribute ReadOnly")]
        public void ValuePropertyLOG10EOfTheMathObjectHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }
    }
}