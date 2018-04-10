// Learn more about F# at http://fsharp.org

open System

let buildMessage (name: string): string = 
    if name.Length > 5 then
        "Olá, " + name + ". Seu nome é longo."
    else
        "Olá, " + name + ". Seu nome é curto."

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "Digite seu nome: "
    let mutable nome: string = Console.ReadLine()
    // printf "Seu nome é %s\n" nome
    // nome <- nome + "Mudei o valor"
    // printf "Seu nome é %s\n" nome
    // let nomeEhIgual = nome = "Mudei o valor"
    // printf "%b\n" nomeEhIgual
    printf "%s\n" (buildMessage nome)
    0 // return an integer exit code