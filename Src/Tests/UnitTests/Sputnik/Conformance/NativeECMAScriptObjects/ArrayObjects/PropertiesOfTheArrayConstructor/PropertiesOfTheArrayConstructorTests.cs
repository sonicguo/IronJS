// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayConstructor
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PropertiesOfTheArrayConstructorTests : SputnikTestFixture
    {
        public PropertiesOfTheArrayConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.3_Properties_of_the_Array_Constructor")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.4.2")]
        [Category("ECMA 15.2.4.5")]
        [Category("ECMA 15.2.4.6")]
        [Category("ECMA 15.4.3")]
        [TestCase("S15.4.3_A1.1_T1.js", Description = "The value of the internal [[Prototype]] property of the Array constructor is the Function prototype object")]
        [TestCase("S15.4.3_A1.1_T2.js", Description = "The value of the internal [[Prototype]] property of the Array constructor is the Function prototype object")]
        [TestCase("S15.4.3_A1.1_T3.js", Description = "The value of the internal [[Prototype]] property of the Array constructor is the Function prototype object")]
        public void TheValueOfTheInternalPrototypePropertyOfTheArrayConstructorIsTheFunctionPrototypeObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.2.4.7")]
        [Category("ECMA 15.4.3")]
        [TestCase("S15.4.3_A2.1.js", Description = "The length property of Array has the attribute DontEnum")]
        public void TheLengthPropertyOfArrayHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [Category("ECMA 15.2.4.5")]
        [Category("ECMA 15.4.3")]
        [TestCase("S15.4.3_A2.2.js", Description = "The length property of Array has the attribute DontDelete")]
        public void TheLengthPropertyOfArrayHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.3")]
        [TestCase("S15.4.3_A2.3.js", Description = "The length property of Array has the attribute ReadOnly")]
        public void TheLengthPropertyOfArrayHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.3")]
        [TestCase("S15.4.3_A2.4.js", Description = "The length property of Array is 1")]
        public void TheLengthPropertyOfArrayIs1(string file)
        {
            RunFile(file);
        }
    }
}