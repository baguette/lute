module Tokens

type Tokens =
(* Values *)
  | NUMBER     of float
  | BOOLEAN    of bool
  | STRING     of string
  | IDENTIFIER of string
(* Keywords *)
  | AND
  | BREAK
  | DO
  | ELSE
  | ELSEIF
  | END
  | FOR
  | FUNCTION
  | IF
  | IN
  | LOCAL
  | NIL
  | NOT
  | OR
  | REPEAT
  | RETURN
  | THEN
  | UNTIL
  | WHILE
(* Operators / delimiters *)
  | PLUS
  | MINUS
  | TIMES
  | DIVIDE
  | MOD
  | HAT
  | HASH
  | EQ
  | NEQ
  | LTE
  | GTE
  | LT
  | GT
  | ASSIGN
  | LPAREN
  | RPAREN
  | LCURLY
  | RCURLY
  | LSQUARE
  | RSQUARE
  | SEMICOLON
  | COLON
  | COMMA
  | DOT
  | CONCAT
  | ELLIPSIS
  | EOF

