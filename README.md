This repro was cloned from the SAFE Dojo and illustrates an apparent bug in the F# compiler.

Repro: go to src\Client directory and attempt msbuild

Result: F# compiler error FS0192 : internal error : primDestForallTy: not a forall type [c:\code\SafeDojo2\src\Client\Client.fsproj]


Microsoft (R) Build Engine version 15.7.179.6572 for .NET Framework
Copyright (C) Microsoft Corporation. All rights reserved.

Build started 7/4/2018 8:11:59 PM.
Project "c:\code\SafeDojo2\src\Client\Client.fsproj" on node 1 (default targets).
ValueTuplePackageReferences:
  PackageReferences: ValueTuplePackageReferences start : NETStandard.Library;System.ValueTuple;Fable.Import.Browser;Fable.PowerPack;Fable.Elmish;Fable.Elmish.Debugger;Fable.Elmish.HMR;Fable.React;Fable.Elmish.React;Fable.Recharts;Fulma
GenerateTargetFrameworkMonikerAttribute:
Skipping target "GenerateTargetFrameworkMonikerAttribute" because all output files are up-to-date with respect to the input files.
CoreCompile:
  C:\Program Files (x86)\Microsoft SDKs\F#\10.1\Framework\v4.0\fsc.exe -o:obj\Debug\netstandard2.0\Client.dll
  -g
  --debug:portable
  --noframework
  --define:TRACE
  --define:DEBUG
  --define:NETSTANDARD
  --define:NETSTANDARD2_0
  --optimize-
  -r:C:\Users\wilso\.nuget\packages\fable.core\1.3.8\lib\netstandard1.6\Fable.Core.dll
  -r:C:\Users\wilso\.nuget\packages\fable.elmish.debugger\1.0.1\lib\netstandard1.6\Fable.Elmish.Debugger.dll
  -r:C:\Users\wilso\.nuget\packages\fable.elmish\1.0.1\lib\netstandard1.6\Fable.Elmish.dll
  -r:C:\Users\wilso\.nuget\packages\fable.elmish.hmr\1.0.0\lib\netstandard1.6\Fable.Elmish.HMR.dll
  -r:C:\Users\wilso\.nuget\packages\fable.elmish.react\1.0.3\lib\netstandard1.6\Fable.Elmish.React.dll
  -r:C:\Users\wilso\.nuget\packages\fable.import.browser\1.1.1\lib\netstandard1.6\Fable.Import.Browser.dll
  -r:C:\Users\wilso\.nuget\packages\fable.powerpack\1.3.5\lib\netstandard1.6\Fable.PowerPack.dll
  -r:C:\Users\wilso\.nuget\packages\fable.react\3.0.0\lib\netstandard1.6\Fable.React.dll
  -r:C:\Users\wilso\.nuget\packages\fable.recharts\0.1.0-beta-002\lib\netstandard1.6\Fable.Recharts.dll
  -r:C:\Users\wilso\.nuget\packages\fsharp.core\4.2.3\lib\netstandard1.6\FSharp.Core.dll
  -r:C:\Users\wilso\.nuget\packages\fulma\1.0.0-beta-007\lib\netstandard1.6\Fulma.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\Microsoft.Win32.Primitives.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\mscorlib.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\netstandard.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.AppContext.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Collections.Concurrent.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Collections.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Collections.NonGeneric.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Collections.Specialized.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.ComponentModel.Composition.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.ComponentModel.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.ComponentModel.EventBasedAsync.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.ComponentModel.Primitives.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.ComponentModel.TypeConverter.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Console.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Core.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Data.Common.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Data.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.Contracts.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.Debug.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.FileVersionInfo.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.Process.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.StackTrace.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.TextWriterTraceListener.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.Tools.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.TraceSource.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Diagnostics.Tracing.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Drawing.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Drawing.Primitives.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Dynamic.Runtime.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Globalization.Calendars.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Globalization.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Globalization.Extensions.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.Compression.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.Compression.FileSystem.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.Compression.ZipFile.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.FileSystem.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.FileSystem.DriveInfo.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.FileSystem.Primitives.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.FileSystem.Watcher.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.IsolatedStorage.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.MemoryMappedFiles.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.Pipes.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.IO.UnmanagedMemoryStream.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Linq.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Linq.Expressions.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Linq.Parallel.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Linq.Queryable.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.Http.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.NameResolution.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.NetworkInformation.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.Ping.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.Primitives.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.Requests.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.Security.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.Sockets.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.WebHeaderCollection.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.WebSockets.Client.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Net.WebSockets.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Numerics.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.ObjectModel.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Reflection.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Reflection.Extensions.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Reflection.Primitives.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Resources.Reader.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Resources.ResourceManager.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Resources.Writer.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.CompilerServices.VisualC.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.Extensions.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.Handles.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.InteropServices.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.InteropServices.RuntimeInformation.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.Numerics.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.Serialization.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.Serialization.Formatters.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.Serialization.Json.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.Serialization.Primitives.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Runtime.Serialization.Xml.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Security.Claims.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Security.Cryptography.Algorithms.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Security.Cryptography.Csp.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Security.Cryptography.Encoding.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Security.Cryptography.Primitives.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Security.Cryptography.X509Certificates.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Security.Principal.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Security.SecureString.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.ServiceModel.Web.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Text.Encoding.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Text.Encoding.Extensions.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Text.RegularExpressions.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Threading.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Threading.Overlapped.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Threading.Tasks.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Threading.Tasks.Parallel.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Threading.Thread.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Threading.ThreadPool.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Threading.Timer.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Transactions.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.ValueTuple.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Web.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Windows.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.Linq.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.ReaderWriter.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.Serialization.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.XDocument.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.XmlDocument.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.XmlSerializer.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.XPath.dll
  -r:C:\Users\wilso\.nuget\packages\netstandard.library\2.0.3\build\netstandard2.0\ref\System.Xml.XPath.XDocument.dll
  --target:library
  --nowarn:NU1603
  --warn:3
  --warnaserror:76
  --fullpaths
  --flaterrors
  --highentropyva-
  --targetprofile:netstandard
  --simpleresolution
  --nocopyfsharpcore
  ../Shared/Shared.fs
  ViewHelpers.fs
  app.fs
  Client.fs
  C:\Users\wilso\AppData\Local\Temp\.NETStandard,Version=v2.0.AssemblyAttributes.fs
  
  
