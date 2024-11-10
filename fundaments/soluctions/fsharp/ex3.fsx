// Solution exercice 3
open System
let choose option (qtd:int) =
    match option with
    | 1 -> 4.0 * float qtd
    | 2 -> 4.5 * float qtd
    | 3 -> 5.0 * float qtd
    | 4 -> 2.0 * float qtd
    | 5 -> 1.5 * float qtd
    | _ -> 0.0 * float qtd

let option = Console.ReadLine().Split ' '

printfn "Total: R$ %.2f" (choose (int option.[0]) (int option.[1]))