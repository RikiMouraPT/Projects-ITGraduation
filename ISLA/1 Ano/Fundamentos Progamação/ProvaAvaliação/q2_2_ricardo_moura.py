def nota_final(nota_teste, nota_trabalho, peso_teste):
    peso_trabalho = 100 - peso_teste
    nota_final = (nota_teste*peso_teste/100) + (nota_trabalho*peso_trabalho/100)

    return print(f"Nota Final..........:{nota_final:.2f}")

def main():             
    while True:
        try:
            nota_teste = int(input("Nota do teste.......:"))
            if 0 <= nota_teste <= 20:
                break
            else:
                print("Digite um valor entre 0 e 20.")
        except ValueError:
            print("Digite um numero inteiro.")

    while True:
        try:
            nota_trabalho = int(input("Nota do trabalho....:"))
            if 0 <= nota_trabalho <= 20:
                break
            else:
                print("Digite um valor entre 0 e 20.")
        except ValueError:
            print("Digite um numero inteiro.")

    while True:
        try:
            peso_teste = int(input("% Peso do teste.....:"))
            if 0 <= peso_teste <= 100:
                break
            else:
                print("Digite um valor entre 0 e 100.")
        except ValueError:
            print("Digite um numero inteiro.")

    nota_final(nota_teste, nota_trabalho, peso_teste)

main()