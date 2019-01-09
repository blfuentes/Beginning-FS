#if INTERACTIVE
#else
module _09_DiscriminatedUnions

open System.Diagnostics

#endif

type Volume =
    | Liter of float
    | UsPint of float
    | ImperialPint of float

let vol1 = Liter 2.5
let vol2 = UsPint 2.5
let vol3 = ImperialPint (2.5)

// union type using field labels
type Shape =
| Square of side: float
| Rectangle of width: float * height: float
| Circle of radius: float

// create an instance of a union type without using the field label
let sq = Square 1.2
// create an instance of a union type using the field label
let sq2 = Square(side = 1.2)
// create an instance of a union type using multiple field labels
// and assigning the field out-of-order
let rect3 = Rectangle(height = 3.4, width = 1.2)

// some functions to convert between volumes
let convertVolumeToLiter x =
    match x with
    | Liter x -> x
    | UsPint x -> x * 0.473
    | ImperialPint x -> x * 0.568

let convertVolumeToUsPint x =
    match x with
    | Liter x -> x * 2.113
    | UsPint x -> x
    | ImperialPint x -> x * 1.201

let convertVolumeToImperialPint x =
    match x with
    | Liter x -> x * 1.760
    | UsPint x -> x * 0.833
    | ImperialPint x -> x

// a function print a volume
let printVolumes x =
    printfn "Volume in liters = %f, in us pints = %f, in imperial pints %f" (convertVolumeToLiter x) (convertVolumeToUsPint x) (convertVolumeToImperialPint x)

// print the results
printVolumes vol1
printVolumes vol2
printVolumes vol3