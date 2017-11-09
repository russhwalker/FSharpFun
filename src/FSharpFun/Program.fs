open System

let PrintHellowWorld() =
    printfn "Hello World"

[<EntryPoint>]
let main argv = 
    PrintHellowWorld()
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code