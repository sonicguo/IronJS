// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.FunctionPropertiesOfTheMathObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PowTests : SputnikTestFixture
    {
        public PowTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.2_Function_Properties_of_the_Math_Object\15.8.2.13_pow")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A1.js", Description = "If y is NaN, Math.pow(x,y) is NaN")]
        public void IfYIsNaNMathPowXYIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A10.js", Description = "If abs(x)<1 and y is -Infinity, Math.pow(x,y) is +Infinity")]
        [TestCase("S15.8.2.13_A5.js", Description = "If abs(x)>1 and y is +Infinity, Math.pow(x,y) is +Infinity")]
        public void IfAbsX1AndYIsInfinityMathPowXYIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A11.js", Description = "If x is +Infinity and y>0, Math.pow(x,y) is +Infinity")]
        public void IfXIsInfinityAndY0MathPowXYIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A12.js", Description = "If x is +Infinity and y<0, Math.pow(x,y) is +0")]
        public void IfXIsInfinityAndY0MathPowXYIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A13.js", Description = "If x is -Infinity and y>0 and y is an odd integer, Math.pow(x,y) is -Infinity")]
        public void IfXIsInfinityAndY0AndYIsAnOddIntegerMathPowXYIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A14.js", Description = "If x is -Infinity and y>0 and y is NOT an odd integer, Math.pow(x,y) is +Infinity")]
        public void IfXIsInfinityAndY0AndYIsNOTAnOddIntegerMathPowXYIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A15.js", Description = "If x is -Infinity and y<0 and y is an odd integer, Math.pow(x,y) is -0")]
        public void IfXIsInfinityAndY0AndYIsAnOddIntegerMathPowXYIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A16.js", Description = "If x is -Infinity and y<0 and y is NOT an odd integer, Math.pow(x,y) is +0")]
        public void IfXIsInfinityAndY0AndYIsNOTAnOddIntegerMathPowXYIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A17.js", Description = "If x is +0 and y>0, Math.pow(x,y) is +0")]
        public void IfXIs0AndY0MathPowXYIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A18.js", Description = "If x is +0 and y<0, Math.pow(x,y) is +Infinity")]
        public void IfXIs0AndY0MathPowXYIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A19.js", Description = "If x is -0 and y>0 and y is an odd integer, Math.pow(x,y) is -0")]
        public void IfXIs0AndY0AndYIsAnOddIntegerMathPowXYIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A2.js", Description = "If y is +0, Math.pow(x,y) is 1, even if x is NaN")]
        [TestCase("S15.8.2.13_A3.js", Description = "If y is -0, Math.pow(x,y) is 1, even if x is NaN")]
        public void IfYIs0MathPowXYIs1EvenIfXIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A20.js", Description = "If x is -0 and y>0 and y is NOT an odd integer, Math.pow(x,y) is +0")]
        public void IfXIs0AndY0AndYIsNOTAnOddIntegerMathPowXYIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A21.js", Description = "If x is -0 and y<0 and y is an odd integer, Math.pow(x,y) is -Infinity")]
        public void IfXIs0AndY0AndYIsAnOddIntegerMathPowXYIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A22.js", Description = "If x is -0 and y<0 and y is NOT an odd integer, Math.pow(x,y) is +Infinity")]
        public void IfXIs0AndY0AndYIsNOTAnOddIntegerMathPowXYIsInfinity(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A23.js", Description = "If x<0 and x is finite and y is finite and y is not an integer, Math.pow(x,y) is NaN")]
        public void IfX0AndXIsFiniteAndYIsFiniteAndYIsNotAnIntegerMathPowXYIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A24.js", Description = "Math.pow, recommended that implementations use the approximation algorithms for IEEE 754 arithmetic contained in fdlibm")]
        public void MathPowRecommendedThatImplementationsUseTheApproximationAlgorithmsForIEEE754ArithmeticContainedInFdlibm(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A4.js", Description = "If x is NaN and y is nonzero, Math.pow(x,y) is NaN")]
        public void IfXIsNaNAndYIsNonzeroMathPowXYIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A6.js", Description = "If abs(x)>1 and y is -Infinity, Math.pow(x,y) is +0")]
        [TestCase("S15.8.2.13_A9.js", Description = "If abs(x)<1 and y is +Infinity, Math.pow(x,y) is +0")]
        public void IfAbsX1AndYIsInfinityMathPowXYIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.13")]
        [TestCase("S15.8.2.13_A7.js", Description = "If abs(x)==1 and y is +Infinity, Math.pow(x,y) is NaN")]
        [TestCase("S15.8.2.13_A8.js", Description = "If abs(x)==1 and y is -Infinity, Math.pow(x,y) is NaN")]
        public void IfAbsX1AndYIsInfinityMathPowXYIsNaN(string file)
        {
            RunFile(file);
        }
    }
}