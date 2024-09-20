#Numerojogo, Equipa1, Equipa2, Golos1, Golos2
import os

def cabecalho(texto):
    print("="*20)
    print(f"{texto:^20}")
    print("="*20)

def introduzir_dados():
    cabecalho("Introduzir Dados")

    numero = -1
    contador = 1
    while True:
        print(f"Registo nº{contador}: ")
        #Numero Jogo
        while True:
            try:## Para certificar que é numero inteiro
                numero =  int(input("Numero (0 termina).......:"))
                break
            except ValueError:
                print("Digite um numero inteiro.")

        if numero == 0:
            break
        #Equipa1
        equipa1 = str(input("Equipa 1.................:"))
        while True:
            try:## Para certificar que é numero inteiro
                golos1 =  int(input("Golos equipa 1...........:"))
                break
            except ValueError:
                print("Digite um numero inteiro")

        #Equipa2
        equipa2 = str(input("Equipa 2.................:"))
        while True:
            try:## Para certificar que é numero inteiro
                golos2 =  int(input("Golos equipa 2...........:"))
                break
            except ValueError:
                print("Digite um numero inteiro.")
        print()

        jogo = [numero, equipa1, golos1, equipa2, golos2]
        lista_jogo_ricardo_moura.append(jogo)
        contador += 1
    os.system("cls")

def consultar_dados():
    cabecalho("Consultar Dados")

    print(f"{'Numero':<15} {'Equipa 1':<15} {'Equipa 2':<15} {'Resultado':<15}")
    print("="*75)
    for jogo in lista_jogo_ricardo_moura:
        print(f"{jogo[0]:<15} {jogo[1]:<15} {jogo[3]:<17} {jogo[2]}-{jogo[4]}")
    input("ENTER p/ terminar...")
    os.system("cls")

def quantidade_golos():
    cabecalho("Quantidade Golos")

    golos = 0
    for jogo in lista_jogo_ricardo_moura:
        golos = golos + jogo[2] + jogo[4]

    print(f"Golos marcados....: {golos}")
    input("ENTER p/ terminar...")
    os.system("cls")

def jogo_mais_golos():
    cabecalho("Jogo Mais Golos")
    i = 0
    max_golos = 0

    for jogo in lista_jogo_ricardo_moura:    
        golos = jogo[2] + jogo[4]

        if i == 0:
            max_golos = golos
            pos = i

        if golos > max_golos:
            max_golos = golos
            pos = i
    
        i = i + 1

    print(f"Numero..........: {lista_jogo_ricardo_moura[pos][0]}")
    print(f"Equipa 1........: {lista_jogo_ricardo_moura[pos][1]}")
    print(f"Golos equipa 1..: {lista_jogo_ricardo_moura[pos][2]}")
    print(f"Equipa 2........: {lista_jogo_ricardo_moura[pos][3]}")
    print(f"Golos equipa 2..: {lista_jogo_ricardo_moura[pos][4]}")
    input("\nENTER p/ terminar...")
    os.system("cls")
    
def main():
    global lista_jogo_ricardo_moura
    lista_jogo_ricardo_moura = []

    while True:
        cabecalho("MENU")

        print("1. Introduzir Dados")
        print("2. Consulta Dados")
        print("3. Quantidade de golos")
        print("4. Jogo mais golos")
        print("5. Sair")

        op = int(input("Escolha opção: "))
        os.system("cls")
        match op:
            case 1:
                introduzir_dados()
            case 2:
                consultar_dados()
            case 3:
                quantidade_golos()
            case 4:
                jogo_mais_golos()
            case 5:
                exit()

main()