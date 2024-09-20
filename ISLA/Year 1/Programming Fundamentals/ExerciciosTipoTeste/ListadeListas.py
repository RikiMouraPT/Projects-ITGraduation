import os

def cabecalho(texto):
    print("="*15)
    print(f"{texto:^15}")
    print("="*15)

def ler_dados():
    global lista_dados
    numero = -1
    contador = 1
    while True:
        print(f"Registo nº{contador}: ")
        numero = int(input("Qual é o seu numero? (0 para terminar)"))
        if numero == 0:
            break
        nome = str(input("Qual é o seu nome? "))
        salario = int(input("Qual é o seu salario? "))
        print()

        irs = salario * 0.20
        ss = salario * 0.11
        funcionario = [numero, nome, salario, irs, ss]
        lista_dados.append(funcionario)
        contador += 1

def ver_dados(lista_dados):
    cabecalho("Ler Dados")
    print(f"{'Numero':<15} {'Nome':<15} {'Salario':<15} {'IRS':<15} {'Seg Social':<15}")
    print("="*75)
    for funcionario in lista_dados:
        print(f"{funcionario[0]:<15} {funcionario[1]:<15} {funcionario[2]:<15} {funcionario[3]:<15.2f} {funcionario[4]:<15.2f}")

def salario_maximo(lista_dados):
    salarios = []
    for funcionario in lista_dados:
        salarios.append(funcionario[2])
    
    for salario in salarios:
        max_sal = 0
        if salario > max_sal:
            max_sal = salario
    return print("Maximo Salario é: ", max_sal)

def guardar_ficheiro(lista_dados):
    print("================")
    print("Guardar Ficheiro")
    print("================")

    nome_ficheiro = input("Digite o nome do ficheiro que quer abrir.")
    if os.path.exists(f"{nome_ficheiro}.txt"):
        print("Esse ficheiro já existe.")
    else:
        with open(f"{nome_ficheiro}.txt","w") as ficheiro:

            ficheiro.write("Numero, Nome, Salario, IRS, Seg Social\n")

            for i in range(len(lista_dados)):
                for j in range(5): 
                    ficheiro.write(f"{lista_dados[i][j]}, ")
                ficheiro.write("\n")
            ficheiro.close()
    print("Ficheiro guardado!")
    input("ENTER p/ continuar....") 

def abrir_ficheiro():
    global lista_dados

    cabecalho("Abrir Ficheiro")

    contador = 1
    nome_ficheiro = input("Digite o nome do ficheiro que quer abrir.")

    if os.path.exists(f"{nome_ficheiro}.txt"):
        with open(f"{nome_ficheiro}.txt","r") as ficheiro:
            for linha in ficheiro.readlines():
                if (contador > 1):
                    campos = linha.split(",")
                    registo = [int(campos[0]), campos[1], float(campos[2]), float(campos[3]), float(campos[4].rstrip("\n"))]
                    lista_dados.append(registo)
                contador = contador + 1
                #Numero, Nome, Salario, IRS, Seg Social
        print("Ficheiro aberto!")
        input("ENTER p/ continuar....") 
    else:
        print("Esse ficheiro não existe.")



lista_dados = []
#[[999, "Ricardo", 999],[1000, "Vitor", 820]] #Para testes
def main():
    while True:
        print("="*20)
        print(f"{'MENU':^20}")
        print("="*20)
        print("1. Introduzir dados")
        print("2. Ver dados")
        print("3. Salário Maior")
        print("4. Guardar dados em ficheiro")
        print("5. Recuperar dados do ficheiro")
        print("6. Sair")
        
        op = input("Escolha uma opção do menu.")
        os.system('cls')
        match op:
            case '1':
                ler_dados()
            case '2':
                ver_dados(lista_dados)
            case '3':
                salario_maximo(lista_dados)
            case '4':
                guardar_ficheiro(lista_dados)
            case '5':
                abrir_ficheiro()
            case '6':
                exit()
            
main()