module Main

open System
open Lexer
open Microsoft.FSharp.Text.Lexing   (* powerpack *)

let parse lexbuf =
  let mutable keepParsing = true
  let mutable tokenList   = []

  while keepParsing = true do
    let parsedToken = parsetokens lexbuf
    tokenList <- tokenList @ [parsedToken]

    if parsedToken = Tokens.EOF then
      keepParsing <- false

  tokenList

let tryParse text =
  let lexbuf = Lexing.LexBuffer<_>.FromString text
  try
    let tokens = parse lexbuf
    printfn "Success. %d tokens:" (List.length tokens)
    printfn "%A" tokens
  with e ->
    let pos = lexbuf.EndPos
    printfn "error line %d: %s" pos.Line e.Message

let mutable inputString = Console.ReadLine()

while inputString <> "quit" do
  tryParse inputString
  Console.Write("\n: ")
  inputString <- Console.ReadLine()

