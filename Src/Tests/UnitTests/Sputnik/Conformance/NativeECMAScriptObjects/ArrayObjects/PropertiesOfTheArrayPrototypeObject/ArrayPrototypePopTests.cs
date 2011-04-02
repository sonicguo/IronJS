// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ArrayPrototypePopTests : SputnikTestFixture
    {
        public ArrayPrototypePopTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.4_Properties_of_the_Array_Prototype_Object\15.4.4.6_Array_prototype_pop")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A1.1_T1.js", Description = "If length equal zero, call the [[Put]] method of this object with arguments \"length\" and 0 and return undefined")]
        public void IfLengthEqualZeroCallThePutMethodOfThisObjectWithArgumentsLengthAnd0AndReturnUndefined(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A1.2_T1.js", Description = "The last element of the array is removed from the array and returned")]
        public void TheLastElementOfTheArrayIsRemovedFromTheArrayAndReturned(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A2_T1.js", Description = "The pop function is intentionally generic. It does not require that its this value be an Array object")]
        [TestCase("S15.4.4.6_A2_T2.js", Description = "The pop function is intentionally generic. It does not require that its this value be an Array object")]
        [TestCase("S15.4.4.6_A2_T3.js", Description = "The pop function is intentionally generic. It does not require that its this value be an Array object")]
        [TestCase("S15.4.4.6_A2_T4.js", Description = "The pop function is intentionally generic. It does not require that its this value be an Array object")]
        public void ThePopFunctionIsIntentionallyGenericItDoesNotRequireThatItsThisValueBeAnArrayObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A3_T1.js", Description = "Check ToUint32(length) for non Array objects")]
        [TestCase("S15.4.4.6_A3_T2.js", Description = "Check ToUint32(length) for non Array objects")]
        [TestCase("S15.4.4.6_A3_T3.js", Description = "Check ToUint32(length) for non Array objects")]
        public void CheckToUint32LengthForNonArrayObjects(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.6")]
        [Category("ECMA 8.6.2.1")]
        [Category("ECMA 8.6.2.5")]
        [TestCase("S15.4.4.6_A4_T1.js", Description = "[[Get]], [[Delete]] from not an inherited property")]
        [TestCase("S15.4.4.6_A4_T2.js", Description = "[[Get]], [[Delete]] from not an inherited property")]
        public void GetDeleteFromNotAnInheritedProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.2.4.7")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A5.1.js", Description = "The length property of pop has the attribute DontEnum")]
        public void TheLengthPropertyOfPopHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [Category("ECMA 15.2.4.5")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A5.2.js", Description = "The length property of pop has the attribute DontDelete")]
        public void TheLengthPropertyOfPopHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A5.3.js", Description = "The length property of pop has the attribute ReadOnly")]
        public void TheLengthPropertyOfPopHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A5.4.js", Description = "The length property of pop is 0")]
        public void TheLengthPropertyOfPopIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.2.4.7")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A5.5.js", Description = "The pop property of Array has the attribute DontEnum")]
        public void ThePopPropertyOfArrayHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A5.6.js", Description = "The pop property of Array has not prototype property")]
        public void ThePopPropertyOfArrayHasNotPrototypeProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.2")]
        [Category("ECMA 15.4.4.6")]
        [TestCase("S15.4.4.6_A5.7.js", Description = "The pop property of Array can\'t be used as constructor")]
        public void ThePopPropertyOfArrayCanTBeUsedAsConstructor(string file)
        {
            RunFile(file);
        }
    }
}