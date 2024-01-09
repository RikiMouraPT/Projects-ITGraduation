irs = 20
seg_social = 11

def cabecalho(texto):
    print("="*15)
    print(f"{texto:^15}")
    print("="*15)

def ler_dados():
    global lista_dados
    numero = -1
    while True:
        numero = int(input("Qual é o seu numero? "))
        if numero == 0:
            break
        nome = str(input("Qual é o seu nome? "))
        salario = int(input("Qual é o seu salario? "))
        irs = salario * 0.20
        ss = salario * 0.11
        funcionario = [numero, nome, salario, irs, ss]
        lista_dados.append(funcionario)

def ver_dados(lista_dados):
    cabecalho("Ler Dados")
    print(f"{'Numero':<15} {'Nome':<15} {'Salario':<15} {'IRS':<15} {'Seg Social':<15}")
    print("="*75)
    for funcionario in lista_dados:
        print(f"{funcionario[0]:<15} {funcionario[1]:<15} {funcionario[2]:<15} {irs:<15.2f} {ss:<15.2f}")

def salario_maximo(lista_dados):
    salarios = []
    for funcionario in lista_dados:
        salarios.append(funcionario[2])
    return max(salarios)

def guardar_ficheiro(lista_dados):
    print("================")
    print("Guardar Ficheiro")
    print("================")
    
    ficheiro = open("dados.txt","w")
    ficheiro.write("Numero, Nome, Salario, IRS, Seg Social\n")

    for i in range(len(lista_dados)):
        for j in range(5): 
            print(j)
            ficheiro.write(f"{lista_dados[i][j]}, ")
        ficheiro.write("\n")
    ficheiro.close()
    
    print()
    print("Ficheiro guardado!")
    input("ENTER p/ continuar....") 
    
def abrir_ficheiro():
    print("================")
    print("Guardar Ficheiro")
    print("================")
    ficheiro = open("dados.txt","r")
    print()
    contador = 1
    
    for linha in ficheiro.readlines():
        if (contador > 1):
            campos = linha.split(";")
            registo = [int(campos[0]), campos[1].lstrip(), float(campos[2].rstrip("\n"))] # retira "\n" do campo
            lista_dados.append(registo)
            contador = contador + 1
        
    print(lista_dados)
    print()
    print("Ficheiro aberto!")
    print()
    input("ENTER p/ continuar....") 

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
                pass
            case '6':
                exit()
            
main()