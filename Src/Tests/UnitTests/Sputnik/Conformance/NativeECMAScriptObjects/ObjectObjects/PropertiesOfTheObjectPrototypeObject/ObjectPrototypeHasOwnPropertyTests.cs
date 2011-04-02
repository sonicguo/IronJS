// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ObjectObjects.PropertiesOfTheObjectPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ObjectPrototypeHasOwnPropertyTests : SputnikTestFixture
    {
        public ObjectPrototypeHasOwnPropertyTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.2_Object_Objects\15.2.4_Properties_of_the_Object_Prototype_Object\15.2.4.5_Object.prototype.hasOwnProperty")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.4.5")]
        [TestCase("S15.2.4.5_A1_T1.js", Description = "When the hasOwnProperty method is called with argument V, the following steps are taken: i) Let O be this object ii) Call ToString(V) iii) If O doesn\'t have a property with the name given by Result(ii), return false iv) Return true")]
        [TestCase("S15.2.4.5_A1_T2.js", Description = "When the hasOwnProperty method is called with argument V, the following steps are taken: i) Let O be this object ii) Call ToString(V) iii) If O doesn\'t have a property with the name given by Result(ii), return false iv) Return true")]
        [TestCase("S15.2.4.5_A1_T3.js", Description = "When the hasOwnProperty method is called with argument V, the following steps are taken: i) Let O be this object ii) Call ToString(V) iii) If O doesn\'t have a property with the name given by Result(ii), return false iv) Return true")]
        public void WhenTheHasOwnPropertyMethodIsCalledWithArgumentVTheFollowingStepsAreTakenILetOBeThisObjectIiCallToStringVIiiIfODoesnTHaveAPropertyWithTheNameGivenByResultIiReturnFalseIvReturnTrue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.4.5")]
        [TestCase("S15.2.4.5_A10.js", Description = "The Object.prototype.hasOwnProperty.length property has the attribute ReadOnly")]
        public void TheObjectPrototypeHasOwnPropertyLengthPropertyHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.4.5")]
        [TestCase("S15.2.4.5_A11.js", Description = "The length property of the hasOwnProperty method is 1")]
        public void TheLengthPropertyOfTheHasOwnPropertyMethodIs1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.2.4.5")]
        [TestCase("S15.2.4.5_A6.js", Description = "Object.prototype.hasOwnProperty has not prototype property")]
        public void ObjectPrototypeHasOwnPropertyHasNotPrototypeProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.2.4.5")]
        [TestCase("S15.2.4.5_A7.js", Description = "Object.prototype.hasOwnProperty can\'t be used as a constructor")]
        public void ObjectPrototypeHasOwnPropertyCanTBeUsedAsAConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.4.5")]
        [TestCase("S15.2.4.5_A8.js", Description = "The Object.prototype.hasOwnProperty.length property has the attribute DontEnum")]
        public void TheObjectPrototypeHasOwnPropertyLengthPropertyHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.2.4.5")]
        [TestCase("S15.2.4.5_A9.js", Description = "The Object.prototype.hasOwnProperty.length property has the attribute DontDelete")]
        public void TheObjectPrototypeHasOwnPropertyLengthPropertyHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }
    }
}