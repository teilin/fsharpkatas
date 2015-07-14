namespace Katas

open System
open Katas.FizzBuzz

module Main =
    [<EntryPoint>]
    let main args =
        let test = FizzBuzz.fizzBuzz 10
        Console.WriteLine(FizzBuzz.fizzBuzzRange 1 100);
        0