open System

let PrintHellowWorld() =
    printfn "Hello World"

[<EntryPoint>]
let main argv = 
    PrintHellowWorld()
    printfn "%i" (LibraryStuff.DoubleIt(3))
    System.Console.ReadKey() |> ignore
    0