namespace FSharpBasics

module Arithmetic =
    module Addition = 
        let add x y = x + y

module Arithmetic' =
    module private Addition' = 
        let private add x y = x + y

module Other =
    open Arithmetic

    let program =
        Addition.add 5 3