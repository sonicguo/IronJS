// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PatternSemantics
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AtomEscapeTests : SputnikTestFixture
    {
        public AtomEscapeTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.2_Pattern_Semantics\15.10.2.9_AtomEscape")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.11")]
        [Category("ECMA 15.10.2.9")]
        [TestCase("S15.10.2.9_A1_T1.js", Description = "An escape sequence of the form \\ followed by a nonzero decimal number n matches the result of the nth set of capturing parentheses (see 15.10.2.11)")]
        [TestCase("S15.10.2.9_A1_T2.js", Description = "An escape sequence of the form \\ followed by a nonzero decimal number n matches the result of the nth set of capturing parentheses (see 15.10.2.11)")]
        [TestCase("S15.10.2.9_A1_T3.js", Description = "An escape sequence of the form \\ followed by a nonzero decimal number n matches the result of the nth set of capturing parentheses (see 15.10.2.11)")]
        [TestCase("S15.10.2.9_A1_T4.js", Description = "An escape sequence of the form \\ followed by a nonzero decimal number n matches the result of the nth set of capturing parentheses (see 15.10.2.11)")]
        [TestCase("S15.10.2.9_A1_T5.js", Description = "An escape sequence of the form \\ followed by a nonzero decimal number n matches the result of the nth set of capturing parentheses (see 15.10.2.11)")]
        public void AnEscapeSequenceOfTheFormFollowedByANonzeroDecimalNumberNMatchesTheResultOfTheNthSetOfCapturingParenthesesSee1510211(string file)
        {
            RunFile(file);
        }
    }
}