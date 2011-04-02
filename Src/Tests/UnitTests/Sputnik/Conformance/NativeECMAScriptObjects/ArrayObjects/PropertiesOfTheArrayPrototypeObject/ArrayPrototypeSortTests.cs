// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ArrayPrototypeSortTests : SputnikTestFixture
    {
        public ArrayPrototypeSortTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.4_Properties_of_the_Array_Prototype_Object\15.4.4.11_Array_prototype_sort")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A1.1_T1.js", Description = "If this object does not have a property named by ToString(j), and this object does not have a property named by ToString(k), return +0")]
        public void IfThisObjectDoesNotHaveAPropertyNamedByToStringJAndThisObjectDoesNotHaveAPropertyNamedByToStringKReturn0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A1.2_T1.js", Description = "If this object does not have a property named by ToString(j), return 1. If this object does not have a property named by ToString(k), return -1")]
        [TestCase("S15.4.4.11_A1.2_T2.js", Description = "If this object does not have a property named by ToString(j), return 1. If this object does not have a property named by ToString(k), return -1")]
        public void IfThisObjectDoesNotHaveAPropertyNamedByToStringJReturn1IfThisObjectDoesNotHaveAPropertyNamedByToStringKReturn1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A1.3_T1.js", Description = "If [[Get]] ToString(j) and [[Get]] ToString(k) are both undefined, return +0")]
        public void IfGetToStringJAndGetToStringKAreBothUndefinedReturn0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A1.4_T1.js", Description = "If [[Get]] ToString(j) is undefined, return 1. If [[]Get] ToString(k) is undefined, return -1")]
        [TestCase("S15.4.4.11_A1.4_T2.js", Description = "If [[Get]] ToString(j) is undefined, return 1. If [[]Get] ToString(k) is undefined, return -1")]
        public void IfGetToStringJIsUndefinedReturn1IfGetToStringKIsUndefinedReturn1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A1.5_T1.js", Description = "If comparefn is undefined, use SortCompare operator")]
        public void IfComparefnIsUndefinedUseSortCompareOperator(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A2.1_T1.js", Description = " If ToString([[Get]] ToString(j)) < ToString([[Get]] ToString(k)), return -1. If ToString([[Get]] ToString(j)) > ToString([[Get]] ToString(k)), return 1")]
        [TestCase("S15.4.4.11_A2.1_T2.js", Description = " If ToString([[Get]] ToString(j)) < ToString([[Get]] ToString(k)), return -1. If ToString([[Get]] ToString(j)) > ToString([[Get]] ToString(k)), return 1")]
        [TestCase("S15.4.4.11_A2.1_T3.js", Description = " If ToString([[Get]] ToString(j)) < ToString([[Get]] ToString(k)), return -1. If ToString([[Get]] ToString(j)) > ToString([[Get]] ToString(k)), return 1")]
        public void IfToStringGetToStringJToStringGetToStringKReturn1IfToStringGetToStringJToStringGetToStringKReturn1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A2.2_T1.js", Description = "My comparefn is inverse implementation comparefn")]
        [TestCase("S15.4.4.11_A2.2_T2.js", Description = "My comparefn is inverse implementation comparefn")]
        [TestCase("S15.4.4.11_A2.2_T3.js", Description = "My comparefn is inverse implementation comparefn")]
        public void MyComparefnIsInverseImplementationComparefn(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A3_T1.js", Description = "The sort function is intentionally generic. It does not require that its this value be an Array object")]
        [TestCase("S15.4.4.11_A3_T2.js", Description = "The sort function is intentionally generic. It does not require that its this value be an Array object")]
        public void TheSortFunctionIsIntentionallyGenericItDoesNotRequireThatItsThisValueBeAnArrayObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A4_T1.js", Description = "Check ToUint32(length) for non Array objects")]
        [TestCase("S15.4.4.11_A4_T2.js", Description = "Check ToUint32(length) for non Array objects")]
        [TestCase("S15.4.4.11_A4_T3.js", Description = "Check ToUint32(length) for non Array objects")]
        public void CheckToUint32LengthForNonArrayObjects(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A5_T1.js", Description = "Array.sort should not eat exceptions")]
        public void ArraySortShouldNotEatExceptions(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [Category("ECMA 8.6.2.1")]
        [Category("ECMA 8.6.2.5")]
        [TestCase("S15.4.4.11_A6_T2.js", Description = "[[Get]], [[Delete]] from not an inherited property")]
        public void GetDeleteFromNotAnInheritedProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.2.4.7")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A7.1.js", Description = "The length property of sort has the attribute DontEnum")]
        public void TheLengthPropertyOfSortHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [Category("ECMA 15.2.4.5")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A7.2.js", Description = "The length property of sort has the attribute DontDelete")]
        public void TheLengthPropertyOfSortHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A7.3.js", Description = "The length property of sort has the attribute ReadOnly")]
        public void TheLengthPropertyOfSortHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A7.4.js", Description = "The length property of sort is 1")]
        public void TheLengthPropertyOfSortIs1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 12.6.4")]
        [Category("ECMA 15.2.4.7")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A7.5.js", Description = "The sort property of Array has the attribute DontEnum")]
        public void TheSortPropertyOfArrayHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A7.6.js", Description = "The sort property of Array has not prototype property")]
        public void TheSortPropertyOfArrayHasNotPrototypeProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.2")]
        [Category("ECMA 15.4.4.11")]
        [TestCase("S15.4.4.11_A7.7.js", Description = "The sort property of Array can\'t be used as constructor")]
        public void TheSortPropertyOfArrayCanTBeUsedAsConstructor(string file)
        {
            RunFile(file);
        }
    }
}