// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.ExecutionContexts.EnteringAnExecutionContext
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class EvalCodeTests : SputnikTestFixture
    {
        public EvalCodeTests()
            : base(@"Conformance\10_Execution_Contexts\10.2_Entering_An_Execution_Context\10.2.2_Eval_Code")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 10.2.2")]
        [TestCase("S10.2.2_A1.1_T1.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T10.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T11.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T2.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T3.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T4.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T5.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T6.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T7.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T8.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.1_T9.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T1.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T10.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T11.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T2.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T3.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T4.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T5.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T6.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T7.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T8.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        [TestCase("S10.2.2_A1.2_T9.js", Description = "The scope chain is initialised to contain the same objects, in the same order, as the calling context\'s scope chain")]
        public void TheScopeChainIsInitialisedToContainTheSameObjectsInTheSameOrderAsTheCallingContextSScopeChain(string file)
        {
            RunFile(file);
        }
    }
}