error FS0192 : internal error : primDestForallTy: not a forall type [c:\code\SafeDojo2\src\Client\Client.fsproj]
  
  Unhandled Exception: System.Exception: primDestForallTy: not a forall type
     at Microsoft.FSharp.Compiler.Tastops.primDestForallTy(TcGlobals g, TType ty)
     at Microsoft.FSharp.Compiler.Tastops.destForallTy(TcGlobals g, TType ty)
     at Microsoft.FSharp.Compiler.Tastops.applyForallTy(TcGlobals g, TType ty, FSharpList`1 tyargs)
     at Microsoft.FSharp.Compiler.Tastops.mkAppsAux(TcGlobals g, Expr f, TType fty, FSharpList`1 tyargsl, FSharpList`1 argsl, range m)
     at Microsoft.FSharp.Compiler.Tastops.MakeApplicationAndBetaReduceAux(TcGlobals g, Expr f, TType fty, FSharpList`1 tyargsl, FSharpList`1 argsl, range m)
     at Microsoft.FSharp.Compiler.IlxGen.GenGetStorageAndSequel(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, range m, TType typ, ILType ilTy, ValStorage storage, FSharpOption`1 storeSequel)
     at Microsoft.FSharp.Compiler.IlxGen.GenExprs@1970.Invoke(Expr e)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenAllocUnionCase(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, UnionCaseRef c, FSharpList`1 tyargs, FSharpList`1 args, range m, sequel sequel)
     at Microsoft.FSharp.Compiler.IlxGen.GenExpr(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, EmitSequencePointState sp, Expr expr, sequel sequel)
     at Microsoft.FSharp.Compiler.IlxGen.GenBindingAfterSequencePoint(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, EmitSequencePointState sp, Binding _arg8, FSharpOption`1 startScopeMarkOpt)
     at Microsoft.FSharp.Compiler.IlxGen.GenExpr(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, EmitSequencePointState sp, Expr expr, sequel sequel)
     at Microsoft.FSharp.Compiler.IlxGen.GenExprs@1970.Invoke(Expr e)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenAllocUnionCase(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, UnionCaseRef c, FSharpList`1 tyargs, FSharpList`1 args, range m, sequel sequel)
     at Microsoft.FSharp.Compiler.IlxGen.GenExpr(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, EmitSequencePointState sp, Expr expr, sequel sequel)
     at Microsoft.FSharp.Compiler.IlxGen.GenUntupledArgsDiscardingLoneUnit@2442.Invoke(FSharpList`1 argInfos, Expr x)
     at Microsoft.FSharp.Collections.ListModule.loop@188-27[T1,T2](FSharpFunc`3 f, FSharpList`1 list1, FSharpList`1 list2)
     at Microsoft.FSharp.Collections.ListModule.Iterate2[T1,T2](FSharpFunc`2 action, FSharpList`1 list1, FSharpList`1 list2)
     at Microsoft.FSharp.Compiler.IlxGen.GenApp(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, Expr f, TType fty, FSharpList`1 tyargs, FSharpList`1 args, range m, sequel sequel)
     at Microsoft.FSharp.Compiler.IlxGen.CodeGenMethodForExpr@1975.Invoke(CodeGenBuffer cgbuf, IlxGenEnv eenv)
     at Microsoft.FSharp.Compiler.IlxGen.CodeGenThen(cenv cenv, AssemblyBuilder mgbuf, FSharpList`1 entryPointInfo, String methodName, IlxGenEnv eenv, Int32 alreadyUsedArgs, Int32 alreadyUsedLocals, FSharpFunc`2 codeGenFunction, range m)
     at Microsoft.FSharp.Compiler.IlxGen.CodeGenMethod(cenv cenv, AssemblyBuilder mgbuf, FSharpList`1 entryPointInfo, String methodName, IlxGenEnv eenv, Int32 alreadyUsedArgs, Int32 alreadyUsedLocals, FSharpFunc`2 codeGenFunction, range m)
     at Microsoft.FSharp.Compiler.IlxGen.CodeGenMethodForExpr(cenv cenv, AssemblyBuilder mgbuf, EmitSequencePointState spReq, FSharpList`1 entryPointInfo, String methodName, IlxGenEnv eenv, Int32 alreadyUsedArgs, Int32 alreadyUsedLocals, Expr expr0, sequel sequel0)
     at Microsoft.FSharp.Compiler.IlxGen.GenMethodForBinding(cenv cenv, CodeGenBuffer cgbuf, IlxGenEnv eenv, Val v, ILMethodSpec mspec, ILMemberAccess access, FSharpList`1 paramInfos, ArgReprInfo retInfo, ValReprInfo topValInfo, FSharpOption`1 ctorThisValOpt, FSharpOption`1 baseValOpt, FSharpList`1 tps, FSharpList`1 methodVars, Expr body, TType returnTy)
     at Microsoft.FSharp.Compiler.IlxGen.GenBindings@5367.Invoke(Binding bind)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDef(cenv cenv, CodeGenBuffer cgbuf, QualifiedNameOfFile qname, List`1 lazyInitInfo, IlxGenEnv eenv, ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDefs@5799.Invoke(ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDef(cenv cenv, CodeGenBuffer cgbuf, QualifiedNameOfFile qname, List`1 lazyInitInfo, IlxGenEnv eenv, ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleBinding(cenv cenv, CodeGenBuffer cgbuf, QualifiedNameOfFile qname, List`1 lazyInitInfo, IlxGenEnv eenv, range m, ModuleOrNamespaceBinding x)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDef@5808-1.Invoke(ModuleOrNamespaceBinding x)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDefs@5799.Invoke(ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDef(cenv cenv, CodeGenBuffer cgbuf, QualifiedNameOfFile qname, List`1 lazyInitInfo, IlxGenEnv eenv, ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleBinding(cenv cenv, CodeGenBuffer cgbuf, QualifiedNameOfFile qname, List`1 lazyInitInfo, IlxGenEnv eenv, range m, ModuleOrNamespaceBinding x)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDef@5808-1.Invoke(ModuleOrNamespaceBinding x)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDefs@5799.Invoke(ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDef(cenv cenv, CodeGenBuffer cgbuf, QualifiedNameOfFile qname, List`1 lazyInitInfo, IlxGenEnv eenv, ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDefs@5799.Invoke(ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Primitives.Basics.List.iter[T](FSharpFunc`2 f, FSharpList`1 x)
     at Microsoft.FSharp.Collections.ListModule.Iterate[T](FSharpFunc`2 action, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleDef(cenv cenv, CodeGenBuffer cgbuf, QualifiedNameOfFile qname, List`1 lazyInitInfo, IlxGenEnv eenv, ModuleOrNamespaceExpr x)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleExpr@5789.Invoke(Tuple`2 scopeMarks)
     at Microsoft.FSharp.Compiler.IlxGen.LocalScope[a](String nm, CodeGenBuffer cgbuf, FSharpFunc`2 f)
     at Microsoft.FSharp.Compiler.IlxGen.GenModuleExpr(cenv cenv, CodeGenBuffer cgbuf, QualifiedNameOfFile qname, List`1 lazyInitInfo, IlxGenEnv eenv, ModuleOrNamespaceExprWithSig x)
     at Microsoft.FSharp.Compiler.IlxGen.GenTopImpl@5908.Invoke(CodeGenBuffer cgbuf, IlxGenEnv eenv)
     at Microsoft.FSharp.Compiler.IlxGen.CodeGenThen(cenv cenv, AssemblyBuilder mgbuf, FSharpList`1 entryPointInfo, String methodName, IlxGenEnv eenv, Int32 alreadyUsedArgs, Int32 alreadyUsedLocals, FSharpFunc`2 codeGenFunction, range m)
     at Microsoft.FSharp.Compiler.IlxGen.CodeGenMethod(cenv cenv, AssemblyBuilder mgbuf, FSharpList`1 entryPointInfo, String methodName, IlxGenEnv eenv, Int32 alreadyUsedArgs, Int32 alreadyUsedLocals, FSharpFunc`2 codeGenFunction, range m)
     at Microsoft.FSharp.Compiler.IlxGen.GenTopImpl(cenv cenv, AssemblyBuilder mgbuf, FSharpOption`1 mainInfoOpt, IlxGenEnv eenv, TypedImplFile _arg11, FSharpFunc`2 optimizeDuringCodeGen)
     at Microsoft.FSharp.Compiler.IlxGen.eenv@6846-1.Invoke(IlxGenEnv eenv, Tuple`2 tupledArg)
     at Microsoft.FSharp.Collections.ListModule.Fold[T,TState](FSharpFunc`2 folder, TState state, FSharpList`1 list)
     at Microsoft.FSharp.Compiler.IlxGen.CodegenAssembly(cenv cenv, IlxGenEnv eenv, AssemblyBuilder mgbuf, FSharpList`1 fileImpls)
     at Microsoft.FSharp.Compiler.IlxGen.GenerateCode(cenv cenv, IlxGenEnv eenv, TypedAssemblyAfterOptimization _arg1, FSharpList`1 assemAttribs, FSharpList`1 moduleAttribs)
     at Microsoft.FSharp.Compiler.IlxGen.IlxAssemblyGenerator.GenerateCode(IlxGenOptions codeGenOpts, TypedAssemblyAfterOptimization typedAssembly, FSharpList`1 assemAttribs, FSharpList`1 moduleAttribs)
     at Microsoft.FSharp.Compiler.CompileOptions.GenerateIlxCode(IlxGenBackend ilxBackend, Boolean isInteractiveItExpr, Boolean isInteractiveOnMono, TcConfig tcConfig, TopAttribs topAttrs, TypedAssemblyAfterOptimization optimizedImpls, String fragName, IlxAssemblyGenerator ilxGenerator)
     at Microsoft.FSharp.Compiler.Driver.main2b[a,b,c,d,e,f,g,h](FSharpOption`1 tcImportsCapture, FSharpOption`1 dynamicAssemblyCreator, Args`1 _arg1)
     at Microsoft.FSharp.Compiler.Driver.typecheckAndCompile(CompilationThreadToken ctok, String[] argv, Resolver legacyReferenceResolver, Boolean bannerAlreadyPrinted, ReduceMemoryFlag reduceMemoryUsage, CopyFSharpCoreFlag defaultCopyFSharpCore, Exiter exiter, ErrorLoggerProvider loggerProvider, FSharpOption`1 tcImportsCapture, FSharpOption`1 dynamicAssemblyCreator)
     at Microsoft.FSharp.Compiler.CommandLineMain.Driver.main(String[] argv)
     at Microsoft.FSharp.Compiler.CommandLineMain.main(String[] argv)
     at Microsoft.FSharp.Compiler.ErrorLogger.ErrorLoggerExtensions.ReraiseIfWatsonable(Exception exn)
     at Microsoft.FSharp.Compiler.ErrorLogger.ErrorLoggerExtensions.ErrorLogger.ErrorRecovery(ErrorLogger x, Exception exn, range m)
     at Microsoft.FSharp.Compiler.CommandLineMain.main(String[] argv)
Done Building Project "c:\code\SafeDojo2\src\Client\Client.fsproj" (default targets) -- FAILED.

Build FAILED.

"c:\code\SafeDojo2\src\Client\Client.fsproj" (default target) (1) ->
(CoreCompile target) -> 
  error FS0192 : internal error : primDestForallTy: not a forall type [c:\code\SafeDojo2\src\Client\Client.fsproj]

    0 Warning(s)
    1 Error(s)

Time Elapsed 00:00:04.82
