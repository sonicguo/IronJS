// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ObjectObjects.PropertiesOfTheObjectConstructor
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PropertiesOfTheObjectConstructorTests : SputnikTestFixture
    {
        public PropertiesOfTheObjectConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.2_Object_Objects\15.2.3_Properties_of_the_Object_Constructor")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.3")]
        [TestCase("S15.2.3_A1.js", Description = "The Object constructor has the property \"prototype\"")]
        public void TheObjectConstructorHasThePropertyPrototype(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.3")]
        [Category("ECMA 15.2.4")]
        [TestCase("S15.2.3_A2.js", Description = "The value of the internal [[Prototype]] property of the Object constructor is the Function prototype object")]
        public void TheValueOfTheInternalPrototypePropertyOfTheObjectConstructorIsTheFunctionPrototypeObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.3")]
        [Category("ECMA 15.2.4")]
        [TestCase("S15.2.3_A3.js", Description = "Object constructor has length property whose value is 1")]
        public void ObjectConstructorHasLengthPropertyWhoseValueIs1(string file)
        {
            RunFile(file);
        }
    }
}