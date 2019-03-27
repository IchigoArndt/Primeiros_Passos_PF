// Learn more about F# at http://fsharp.org

open System


let diasVidas ano anoNasc = 
    let y = ano - anoNasc
    let z = y * 365
//seria o return
    z


[<EntryPoint>]

let main argv =
    printfn "----Programa de Menu Basico----"
    printfn "--1 Mostrar subtração de datas"
    printfn "--2 Mostrar o Total de dias de uma pessoa"
    printfn "--3 Sair"
    let opcaoUsuario = Console.ReadLine()
    //printfn "%s" opcaoUsuario
    if int32 opcaoUsuario = 2 
    then
       printfn "Digite o ano atual:"
       let ano = Console.ReadLine()
       //Casting de string para int
       let anoAtual = int32 ano
       printfn "Digite o ano de nascimento"
       let ano2 = Console.ReadLine()
       //Casting
       let anoNasc = int32 ano2
       //Chama a função e Armazena o retorno
       let dias  = diasVidas anoAtual anoNasc
       printfn "O total de dias vivdos desta pessoa é de: %d" dias
    else printfn "São Iguais"  
    0 // return an integer exit code

