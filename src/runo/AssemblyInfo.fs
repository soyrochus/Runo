namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("runo")>]
[<assembly: AssemblyProductAttribute("runo")>]
[<assembly: AssemblyDescriptionAttribute("Runo ('runes') - Magic words for F#")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
