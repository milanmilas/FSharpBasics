// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

//0
//    let chrisTest test = test "Milan"
//    
//    let result =  chrisTest (fun x -> if x = "Chris" then "it is Chris!" else "it's someone else")
//
//    printfn "%s" result
//
//    System.Console.ReadLine()

//1
//[<Literal>] let upperLimit = 100;
//
//seq {1..upperLimit}
//|> Seq.filter n%2 = 0
//|> Seq.sum
//|> printfn "the sum of the odd numbers from 1 to 100 is: %A"
//System.Console.ReadLine()

//2
//let f0 x = x + 1
//let f1 x = x + 2
//let g = f0 >> f1
//let res = g 2
//
//printfn "res = %A" res

//Euler 1
//seq {1..1000}
//|> Seq.where(fun x -> x%3 = 0 || x%5 = 0)
//|> Seq.sum

//Euler 2
let problem = 
    let fib = Seq.unfold (fun (a,b) -> Some(a+b, (b,a+b))) (0,1)
    fib
    |> Seq.takeWhile (fun x -> x <= 4000000)
    |> Seq.sumBy (fun x -> if x%2 =0 then x else 0)



0 // return an integer exit code
