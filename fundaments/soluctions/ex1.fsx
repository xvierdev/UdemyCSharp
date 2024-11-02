// Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
// código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. 

open System

let SplitString () =
    let array = Console.ReadLine().Split ' '
    let code = array.[0]
    let quantity = int array.[1]
    let price = float array.[2]
    code, quantity, price

let code, quantity, price = SplitString()
let totalPrice1 = float quantity * price

let totalPrice = totalPrice1

printfn "VALOR A PAGAR: R$ %.2f" totalPrice1
