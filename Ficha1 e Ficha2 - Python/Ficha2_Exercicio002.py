soma = 0 
produto = 0 
num1 =  int(input("Digite o primeiro numero: "))
num2 =  int(input("Digite o segundo numero: "))
if num1 % 2 == 0 and num2 % 2 == 0  :
    soma = num1 + num2
    print( "A soma dos dois numeros é: " , end="")
    print(soma  , end="")
else:
    if num1 % 2 == 1 and num2 % 2 == 1  :
        produto = num1 * num2
        print( "O produto dos dois numeros é: " , end="")
        print(produto  , end="")
    else:
        print( "Os numeros não são da mesma natureza." , end="")



#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:44
