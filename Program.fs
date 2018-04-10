// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let mutable name = ""
    printf "Digite o nome de seus amigos. Digite 'sair' quando quiser interromper. \n"
    let names = [
        while name <> "sair" do
            name <- Console.ReadLine()
            if name <> "sair" then
                yield name
    ]
    printf "Você tem %d amigos! \n" names.Length
    printf "==============================\n"
    0 // return an integer exit code