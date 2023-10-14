namespace FSharpBasics

open System
open System.Threading

module Program =
    [<EntryPoint>]
    let main args =
        printfn "Hi, what is your name? "
        let name = Console.ReadLine()
        printfn "Hi %s" name
        
        let currentTime () =
            DateTime.Now

        currentTime()
        |> printfn "Time = %O"

        Thread.Sleep 2000

        currentTime()
        |> printfn "Time = %O"
        0