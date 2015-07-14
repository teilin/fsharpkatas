namespace Katas.FizzBuzz

open System

module FizzBuzz =
  let fizzBuzz number =
    match number with
    | i when i % 3 = 0 && i % 5 = 0 -> "FizzBuzz"
    | i when i % 3 = 0 -> "Fizz"
    | i when i % 5 = 0 -> "Buzz"
    | _ -> number.ToString()
  let fizzBuzzRange a b =
    [a..b]
    |> List.map fizzBuzz
    |> List.reduce (sprintf "%s\r\n%s")

module RunFizzBuzz =
  let run =
    printf "Test"