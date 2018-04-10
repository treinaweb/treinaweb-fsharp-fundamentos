// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "Digite seu nome: "
    let nome = Console.ReadLine()
    printf "Seu nome é %s\n" nome
    0 // return an integer exit code