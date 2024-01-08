irs = 20
seg_social = 11

def ler_dados():
    global lista_dados
    numero = -1
    while True:
        numero = int(input("Qual é o seu numero? "))
        if numero == 0:
            break
        nome = str(input("Qual é o seu nome? "))
        salario = int(input("Qual é o seu salario? "))
        funcionario = [numero, nome, salario]
        lista_dados.append(funcionario)

    

def ver_dados(lista_dados):
    print(f"{'Numero':<15} {'Nome':<15} {'Salario':<15} {'IRS':<15} {'Seg Social':<15}")
    print("="*75)
    for funcionario in lista_dados:
        irs = funcionario[2]*0.20
        ss = funcionario[2]*0.11
        print(f"{funcionario[0]:<15} {funcionario[1]:<15} {funcionario[2]:<15} {irs:<15.2f} {ss:<15.2f}")

def salario_maximo(lista_dados):
    salarios = []
    for funcionario in lista_dados:
        salarios.append(funcionario[2])
    return max(salarios)

lista_dados = []
#[[999, "Ricardo", 999],[1000, "Vitor", 820]] #Para testes
def main():
    print("1. Introduzir dados")
    print("2. Ver dados")
    print("3. Salário Maior")
    print("4. Guardar dados em ficheiro")
    print("5. Recuperar dados do ficheiro")
    print("6. Sair")

ler_dados()
ver_dados(lista_dados)
print()
print("Salario maximo: ", salario_maximo(lista_dados))