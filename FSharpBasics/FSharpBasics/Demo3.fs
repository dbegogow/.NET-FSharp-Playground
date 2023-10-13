namespace FSharpBasics

open System

module Program =
    [<EntryPoint>]
    let main args =
        // 1 -> 3
        // 2 -> 4
        // 3 -> 5
        let add2 x = x + 2
        printfn "Hi, what is your name? "
        let name = Console.ReadLine()
        0