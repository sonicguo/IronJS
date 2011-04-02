// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheGlobalObject.ValuePropertiesOfTheGlobalObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class NaNTests : SputnikTestFixture
    {
        public NaNTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.1_The_Global_Object\15.1.1_Value_Properties_of_the_Global_Object\15.1.1.1_NaN")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.3")]
        [Category("ECMA 15.1.1.1")]
        [Category("ECMA 15.1.2.4")]
        [Category("ECMA 15.1.2.5")]
        [TestCase("S15.1.1.1_A1.js", Description = "The initial value of NaN is NaN")]
        public void TheInitialValueOfNaNIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.3")]
        [Category("ECMA 15.1.1.1")]
        [Category("ECMA 15.5.1")]
        [Category("ECMA 15.6.1")]
        [Category("ECMA 15.7.1")]
        [TestCase("S15.1.1.1_A2_T1.js", Description = "The NaN is not ReadOnly")]
        [TestCase("S15.1.1.1_A2_T2.js", Description = "The NaN is not ReadOnly")]
        public void TheNaNIsNotReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [Category("ECMA 15.1.1.1")]
        [TestCase("S15.1.1.1_A3.1.js", Description = "The NaN is DontDelete")]
        public void TheNaNIsDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.1.1.1")]
        [TestCase("S15.1.1.1_A3.2.js", Description = "The NaN is DontEnum")]
        public void TheNaNIsDontEnum(string file)
        {
            RunFile(file);
        }
    }
}