import math

convertido = 0 
num1 =  int(input("Quanto quer converter?\n"))
unidade =  str(input("O numero está em Esc ou Euros?\n"))
if unidade == "Esc" or unidade == "ESc" or unidade == "ESC" or unidade == "eSC" or unidade == "esC" or unidade == "esc"  :
    convertido = num1 / 200.482
    print( "\nO valor convertido de Escudos para Euros é: " , end="")
    print(convertido  , end="")
else:
    if unidade == "EUros" or unidade == "EURos" or unidade == "EUROs" or unidade == "EUROS" or unidade == "eUROS" or unidade == "euROS" or unidade == "eurOS" or unidade == "euroS" or unidade == "euros" or unidade == "Euros"  :
        convertido = num1 / 0.00498798
        print( "O valor convertido de Euros para Escudos é: " , end="")
        print(convertido  , end="")
    else:
        print( "Só pode ser em Euros ou Escudos, seu burro." , end="")



#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:45
