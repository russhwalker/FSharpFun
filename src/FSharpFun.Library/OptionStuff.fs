module OptionStuff

type Person =
    {
        Name : string
        City : string option
    }

let person1 = { Name = "SomePerson1"; City = Some "Columbia" }
let person2 = { Name = "SomePerson2"; City = None }

let printPerson person =
    printfn "%s" person.Name

let Run =
    printPerson(person1)
    printPerson(person2)