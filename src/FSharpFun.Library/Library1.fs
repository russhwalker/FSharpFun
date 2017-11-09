#if INTERACTIVE
#else
module LibraryStuff
#endif

let SaySomething thing =
    printfn "This is the %s" thing
    
let SaySomethingAsInt thing =
    printfn "This is the %i" thing

let x = 2
let DoubleIt y =
    x * y

