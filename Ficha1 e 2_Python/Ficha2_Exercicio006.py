acidentes = 0 
saude =  str(input("Goza de boa saúde?(Sim/Não)\n"))
acidente =  str(input("Já sofreu algum acidente?(Sim/Não)\n"))
if acidente == "Sim"  :
    acidentes =  int(input("Quantos acidentes?"))

if saude == "Sim" and acidente == "Não"  :
    print( "Tem direito ao Contrato A")
else:
    if acidentes == 1 and saude == "Sim"  :
        print( "Tem direito ao Contrato B")
    else:
        if saude == "Não"  :
            print( "Precisa de Exame Médico" , end="")
        else:
            print( "Não tem direito a nada." , end="")



#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:46
