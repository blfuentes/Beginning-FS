#if INTERACTIVE
#else
module _15_LazyEvaluation
open System.Diagnostics
#endif

let lazyValue = lazy (2 + 2)
let actualValue = lazyValue.Force()

printfn "%i" actualValue

let lazySideEffect =
    lazy
    ( 
        let temp = 2 + 2
        printfn "%i" temp
        temp 
    )

printfn "Force value the first time: "
let actualValue1 = lazySideEffect.Force()
printfn "Force value the second time: "
let actualValue2 = lazySideEffect.Force()

// the lazy list definition
let lazyList =
    Seq.unfold
        (fun x ->
            if x < 13 then
                // if smaller than the limit return
                // the current and next value
                Some(x, x + 1)
            else
                // if greater than the limit
                // terminate the sequence
                None)
        10

// print the results
printfn "%A" lazyList

// create an infinite list of Fibonacci numbers
let fibs =
    Seq.unfold
        (fun (n0, n1) ->
            Some(n0, (n1, n0 + n1)))
        (1I, 1I)

// take the first twenty items from the list
let first20 = Seq.take 20 fibs
//print the finite list
printfn "%A" first20
