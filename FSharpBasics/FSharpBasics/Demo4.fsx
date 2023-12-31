﻿(*
  Product types:
    - Record
    - Typle
    - Anonymous record
*)

type Day = { DayOfTheMonth: int; Month: int }
type Person = 
    { Name: string; Age: int }
    with
        static member (+) ({Name = n1; Age = a1}, {Name = n2; Age = a2}) =
            {Name = n1 + n2; Age = a1 + a2}

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
    | "Fizz" -> 3
    | "Buzz" -> 5
    | "FizzBuzz" -> 15
    | _ -> failwith "Not a correct argument"

let fizzStringNum = translateFizzBuzz "Fizz"
let buzzStringNum = translateFizzBuzz "Buzz"
let fizzBuzzStringNum = translateFizzBuzz "FizzBuzz"
//let TomatoStringNum = translateFizzBuzz "Tomato"

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

let translateFizzBuzz' = function
    | "Fizz" -> Some 3
    | "Buzz" -> Some 5
    | "FizzBuzz" -> Some 15
    | _ -> None

let hasValue = function
    | Some _ -> true
    | None -> false

let inline add x y = x + y

let test = dzhulio + alex

// Fixed size
// Mutable
[|1;2;3;4;5;6;7;8;9|]

[|
    1
    2
    3
    4
    
|]

let arr = [|1 .. 10|]
arr.[0] <- 5

// Immutable
// Linked list

[1;2;3;4;5;6]

[
    1
    2
    3
    4
    5
]

[1 .. 10]
[1 ..2.. 10]
[1. .. 0.1 .. 10.]
['a' .. 'z']

// list
type LinkedList<'a> =
    | ([])
    | (::) of head:'a * tail:'a list

let empty = []

let addToList x xs =
    x::xs

let sampleList = [3;2;4]
let newSampleList = addToList 1 sampleList