#if INTERACTIVE
#else
module Chapter3
#endif

// function to calculate a midpoint
let halfWay a b =
    let dif = b - a
    let mid = dif / 2
    mid + a

// call the function and print the results
printfn "(halfWay 5 11) = %i" (halfWay 5 11)
printfn "(halfWay 11 5) = %i" (halfWay 11 5)

let printMessage() =
    let message = "Help me"
    printfn "%s" message

let SafeUpperCase (s : string) =
    let s = if s = null then "" else s
    s.ToUpperInvariant()

let printMessages() =
    // define message and print it
    let message = "Important"
    printfn "%s" message
    // define an inner function that redefines value of message
    let innerFun() =
        let message = "Very Important"
        printfn "%s" message
    // call the inner function
    innerFun()
    // finally print the first message again
    printfn "%s" message

printMessages()

// function that returns a function to
let calculatePrefixFunction prefix =
    // calculate prefix
    let prefix' = Printf.sprintf "[%s]: " prefix
    // define function to perform prefixing
    let prefixFunction appendee =
        Printf.sprintf "%s%s" prefix' appendee
    // return function
    prefixFunction

// create the prefix function
let prefixer = calculatePrefixFunction "DEBUG"

// use the prefix function
printfn "%s" (prefixer "My message")