# zndkNetRoslyn
C# scripting test

Visual Studio 2015 Comminity, .NET Framework 4.6 (required 4.6+)

## Getting Started
### Preparation
```PowerShell
PM> Install-Package Microsoft.CodeAnalysis.Scripting
PM> Install-Package Microsoft.CodeAnalysis.CSharp.Scripting
```

### Build and Run
```
[Build] menu > Clean Solution
[Build] menu > Rebuild Solution
[F5]

Console will be opened.
-------------------------------
Run a C# script.                   ... written in Program.cs
Run a C# script w/ FILE.           ... written in 00_test.csx
Run a C# script w/ nested FILE     ... written in 02_bar.csx, loaded by 01_foo.csx
Press ANY key to continue...
-------------------------------
```
.
