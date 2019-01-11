﻿#if INTERACTIVE
#else
module _12_ActivePatterns
open System.Diagnostics
#endif

open System

// definition of the active pattern
let (|Bool|Int|Float|String|) input =
    // attempt to parse a bool
    let success, res = Boolean.TryParse input
    if success then Bool(res)
    else
        // attempt to parse an int
        let success, res = Int32.TryParse input
        if success then Int(res)
        else
            // attemp to parse a float (Double)
            let success, res = Double.TryParse input
            if success then Float(res)
            else String(input)

// function to print the results by pattern
// matcing over the active pattern
let printInputWithType input =
    match input with
    | Bool b -> printfn "Boolean: %b" b
    | Int i -> printfn "Integer: %i" i
    | Float f -> printfn "Floating point: %f" f
    | String s -> printfn "String: %s" s

// print the results
printInputWithType "true"
printInputWithType "12"
printInputWithType "-12,1"

open System.Text.RegularExpressions

// the definition of the active pattern
let (|Regex|_|) regexPattern input =
    // create and attempt to match a regular expression
    let regex = new Regex(regexPattern)
    let regexMatch = regex.Match(input)
    // return either Some or None
    if regexMatch.Success then
        Some regexMatch.Value
    else
        None

// function to print the results by pattern
// matching over different instances of the
// active pattern
let printInputWithType2 input =
    match input with
    | Regex "$true|false^" s -> printfn "Boolean: %s" s
    | Regex @"$-?\d+^" s -> printfn "Integer: %s" s
    | Regex "$-?\d+\,\d*^" s -> printfn "Floating point: %s" s
    | _ -> printfn "String: %s" input

printInputWithType "true"
printInputWithType "12"
printInputWithType "-12,1"