module Program

open System
// For more information see https://aka.ms/fsharp-console-apps

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    
    printfn "Hello from F#"
    Examples.Example1.run()
    0 // return an integer exit code


