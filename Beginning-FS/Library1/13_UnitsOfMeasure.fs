#if INTERACTIVE
#else
module _13_UnitsOfMeasure
open System.Diagnostics
#endif

[<Measure>] type m

let meters = 1.0<m>

[<Measure>]type liter
[<Measure>]type pint

let vol1 = 2.5<liter>
let vol2 = 2.5<pint>

let newVol = vol1 + vol2 // ERROR!

let ratio = 1.0<liter> / 1.76056338<pint> // * and / are allowed

// define some units of measure
[<Measure>]type liter2
[<Measure>]type pint2

// define some volumes
let vol12 = 2.5<liter2>
let vol22 = 2.5<pint2>

// define the ratio of pints to liters
let ratio2 = 1.0<liter2> / 1.76056338<pint2>
// a function to convert pints to liters
let convertPintToLiter pints =
    pints * ratio2

// perform the conversion and add the values
let newVol = vol12 + (convertPintToLiter vol22)

// stripping off unit of measure (<= F# 3.1)
printfn "The volume is %f" (float vol12)

//using a format placeholder with a unit-of-measure value (>= F# 4.0)
printfn "The volume is %f" vol12