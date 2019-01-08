#if INTERACTIVE
#else
module Lists

open System.Threading

#endif

let emptyList = []
let oneItem = "one " :: []
let twoItem = "one " :: "two " :: []

let shortHand = ["apples "; "pears"]

let twoLists = ["one, "; "two, "] @ ["buckle "; "my "; "shoe "]

// list of objects
let objList = [box 1; box 2.0; box "three"]
// print the lists
let main() =
    printfn "%A" emptyList
    printfn "%A" oneItem
    printfn "%A" twoItem
    printfn "%A" shortHand
    printfn "%A" twoLists
    printfn "%A" objList

// call the main function
main()

// create a list of one item
let one = ["one "]
// create a list of two items
let two = "two " :: one
// create a list of three items
let three = "three " :: two

// reverse the list of three items
let rightWayRound = List.rev three

let main2() =
    printfn "%A" one
    printfn "%A" two
    printfn "%A" three
    printfn "%A" rightWayRound

// call the main function
main2()

// list to be concatenated
let listOfList = [[2; 3; 5;]; [7; 11; 13;]; [17; 19; 23; 29;]]
// definition of a concatenation function
let rec concatList l =
    match l with
    | head :: tail -> head @ (concatList tail)
    | [] -> []

// call the function
let primes = concatList listOfList
// print the results
printfn "%A" primes

// function that attempts to find various sequences
let rec findSequence l =
    match l with
    // match a list containing exactly 3 numbers
    | [x; y; z] ->
        printfn "Last 3 numbers in the list were %i %i %i" x y z
    // match a list of 1, 2, 3 in a row
    | 1 :: 2:: 3 :: tail ->
        printfn "Found sequence 1, 2, 3 within the list"
        findSequence tail
    // if neither case matches and items remain
    // recursively call the function
    | head :: tail -> findSequence tail
    // if no items remain terminate
    | [] -> ()

// some test data
let testSequence = [1; 2; 3; 4; 5; 6; 7; 8; 9; 8; 7; 6; 5; 4; 3; 2; 1]

// call the function
findSequence testSequence

//
let rec addOneAll list =
    match list with
    | head :: rest ->
        head + 1 :: addOneAll rest
    | [] -> []

printfn "(addOneAll [1; 2; 3]) = %A" (addOneAll [1; 2; 3])

let rec map func list =
    match list with
    | head :: rest ->
        func head :: map func rest
    | [] -> []

let result4 = List.map ((+) 1) [1; 2; 3]
printfn "List.map ((+) 1) [1; 2; 3] = %A" result4

// create some list comprehensions
let numericList = [ 0 .. 9 ]
let alpherSeq = seq { 'A' .. 'Z' }

// print them
printfn "%A" numericList
printfn "%A" alpherSeq

// create some list comprehensions
let multiplesOfThree = [ 0 .. 3 .. 30 ]
let revNumericSeq = [ 9 .. -1 .. 0 ]
// print them
printfn "%A" multiplesOfThree
printfn "%A" revNumericSeq

// a sequence of squares
let squares =
    seq { for x in 1 .. 10 -> x * x }
//print the sequence
printfn "%A" squares

// a sequence of even numbers
let evens n =
    seq { for x in 1 .. n do
            if x % 2 = 0 then
                yield x }

// print the sequence
printfn "%A" (evens 10)

// sequence of tuples representing points
let squarePoints n =
    seq { for x in 1 .. n do
            for y in 1 .. n do
                yield x, y }

// print the sequence
printfn "%A" (squarePoints 3)