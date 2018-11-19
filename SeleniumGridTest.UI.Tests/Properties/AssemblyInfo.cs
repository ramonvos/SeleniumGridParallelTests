using NUnit.Framework;
using SeleniumGridTest.Helpers.SetupParallel;
using System;
using System.Configuration;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("SeleniumGridTest.UI.Tests")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SeleniumGridTest.UI.Tests")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: Parallelizable(ParallelScope.Self)]
[assembly: LevelOfParallelism(3)]
//[assembly: LevelOfParallelism(ConfigParallelTests.LevelOfParallelism)]

[assembly: ComVisible(false)]

[assembly: Guid("ed2ad054-0fcf-49f2-840a-642ad2d8d99c")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
