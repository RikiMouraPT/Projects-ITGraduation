from Taekwondo.Python.participantes import participantes
import random

def cabecalho(texto):
    print("="*25)
    print(f"{texto:^25}")
    print("="*25)

def adicionar_participantes():
    num = int(input("Quantos participantes quer adicionar? "))

    for _ in range(num):
        nome = input("Qual é o nome do participante? \n Nome: ")
        if nome not in participantes:
            participantes.append(nome)
        else:
            print(f"Já existe o participante {nome}.")

def remover_participante():
    nome = input("Que participante quer remover? \nNome: ")

    if nome in participantes:
        participantes.remove(nome)
        print(f"{nome} foi removido da lista.")
    else:
        print(f"{nome} não existe na lista.")

def baralhar_lista():
    random.shuffle(participantes)

def listar_participantes():
    cabecalho("Lista de Participantes")
    i = 0
    for participante in participantes:
        if i % 2 == 0:
            print(f"{'_'*17}\n|{participante:^16}|----\n{'▔'*17}    |")
            i += 1
        else:
            print(f"{' '*21}|------", end="")
            print(f"\n{'_'*17}    |\n|{participante:^16}|----\n{'▔'*17}")
            i += 1
            
listar_participantes()