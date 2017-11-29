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

let cat = { Name = "SomeCat"; BirthDate = new System.DateTime(2017, 1, 1) }
let dog = { Dog.Name = "SomeDog"; BirthDate = System.DateTime.Today }
let person1 = { Name = "SomePerson"; BirthDate = System.DateTime.Today; City = "Columbia" }
let person2 = { person1 with Name = "OtherPerson" }

let Run =
    printfn "%s" cat.Name
    printfn "%s" dog.Name
    printfn "%s" person1.Name
    printfn "%s" person2.Name