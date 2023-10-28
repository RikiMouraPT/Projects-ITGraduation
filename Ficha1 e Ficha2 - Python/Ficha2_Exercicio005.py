idadeRapaz =  int(input("Que idade tem o rapaz?\n"))
idadeRapariga =  int(input("Que idade tem a rapariga?\n"))
dist =  int(input("A que distância vivem um do outro, em kms?\n"))
irmaos =  str(input("São irmãos?\n"))
if idadeRapaz > idadeRapariga and idadeRapaz <= idadeRapariga + 20 and irmaos != "Sim" and dist < 10  :
    print( "Boa! São compativeis!!!" , end="")
else:
    print( "Fuginde, não são compativeis!!!!" , end="")



#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:45
