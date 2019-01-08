#if INTERACTIVE
#else
module Library4
#endif

open System.IO

// function to read first line from a file
let readFirstLine filename =
    // open file using a "use" binding
    use file = File.OpenText filename
    file.ReadLine()

// call function and print the result
printfn "First line was: %s" (readFirstLine (__SOURCE_DIRECTORY__ + "/mytext.txt"))

// a function to generate the Fibonacci numbers
let rec fib x =
    match x with
    | 1 -> 1
    | 2 -> 1
    | x -> fib (x - 1) + fib (x - 2)

// call the function and print the results
printfn "(fib 2) = %i" (fib 2)
printfn "(fib 6) = %i" (fib 6)
printfn "(fib 11) = %i" (fib 11)

let rhyme = "Jack " + "and " + "Jill"

open System
let oneYearLater =
    DateTime.Now + new TimeSpan(365, 0, 0, 0, 0)

let (+*) a b = (a + b) * a * b
printfn "(1 +* 2) = %i" (1 +* 2)

let add x y = x + y
let result = add 4 5
printfn "(add 4 5) = %i" result

let result2 = 0.5 |> System.Math.Cos
printfn "%f" result2

let result3 = add 6 7 |> add 4 |> add 5

