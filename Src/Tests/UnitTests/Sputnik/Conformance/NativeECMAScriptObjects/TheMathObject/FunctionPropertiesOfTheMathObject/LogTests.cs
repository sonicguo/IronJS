// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.FunctionPropertiesOfTheMathObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class LogTests : SputnikTestFixture
    {
        public LogTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.2_Function_Properties_of_the_Math_Object\15.8.2.10_log")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.10")]
        [TestCase("S15.8.2.10_A1.js", Description = "If x is NaN, Math.log(x) is NaN")]
        public void IfXIsNaNMathLogXIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.10")]
        [TestCase("S15.8.2.10_A2.js", Description = "If x is less than 0, Math.log(x) is NaN")]
        public void IfXIsLessThan0MathLogXIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.10")]
        [TestCase("S15.8.2.10_A3.js", Description = "If x is +0 or -0, Math.log(x) is -Infinity")]
        public void IfXIs0Or0MathLogXIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.10")]
        [TestCase("S15.8.2.10_A4.js", Description = "If x is 1, Math.log(x) is +0")]
        public void IfXIs1MathLogXIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.10")]
        [TestCase("S15.8.2.10_A5.js", Description = "If x is +Infinity, Math.log(x) is +Infinity")]
        public void IfXIsInfinityMathLogXIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.10")]
        [TestCase("S15.8.2.10_A6.js", Description = "Math.log, recommended that implementations use the approximation algorithms for IEEE 754 arithmetic contained in fdlibm")]
        public void MathLogRecommendedThatImplementationsUseTheApproximationAlgorithmsForIEEE754ArithmeticContainedInFdlibm(string file)
        {
            RunFile(file);
        }
    }
}