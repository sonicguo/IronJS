// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.FunctionDefinition
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class FunctionDefinitionTests : SputnikTestFixture
    {
        public FunctionDefinitionTests()
            : base(@"Conformance\13_Function_Definition")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A1.js", Description = "\"x=function y(){}\" statement does not store a reference to the new function in the varaible y(Identifier)")]
        public void XFunctionYStatementDoesNotStoreAReferenceToTheNewFunctionInTheVaraibleYIdentifier(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A10.js", Description = "Function is a data")]
        public void FunctionIsAData(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A11_T1.js", Description = "Since arguments property has attribute { DontDelete }, only its elements can be deleted")]
        [TestCase("S13_A11_T2.js", Description = "Since arguments property has attribute { DontDelete }, only its elements can be deleted")]
        [TestCase("S13_A11_T3.js", Description = "Since arguments property has attribute { DontDelete }, only its elements can be deleted")]
        [TestCase("S13_A11_T4.js", Description = "Since arguments property has attribute { DontDelete }, only its elements can be deleted")]
        public void SinceArgumentsPropertyHasAttributeDontDeleteOnlyItsElementsCanBeDeleted(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A12_T1.js", Description = "Function declarations in global or function scope are {DontDelete}")]
        [TestCase("S13_A12_T2.js", Description = "Function declarations in global or function scope are {DontDelete}")]
        public void FunctionDeclarationsInGlobalOrFunctionScopeAreDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A13_T1.js", Description = "Deleting arguments[i] leads to breaking the connection to local reference")]
        [TestCase("S13_A13_T2.js", Description = "Deleting arguments[i] leads to breaking the connection to local reference")]
        [TestCase("S13_A13_T3.js", Description = "Deleting arguments[i] leads to breaking the connection to local reference")]
        public void DeletingArgumentsILeadsToBreakingTheConnectionToLocalReference(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A14.js", Description = "Unicode symbols in function name are allowed")]
        public void UnicodeSymbolsInFunctionNameAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A15_T1.js", Description = "\'\'arguments\'\' variable overrides ActivationObject.arguments")]
        [TestCase("S13_A15_T2.js", Description = " \'\'arguments\'\' variable overrides ActivationObject.arguments")]
        [TestCase("S13_A15_T3.js", Description = "\'\'arguments\'\' variable overrides ActivationObject.arguments")]
        [TestCase("S13_A15_T4.js", Description = "\'\'arguments\'\' variable overrides ActivationObject.arguments")]
        [TestCase("S13_A15_T5.js", Description = "\'\'arguments\'\' variable overrides ActivationObject.arguments")]
        public void ArgumentsVariableOverridesActivationObjectArguments(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A16.js", Description = "Any separators are admitted between declaration chunks")]
        public void AnySeparatorsAreAdmittedBetweenDeclarationChunks(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A17_T1.js", Description = "Function call cannot appear in the program before the FunctionExpression appears")]
        [TestCase("S13_A17_T2.js", Description = "Function call cannot appear in the program before the FunctionExpression appears")]
        public void FunctionCallCannotAppearInTheProgramBeforeTheFunctionExpressionAppears(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A18.js", Description = "Closures are admitted")]
        public void ClosuresAreAdmitted(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13,13.2")]
        [TestCase("S13_A19_T1.js", Description = "\"var\" does not override function declaration")]
        [TestCase("S13_A19_T2.js", Description = "\"var\" does not override function declaration")]
        public void VarDoesNotOverrideFunctionDeclaration(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A2_T1.js", Description = "function must be evaluated inside the expression")]
        [TestCase("S13_A2_T2.js", Description = "function must be evaluated inside the expression")]
        [TestCase("S13_A2_T3.js", Description = "function must be evaluated inside the expression")]
        public void FunctionMustBeEvaluatedInsideTheExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A3_T1.js", Description = "The Identifier in a FunctionExpression can be referenced from inside the FunctionExpression\'s FunctionBody to allow the function calling itself recursively")]
        [TestCase("S13_A3_T2.js", Description = "The Identifier in a FunctionExpression can be referenced from inside the FunctionExpression\'s FunctionBody to allow the function calling itself recursively")]
        [TestCase("S13_A3_T3.js", Description = "The Identifier in a FunctionExpression can be referenced from inside the FunctionExpression\'s FunctionBody to allow the function calling itself recursively")]
        public void TheIdentifierInAFunctionExpressionCanBeReferencedFromInsideTheFunctionExpressionSFunctionBodyToAllowTheFunctionCallingItselfRecursively(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A4_T1.js", Description = "The production FunctionDeclaration: \"function Identifier ( FormalParameterList_opt ) { FunctionBody }\" is processed by function declarations")]
        [TestCase("S13_A4_T2.js", Description = "The production FunctionDeclaration: \"function Identifier ( FormalParameterList_opt ) { FunctionBody }\" is processed by function declarations")]
        [TestCase("S13_A4_T3.js", Description = "The production FunctionDeclaration: \"function Identifier ( FormalParameterList_opt ) { FunctionBody }\" is processed by function declarations")]
        [TestCase("S13_A4_T4.js", Description = "The production FunctionDeclaration: \"function Identifier ( FormalParameterList_opt ) { FunctionBody }\" is processed by function declarations")]
        public void TheProductionFunctionDeclarationFunctionIdentifierFormalParameterList_optFunctionBodyIsProcessedByFunctionDeclarations(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 10.1.2")]
        [Category("ECMA 13")]
        [TestCase("S13_A5.js", Description = "Only FormalParameterList as arguments list is allowed")]
        public void OnlyFormalParameterListAsArgumentsListIsAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A6_T1.js", Description = "FunctionDeclaration can be overrided by other FunctionDeclaration with the same Identifier")]
        [TestCase("S13_A6_T2.js", Description = "FunctionDeclaration can be overrided by other FunctionDeclaration with the same Identifier")]
        public void FunctionDeclarationCanBeOverridedByOtherFunctionDeclarationWithTheSameIdentifier(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A7_T1.js", Description = "The FunctionBody must be SourceElements")]
        [TestCase("S13_A7_T2.js", Description = "The FunctionBody must be SourceElements")]
        [TestCase("S13_A7_T3.js", Description = "The FunctionBody must be SourceElements", ExpectedException = typeof(Exception))]
        public void TheFunctionBodyMustBeSourceElements(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A8_T1.js", Description = "Arguments property of activation object contains real params to be passed")]
        [TestCase("S13_A8_T2.js", Description = "Arguments property of activation object contains real params to be passed")]
        public void ArgumentsPropertyOfActivationObjectContainsRealParamsToBePassed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13")]
        [TestCase("S13_A9.js", Description = "Function can be passed as argument")]
        public void FunctionCanBePassedAsArgument(string file)
        {
            RunFile(file);
        }
    }
}