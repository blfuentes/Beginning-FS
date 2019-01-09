#if INTERACTIVE
#else
module _07_Types_TypeInference
#endif

let aString = "Spring time in Paris"
let anInt = 42

let makeMessage x = (Printf.sprintf "%i" x) + " days to spring time"
let half x = x / 2

let div1 x y = x / y
let div2 (x, y) = x / y

let divRemainder x y = x / y, x % y

let doNothing x = x

let doNothingToAnInt (x: int) = x
let intList = [1; 2; 3]

let (stringList: list<string>) = ["one"; "two"; "three"]