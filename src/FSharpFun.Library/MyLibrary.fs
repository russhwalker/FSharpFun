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

let GetName name =
    if (System.String.IsNullOrWhiteSpace(name)) then
        "who are you"
    else
        name

let SayMyName name =
    printfn "%s" (GetName(name))

let ForLoopNumbers count =
    for i in 0..count do
        printfn "%i" i

let NestedFunc text =
    let printIt s =
        printfn "nested text: %s" s
    printIt(text)
