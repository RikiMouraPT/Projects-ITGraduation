ano =  int(input("Diga um ano: "))
if ano % 4 == 0 and ano % 100 != 0  :
    print( "Congrats! O ano " , end="")
    print(ano  , end="")
    print( " é bissexto." , end="")
else:
    if ano % 400 == 0 and ano % 100 == 0  :
        print( "O ano " , end="")
        print(ano  , end="")
        print( " é bissexto." , end="")
    else:
        print( "O ano " , end="")
        print(ano  , end="")
        print( " não é bissexto." , end="")



#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:46
