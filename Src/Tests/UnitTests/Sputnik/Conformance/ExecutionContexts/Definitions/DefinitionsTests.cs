// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.ExecutionContexts.Definitions
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DefinitionsTests : SputnikTestFixture
    {
        public DefinitionsTests()
            : base(@"Conformance\10_Execution_Contexts\10.1_Definitions")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 10.1.1")]
        [TestCase("S10.1.1_A1_T1.js", Description = "Program functions are defined in source text by a FunctionDeclaration or created dynamically either  by using a FunctionExpression or by using the built-in Function object as a constructor")]
        [TestCase("S10.1.1_A1_T2.js", Description = "Program functions are defined in source text by a FunctionDeclaration or created dynamically either  by using a FunctionExpression or by using the built-in Function object as a constructor")]
        [TestCase("S10.1.1_A1_T3.js", Description = "Program functions are defined in source text by a FunctionDeclaration or created dynamically either  by using a FunctionExpression or by using the built-in Function object as a constructor")]
        public void ProgramFunctionsAreDefinedInSourceTextByAFunctionDeclarationOrCreatedDynamicallyEitherByUsingAFunctionExpressionOrByUsingTheBuiltInFunctionObjectAsAConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 10.1.1")]
        [TestCase("S10.1.1_A2_T1.js", Description = "There are two types of Function objects. Internal functions are built-in objects of the language, such as parseInt and Math.exp")]
        public void ThereAreTwoTypesOfFunctionObjectsInternalFunctionsAreBuiltInObjectsOfTheLanguageSuchAsParseIntAndMathExp(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 10.1.6")]
        [TestCase("S10.1.6_A1_T1.js", Description = "The activation object is initialised with a property with name arguments and attributes {DontDelete}")]
        [TestCase("S10.1.6_A1_T2.js", Description = "The activation object is initialised with a property with name arguments and attributes {DontDelete}")]
        [TestCase("S10.1.6_A1_T3.js", Description = "The activation object is initialised with a property with name arguments and attributes {DontDelete}")]
        public void TheActivationObjectIsInitialisedWithAPropertyWithNameArgumentsAndAttributesDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 10.1.7")]
        [TestCase("S10.1.7_A1_T1.js", Description = "The this value associated with an executioncontext is immutable")]
        public void TheThisValueAssociatedWithAnExecutioncontextIsImmutable(string file)
        {
            RunFile(file);
        }
    }
}