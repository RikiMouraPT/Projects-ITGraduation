import math

lucrodist = 0 
IA = 0 
IVA = 0.0 
precofinal = 0 
precocarro =  float(input("Quanto custa o carro? "))
lucrodist = precocarro * 0.12
print( "O lucro do distribuidor é: " , end="")
print(lucrodist  , end="")
print( "€" , end="")
IA = precocarro * 0.30
print( "\nO IA deste carro é: " , end="")
print(IA  , end="")
IVA = ( precocarro + IA ) * 0.23
print( "\nO IVA deste carro é: " , end="")
print(IVA  , end="")
precofinal = precocarro + IA + IVA
print( "\nO preço final do carro é: " , end="")
print(precofinal  , end="")


#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:39
