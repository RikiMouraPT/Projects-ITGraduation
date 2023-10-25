import math

num1 =  int(input("Digite um numero: "))
if num1 < 0  :
    num1 = abs( num1 )
    print(( "O numero absoluto é: " )  , end="")
    print(num1  , end="")
else:
    num1 = num1 - ( 2 * num1 )
    print(( "O negativo é: " )  , end="")
    print(num1  , end="")



#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:46
