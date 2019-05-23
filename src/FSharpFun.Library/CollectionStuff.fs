
module CollectionStuff

let arr1 = [|1;2;3;|]
let makes = [|
    "chevy"
    "ford"
    "jeep"
    "toyota"
    |]
let arr3 = [|0..9|]

let printStrings strings=
    for s in strings do
        printfn "%s" s

let IsLength (s: string) (l: int) =
    s.Length = l

let filterMakesByLength l =
    Array.filter(fun m -> IsLength m l) makes

let mutateArray index value =
    arr1.[index] <- value

let list1 = [1,2,3]

let seq1 = {0..9}

let Run =
    printfn "%A %A" arr1 makes
    printfn "%i" arr3.[7]
    printStrings(makes)
    printfn "%A" (filterMakesByLength(4))
    mutateArray 1 9
    printfn "%A" arr1
    printfn "%A" list1
    printfn "%A" seq1