import math

EKM = 0 
L100 = 0 
litros =  float(input("Quantos litros gastou?\n"))
kms =  float(input("Quantos kilometros percorreu?\n"))
preco =  float(input("Qual é o preço atual da gasolina, por litro?\n"))
EKM = ( preco * litros ) / kms
print( "Preço por Kilometro: " , end="")
print(EKM  , end="")
print( "€" , end="")
L100 = ( litros / kms ) * 100
print( "\nL/100 = " , end="")
print(L100  , end="")


#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:36