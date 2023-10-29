(*
  Product types:
    - Record
    - Typle
    - Anonymous record
*)

type Day = { DayOfTheMonth: int; Month: int }
type Person = { Name: string; Age: int }
//type Person2 = { Name: string; Age: int }

let dzhulio = { Name = "Dzhulio"; Age = 21 }
let dzhulio2 = { Name = "Dzhulio"; Age = 20 }

let dzhulioName = dzhulio.Name
let dzhulioAge = dzhulio.Age

let areEqual = dzhulio = dzhulio2
let isDzhulioBigger = dzhulio > dzhulio2

let incrementAge person =
    { person with Age = person.Age + 1 }

let olderDzhulio = incrementAge dzhulio

type Duo = { Person1: Person; Person2: Person }

let alex = { Name = "Alex"; Age = 28 }
let brothers = { Person1 = dzhulio; Person2 = alex }

type Duo' = Person * Person

let peopleTuple = (dzhulio, alex)
let randomTuple = (dzhulio, 42, "some text", 1)

let duo = {| Person1 = dzhulio; Person2 = alex |}
let trio = {| duo with Person3 = dzhulio |}

// Sum types

// Discriminated unions

type Suit =
    | Hearts
    | Clubs
    | Spades
    | Diamonds

//let yesOrNo bool =
//    if bool
//        then "Yes"
//        else "No"

let yesOrNo bool =
    match bool with
    | true -> "Yes"
    | false -> "No"

let yesOrNo' = function
    | true -> "Yes"
    | false -> "No"

// Never do this!
let yesOrNo'' bool = 
    (function
    | true -> "Yes"
    | false -> "No") bool

let isEven = function
    | x when x % 2 = 0 -> true
    | _ -> false

let isEven' x = x % 2 = 0

let isOne = function
    | 1 -> true
    | _ -> false

let isOne' number = 
    number = 1

let isOne'' = 
    (=) 1

let translateFizzBuzz = function
    | "Fizz" -> string 3
    | "Buzz" -> string 5
    | "FizzBuzz" -> string 15
    | x -> x

let fizzStringNum = translateFizzBuzz "Fizz"
let buzzStringNum = translateFizzBuzz "Buzz"
let fizzBuzzStringNum = translateFizzBuzz "FizzBuzz"
let TomatoStringNum = translateFizzBuzz "Tomato"

type NormalRectangle = { Base: double; Height: double }

// This works with Single Case Pattern matches
// Record types
// Tuples
// Single Case DU

int

type OrderId = OrderId of int

let incrementOrderId (OrderId id) =
    OrderId <| id + 1

let incrementOrderId' =
    fun (OrderId id) ->
        OrderId <| id + 1

let area {Base = b; Height = h} = 
    b * h

let area' (b, h) = b * h

type Rectangle =   
    | Normal of NormalRectangle
    | Square of side:double

module Rectangle =
    let area = function
        | Normal { Base = b; Height = h } -> b * h
        | Square s -> s ** 2.

type Shape =
    | Rectangle of Rectangle
    | Triangle of height: double * _base: double
    | Circle of radius: double
    | Dot

let circle = Circle 1.
let triangle = Triangle (2.,4.)


module Shape =
    let area shape =
        match shape with
        | Rectangle rect -> Rectangle.area rect
        | Triangle (h, b) -> h * b / 2.
        | Circle r -> r ** 2. * System.Math.PI
        | Dot -> 1.

Shape.area circle
Shape.area triangle