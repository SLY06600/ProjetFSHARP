// For more information see https://aka.ms/fsharp-console-apps
// printfn "Hello from F#"

// namespace MonProjetFSHARP
open System
open MonProjetFSHARP.Models




[<EntryPoint>]
let main argv =
    let person1 = Person("Alice", 30)
    let person2 = Person("Bob", 25)

    person1.SayHello()
    person2.SayHello()

    Person.sayHello("Charlie")
    let employee1 = Employee("David", 40, "Manager")
    employee1.SayHello()
    Employee.sayHello("Eve", "Developer")

    

    0 // return an integer exit code

    




