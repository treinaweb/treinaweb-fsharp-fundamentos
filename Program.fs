// Learn more about F# at http://fsharp.org

open System

type Person = {
    name: string
    age: int
}

[<EntryPoint>]
let main argv =
    let mutable name = ""
    printf "Digite o nome de seus amigos. Digite 'sair' quando quiser interromper. \n"
    let names = [
        while name <> "sair" do
            printf "Nome: "
            name <- Console.ReadLine()
            if name <> "sair" then
                printf "Idade: "
                let age = int(Console.ReadLine())
                printf "******* \n"
                yield { name = name; age = age }
    ]
    printf "Você tem %d amigos! \n" names.Length
    printf "==============================\n"
    // printf "Nomes dos amigos digitados: \n"
    // names |> List.iter(fun n -> printf " - %s \n" n)
    names |> List.map(fun n -> "Olá, " + n.name)
          |> List.iter(fun welcome -> printf "%s \n" welcome)
    printf "==============================\n"
    // names |> List.iter(fun n -> printf " - %s \n" n)
    0 // return an integer exit code