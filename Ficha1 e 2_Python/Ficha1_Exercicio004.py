import math

raio = 0 
perimetro = 0 
area =  float(input("\nQual é a área da circunferência?\n"))
raio = math.sqrt( area / math.pi )
perimetro = 2 * math.pi * raio
print( "O perimetro da circunferência é: " , end="")
print(perimetro  , end="")


#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:35
