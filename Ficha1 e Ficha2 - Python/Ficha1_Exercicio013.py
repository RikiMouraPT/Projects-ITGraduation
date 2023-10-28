import math

NotaAvalP = 0 
NotaAvalF = 0 
PesoAvalP = 0 
PesoAvalF = 0 
NotaFinal = 0 
NotaAvalP =  float(input("Introduza a nota da avalição periodica, de 0 a 20.\n"))
PesoAvalP =  float(input("Qual o peso, em percentagem, da avaliação periodica?\n"))
NotaAvalF =  float(input("Introduza a nota da avaliação final, de 0 a 20.\n"))
PesoAvalF = 100 - PesoAvalP
NotaFinal = ( NotaAvalP * ( PesoAvalP / 100 ) ) + ( NotaAvalF * ( PesoAvalF / 100 ) )
print( "A sua nota final é: " , end="")
print(NotaFinal  , end="")


#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:42
