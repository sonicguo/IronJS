using System;
using System.Collections.Generic;
using System.Text;
using IronJS.Ast;
using IronJS.Ast.Nodes;
using IronJS.Runtime.Utils;
using IronJS.Runtime.Js;
using Microsoft.Scripting.Utils;

#if CLR2
using Microsoft.Scripting.Ast;
#else
using System.Linq.Expressions;
#endif

namespace IronJS.Testing {

	using IronJS.Ast.Tools;

	class Program {
		public static void Main(string[] args) {
			Generator astGenerator = new Generator();
			List<INode> astNodes = astGenerator.Build("Testing.js", Encoding.UTF8);
			File globalScope = File.Create(astNodes).Analyze();

			DisplayTools.Print(globalScope);
			Console.ReadLine();
			return;

			IjsContext context = new IjsContext();
			Func<IjsClosure, object> compiled = globalScope.Compile(context);

			context.GlobalScope.Set("time", new Action<IjsFunc>(HelperFunctions.Timer));
			context.GlobalScope.Set("print", new Func<object, object>(HelperFunctions.PrintLine));

			object result = compiled(context.GlobalClosure);
		}
	}
}
