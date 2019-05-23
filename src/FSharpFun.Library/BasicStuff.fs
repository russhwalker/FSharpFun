#if INTERACTIVE
#else
module BasicStuff
#endif


let SaySomething thing =
    printfn "This is the %s" thing
    
let SaySomethingAsInt thing =
    printfn "This is the %i" thing
    
let MultiplyIt x y =
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

let ReturnTuple =
    3, 7, 9

let PartialReturn =
    let r =
        MultiplyIt 2
    r 3

let Run =
    printfn "hello world"
    printfn "MultiplyIt: %i" (MultiplyIt 3 4)
    SaySomethingAsInt(3)
    SayMyName("")
    SayMyName("russ")
    ForLoopNumbers(5)
    NestedFunc("text")
    printfn "My Tuple: %i %i %i" <||| (ReturnTuple)
    printfn "%i" PartialReturn