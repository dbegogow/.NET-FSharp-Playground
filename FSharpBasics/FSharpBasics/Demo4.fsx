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

type Rectangle = { Base: double; Height: double }

type Shape =
    | Rectangle of Rectangle
    | Triangle of height: double * _base: double
    | Circle of radius: double
    | Dot