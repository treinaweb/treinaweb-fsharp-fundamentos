// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "Digite seu nome: "
    let mutable nome = Console.ReadLine()
    printf "Seu nome é %s\n" nome
    nome <- nome + "Mudei o valor"
    printf "Seu nome é %s\n" nome
    // let nomeEhIgual = nome = "Mudei o valor"
    // printf "%b\n" nomeEhIgual
    0 // return an integer exit code