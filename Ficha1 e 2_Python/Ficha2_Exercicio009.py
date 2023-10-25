import math

peso = 0.0 
altura =  float(input("Quanto mede?(m)\n"))
genero =  str(input("É Homem ou Mulher?\n"))
if genero == "Homem"  :
    peso = ( 72.7 * altura ) - 58
else:
    peso = ( 62.1 * altura ) - 44.7

print(( "O peso ideal é: " )  , end="")
print(peso  , end="")


#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:46
