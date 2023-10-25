import math

dias = 0 
maco = 0 
gasto = 0 
anos =  int(input("Há quantos anos fuma?"))
cdia =  int(input("Quantos cigarros fuma por dia? "))
preco =  float(input("Quanto custa o maço de tabaco? "))
dias = anos * 365
maco = ( cdia * dias ) // 20
gasto = maco * preco
print( "O gasto total nos " , end="")
print(anos  , end="")
print( " anos foi de: " , end="")
print(gasto  , end="")


#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:36
