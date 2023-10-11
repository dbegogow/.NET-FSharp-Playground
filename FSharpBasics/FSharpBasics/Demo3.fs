namespace FSharpBasics

open System

module Program =
    [<EntryPoint>]
    let main args =
        let age = 21
        printfn "Hello world and I am %i" age
        0