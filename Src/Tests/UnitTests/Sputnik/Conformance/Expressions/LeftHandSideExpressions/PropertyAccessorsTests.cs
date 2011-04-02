// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.LeftHandSideExpressions
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PropertyAccessorsTests : SputnikTestFixture
    {
        public PropertyAccessorsTests()
            : base(@"Conformance\11_Expressions\11.2_Left_Hand_Side_Expressions\11.2.1_Property_Accessors")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S11.2.1_A1.1.js", Description = "White Space and Line Terminator between MemberExpression or CallExpression and \".\" and between \".\" and Identifier are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenMemberExpressionOrCallExpressionAndAndBetweenAndIdentifierAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S11.2.1_A1.2.js", Description = "White Space and Line Terminator between \"[\" and MemberExpression or CallExpression and between Identifier and \"]\" are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenAndMemberExpressionOrCallExpressionAndBetweenIdentifierAndAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [TestCase("S11.2.1_A2.js", Description = "MemberExpression and CallExpression uses GetValue")]
        public void MemberExpressionAndCallExpressionUsesGetValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [Category("ECMA 11.2.3")]
        [Category("ECMA 15.6.4.2")]
        [Category("ECMA 9.9")]
        [TestCase("S11.2.1_A3_T1.js", Description = "MemberExpression calls ToObject(MemberExpression) and ToString(Expression). CallExpression calls ToObject(CallExpression) and ToString(Expression)")]
        public void MemberExpressionCallsToObjectMemberExpressionAndToStringExpressionCallExpressionCallsToObjectCallExpressionAndToStringExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [Category("ECMA 11.2.3")]
        [Category("ECMA 15.6.4.2")]
        [Category("ECMA 9.9")]
        [TestCase("S11.2.1_A3_T2.js", Description = "MemberExpression calls ToObject(MemberExpression) and ToString(Expression). CallExpression calls ToObject(CallExpression) and ToString(Expression) @description: Checking Number case")]
        public void MemberExpressionCallsToObjectMemberExpressionAndToStringExpressionCallExpressionCallsToObjectCallExpressionAndToStringExpressionDescriptionCheckingNumberCase(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [Category("ECMA 11.2.3")]
        [Category("ECMA 15.6.4.2")]
        [Category("ECMA 9.9")]
        [TestCase("S11.2.1_A3_T3.js", Description = "MemberExpression calls ToObject(MemberExpression) and ToString(Expression). CallExpression calls ToObject(CallExpression) and ToString(Expression) @description: Checking String case")]
        public void MemberExpressionCallsToObjectMemberExpressionAndToStringExpressionCallExpressionCallsToObjectCallExpressionAndToStringExpressionDescriptionCheckingStringCase(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [Category("ECMA 11.2.3")]
        [Category("ECMA 15.6.4.2")]
        [Category("ECMA 9.9")]
        [TestCase("S11.2.1_A3_T4.js", Description = "MemberExpression calls ToObject(MemberExpression) and ToString(Expression). CallExpression calls ToObject(CallExpression) and ToString(Expression) @description: Checking \"undefined\" case")]
        public void MemberExpressionCallsToObjectMemberExpressionAndToStringExpressionCallExpressionCallsToObjectCallExpressionAndToStringExpressionDescriptionCheckingUndefinedCase(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [Category("ECMA 11.2.3")]
        [Category("ECMA 15.6.4.2")]
        [Category("ECMA 9.9")]
        [TestCase("S11.2.1_A3_T5.js", Description = "MemberExpression calls ToObject(MemberExpression) and ToString(Expression). CallExpression calls ToObject(CallExpression) and ToString(Expression) @description: Checking \"null\" case")]
        public void MemberExpressionCallsToObjectMemberExpressionAndToStringExpressionCallExpressionCallsToObjectCallExpressionAndToStringExpressionDescriptionCheckingNullCase(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.2.1")]
        [TestCase("S11.2.1_A4_T1.js", Description = "Check type of various properties")]
        [TestCase("S11.2.1_A4_T2.js", Description = "Check type of various properties")]
        [TestCase("S11.2.1_A4_T3.js", Description = "Check type of various properties")]
        [TestCase("S11.2.1_A4_T4.js", Description = "Check type of various properties")]
        [TestCase("S11.2.1_A4_T5.js", Description = "Check type of various properties")]
        [TestCase("S11.2.1_A4_T6.js", Description = "Check type of various properties")]
        [TestCase("S11.2.1_A4_T7.js", Description = "Check type of various properties")]
        [TestCase("S11.2.1_A4_T8.js", Description = "Check type of various properties")]
        [TestCase("S11.2.1_A4_T9.js", Description = "Check type of various properties")]
        public void CheckTypeOfVariousProperties(string file)
        {
            RunFile(file);
        }
    }
}