module Examples
open System
//This module that will ask the user to enter their name, 
//height and age. The module will then print the name, 
//height and age out to the console.
// A function to ask the user to enter their name, age, and height.
//let askUserForInfo() =
module Example1 =
    let run() =
        printfn "Example 1"
        
        printfn "What is your name?"
        let name = Console.ReadLine()
        printfn "What is your age?"
        let age = Console.ReadLine()
        printfn "What is your height?"
        let height = Console.ReadLine()
        printfn "Your name is %s, you are %s years old, and you are %s tall." name age height


module Example2 =
    let run() =
        printfn "Example 2"

module Example3 =
    let run() =
        printfn "Example 3"

module Example4 =
    let run() =
        printfn "Example 4"