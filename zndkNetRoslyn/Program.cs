using System;
using System.IO;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace zndkNetRoslyn
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Run a C# script
            string csscript_string      = "System.Console.WriteLine(\"Run a C# script.\");";
            CSharpScript.RunAsync(csscript_string         ).Wait();

            // 2. Runa C# script with a file.
            string file_csscript        = "../../00_test.csx";
            string csscript_file        = File.ReadAllText(file_csscript);
            CSharpScript.RunAsync(csscript_file           ).Wait();

            // 3. Run a C# script with a nested FILE
            var ssr = ScriptSourceResolver.Default.WithBaseDirectory (Environment.CurrentDirectory);
            var so  =        ScriptOptions.Default.WithSourceResolver(ssr);
            string file_csscript_nested = "../../01_foo.csx";
            string csscript_file_nested = File.ReadAllText(file_csscript_nested);
            CSharpScript.RunAsync(csscript_file_nested, so).Wait();

#if DEBUG
            Console.WriteLine("Press ANY key to continue...");
            Console.ReadKey();
#endif
        }
    }
}
