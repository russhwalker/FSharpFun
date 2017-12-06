module OptionStuff

type Person =
    {
        Name : string
        City : string option
    }

let person1 = { Name = "SomePerson1"; City = Some "Columbia" }
let person2 = { Name = "SomePerson2"; City = None }

let printPerson person =
    let cityValue =
        match person.City with
        | Some n -> sprintf "%s" n
        | None -> ""
    printfn "Name:%s City: %s" person.Name cityValue


type LivingThing = 
    | Human of int
    | PetDog of int

let h = Human 5
let d = PetDog 5
let livingThings = [|h; d|]

let Age (lt : LivingThing) =
    match lt with
    |Human x -> x
    |PetDog y -> y * 7

let totalAges = livingThings |> Array.sumBy(fun s -> Age s)

let printAge lt =
    printfn "%i" (Age(lt))

let Run =
    printPerson(person1)
    printPerson(person2)
    printAge(h)
    printAge(d)
    printfn "%i" totalAges