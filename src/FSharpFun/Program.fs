open System

let PrintHellowWorld() =
    printfn "Hello World"

[<EntryPoint>]
let main argv = 
    PrintHellowWorld()
    printfn "DoubleIt: %i" (LibraryStuff.DoubleIt(3))
    LibraryStuff.SaySomethingAsInt(3)
    LibraryStuff.SayMyName("")
    LibraryStuff.SayMyName("russ")
    LibraryStuff.ForLoopNumbers(5)
    LibraryStuff.NestedFunc("text")
    System.Console.ReadKey() |> ignore
    0