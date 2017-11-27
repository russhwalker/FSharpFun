module FilereadFun

[<StructuredFormatDisplay("ID: {ID} Name: {Name} BirthDate: {BirthDate}")>]
type Person(ID : int, Name : string, BirthDate : System.DateTime) =
    member this.ID = ID
    member this.Name = Name
    member this.BirthDate = BirthDate

let importFilePath = "C:\Dev\Repos\FSharpFun\src\FSharpFun.Library\ImportFile.csv"

let getRecords2 filePath =
    System.IO.File.ReadAllLines(filePath) |> 
    Seq.map(fun row -> row.Split(',')) |>
    Seq.map(fun row -> new Person(System.Int32.Parse(row.[0]), row.[1], System.DateTime.Parse(row.[2])))

let persons =
    getRecords2(importFilePath)

let Run =
    printfn "%A" persons
    0