// Use this file to define the Person class, which represents a person with a name and age, and includes methods for saying hello.
namespace MonProjetFSHARP.Models

type Person(name: string, age: int) =

    member this.Name = name
    member this.Age = age

    member this.SayHello() =
        printfn "Bonjour, je suis %s et j'ai %d ans" this.Name this.Age
    static member sayHello(name: string) =
        printfn "Hello, %s!" name


