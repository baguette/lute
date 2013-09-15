all: lute

lexer: Lexer.fsl
	mono ../fslex.exe --unicode Lexer.fsl

lute: lexer Tokens.fs Lexer.fs Main.fs
	fsharpc -r ../FSharp.PowerPack.dll -o lute.exe Tokens.fs Lexer.fs Main.fs 

run:
	MONO_PATH=.. mono lute.exe

