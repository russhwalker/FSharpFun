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

let printTypeAndName obj name = 
    printfn "%s : %s" (obj.GetType().ToString()) name

let Run =
    printTypeAndName cat cat.Name
    printTypeAndName dog dog.Name
    printTypeAndName person1 person1.Name
    printTypeAndName person2 person2.Name