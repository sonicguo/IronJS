﻿#light
#r "../Dependencies/Antlr3.Runtime.dll"
#r "../Dependencies/Microsoft.Dynamic.dll"
#r "../Dependencies/Microsoft.Scripting.dll"
#r "../Dependencies/Antlr3.Runtime.dll"
#r "../IronJS.CSharp/bin/Debug/IronJS.CSharp.dll"
#load "Utils.fs"
#load "Types.fs"
#load "Ast.fs"

open IronJS
open System
open Antlr.Runtime
open IronJS.CSharp.Parser

fsi.AddPrinter(fun (x:Ast.Local) -> sprintf "\"cls: %b, used: %A && %A, index: %i\"" x.ClosedOver x.UsedAs x.UsedWith x.ParamIndex)

System.IO.Directory.SetCurrentDirectory(@"C:\Users\Fredrik\Projects\IronJS\Src\IronJS")

let jsLexer = new ES3Lexer(new ANTLRFileStream("Testing.js"))
let jsParser = new ES3Parser(new CommonTokenStream(jsLexer))

let program = jsParser.program()
let ast = Ast.defaultGenerator program.Tree