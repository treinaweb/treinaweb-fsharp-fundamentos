// Learn more about F# at http://fsharp.org

open System

type Person = {
    name: string
    age: int
}

let getOldestPerson people =
    people |> List.maxBy(fun p -> p.age)

let getYoungerPerson people =
    people |> List.minBy(fun p -> p.age)

let getPageableContent people pageNumber = 
    people |> List.sortBy(fun p -> p.name)
           |> List.skip((pageNumber - 1) * 3)
        //    |> List.take(3)
           |> List.truncate(3)

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

    printf "Digite o termo de busca por nome: "
    let searchArg = Console.ReadLine()
    printf "\nRESULTADOS\n"
    names |> List.where(fun person -> person.name.Contains(searchArg))   
          |> List.map(fun person -> { name = person.name.ToUpper(); age = person.age }) 
          |> List.iter(fun person -> printf " - %s, %d anos \n" person.name person.age)
    printf "==============================\n"

    printf "Sumário: \n"
    let oldestPerson = names |> getOldestPerson
    printf " - Seu amigo mais velho é o %s, com %d anos \n" oldestPerson.name oldestPerson.age
    let youngerPerson = names |> getYoungerPerson
    printf " - Seu amigo mais novo é o %s, com %d anos \n" youngerPerson.name youngerPerson.age
    printf " - A média de idade dos seus amigos é %d anos\n" ((names |> List.sumBy(fun person -> person.age)) / names.Length)
    printf "==============================\n"

    let mutable pageNumber = 1
    while pageNumber <> 0 do
        printf "Digite a página desejada: "
        pageNumber <- int(Console.ReadLine())
        if pageNumber <> 0 then
            getPageableContent names pageNumber |> List.iter(fun p -> printf " - %s, %d anos \n" p.name p.age)
            printf "==============================\n"
    // names |> List.iter(fun n -> printf " - %s \n" n)
    0 // return an integer exit code
