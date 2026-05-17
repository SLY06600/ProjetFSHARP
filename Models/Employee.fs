namespace MonProjetFSHARP.Models


type Employee(name: string, age: int, position: string) =
    inherit Person(name, age)

    member this.Position = position

    

    member this.SayHello() =
        printfn "Bonjour, je suis %s, j'ai %d ans et je suis %s" this.Name this.Age this.Position
    static member sayHello(name: string, position: string) =
        printfn "Hello, %s! Your position is %s." name position
        
