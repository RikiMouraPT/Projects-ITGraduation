import math

imc = 0 
peso =  float(input("Quanto pesa?\n"))
altura =  float(input("Quando mede? (metros)\n"))
imc = peso / ( altura ) ** 2
if imc < 20  :
    print( "Baixo Peso" , end="")
else:
    if imc >= 20 and imc < 25  :
        print( "Normal" , end="")
    else:
        if imc >= 25 and imc < 30  :
            print( "Excesso de peso" , end="")
        else:
            if imc >= 30 and imc < 35  :
                print( "Obesidade" , end="")
            else:
                print( "Obsidade Morbida" , end="")



#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:47
