open System

let PrintHellowWorld() =
    printfn "Hello World"

[<EntryPoint>]
let main argv = 
    PrintHellowWorld()
    //BasicStuff.Run |> ignore
    CollectionStuff.Run |> ignore
    System.Console.ReadKey() |> ignore
    0