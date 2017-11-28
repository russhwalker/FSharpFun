module RecordStuff

type Dog =
    {
        Name : string
        BirthDate: System.DateTime
    }

type Cat =
    {
        Name : string
        BirthDate: System.DateTime
    }

type Person =
    {
        Name : string
        BirthDate: System.DateTime
        City : string
    }

let cat = { Name = "SomeCat"; BirthDate = System.DateTime.Today }
let dog = { Dog.Name = "SomeDog"; BirthDate = System.DateTime.Today }
let person = { Name = "SomePerson"; BirthDate = System.DateTime.Today; City = "Columbia" }

let Run =
    printfn "%s" cat.Name
    printfn "%s" dog.Name
    printfn "%s" person.Name