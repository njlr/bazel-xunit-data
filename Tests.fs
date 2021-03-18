module BazelXunitTestData

open Xunit
open System
open System.IO
open FsUnit.Xunit

[<Fact>]
let ``a is a`` () =
  "a" |> should equal "a"

[<Fact>]
let ``a file contains only a`` () =
  let path = "test-data/a.txt"
  let content = File.ReadAllText path

  content |> should equal "a"
