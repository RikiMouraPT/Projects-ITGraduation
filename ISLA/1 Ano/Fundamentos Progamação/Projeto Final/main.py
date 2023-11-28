import time
from rich.console import Console
from rich.table import Table
from rich.layout import Layout
from rich.panel import Panel
from rich import box

#Para usar console.print()
console = Console()

filmes_testes = {
    "Matrix":             18,
    "O Poderoso Chefão":  15,
    "Parasita":           20,
    "Titanic":            12,
    "Pulp Fiction":       17,
    "Interestelar":       20,
    "O Senhor dos Anéis": 14,
    "Forrest Gump":       16,
    "A ":           19, 
    "Cidade de Deus":     13
}
#Dicionario para guardar {Filmes: Pontuação}
filmes = {}

def separador():
    console.print("----------------------------------------")
def introduzir_dados():
    separador()
    console.print("----------- ", end="")
    console.print("Introduzir Dados", style="yellow1", end="")
    console.print(" -----------")
    separador()
    for i in range(10):
        filme_input = input(f"Nome do {i+1}º filme:")
        while True: #Pede pontuação até que seja um valor entre 0 e 20.
            try:    #Necessário usar try para o caso de colocarem TEXTO no input de PONTUAÇÃO, caso metam texto, vai dar o EXCEPT
                pontuacao_input = int(input(f"Pontuação do {i+1}º filme: "))                  #e volta a tentar até ter inteiro
                if 0 <= pontuacao_input <= 20:
                    break
                else:
                    print("Pontuação deve estar entre 0 e 20 (inclusive). Tente novamente.")
            except ValueError:
                print("Por favor, insira um valor inteiro.")
        filmes[filme_input] = pontuacao_input
def gerar_dados():
    global filmes
    print("A gerar dados.")
    #time.sleep(0.6)
    print("A gerar dados..")
    #time.sleep(0.6)
    print("A gerar dados...")
    #time.sleep(0.5)
    console.print("[b]Dados gerados.[/b]\n")
    filmes = filmes_testes.copy()
def alterar_dados():
    separador()
    console.print("------------ ", end="")
    console.print("Alterar Dados", style="yellow1", end="")
    console.print(" -------------")
    separador()
    filme_alterar = input("Que filme quer alterar? ")
    if filme_alterar in filmes:
        while True: #Pede pontuação até que seja um valor entre 0 e 20.
            try:    #Necessário usar try para o caso de colocarem TEXTO no input de PONTUAÇÃO, caso metam texto, vai dar o EXCEPT
                pontuacao_input = int(input("Qual é a nova pontuação? "))                      #e volta a tentar até ter inteiro
                if 0 <= pontuacao_input <= 20:
                    break
                else:
                    print("Pontuação deve estar entre 0 e 20 (inclusive). Tente novamente.")
            except ValueError:
                print("Por favor, insira um valor inteiro.")
        filmes[filme_alterar] = pontuacao_input
        console.print(f"O filme [b]{filme_alterar}[/b] foi alterado para [b]{pontuacao_input}[/b] pontos.\n", highlight=False)
    else:
        console.print(f"O filme [b]{filme_alterar}[/b] não foi encontrado na lista.\n")
def eliminar_dados():
    separador()
    console.print("------------ ", end="")
    console.print("Eliminar Dados", style="yellow1", end="")
    console.print(" ------------")
    separador()
    filme_eliminar = input("Que filme quer eliminar? ")
    if filme_eliminar in filmes:
        del filmes[filme_eliminar]
        console.print(f"O filme [b]{filme_eliminar}[/b] foi eliminado.\n")
    else:
        console.print(f"O filme [b]{filme_eliminar}[/b] não foi encontrado na lista.\n")
def consultar_dados():
    #Criar tabela para dados.
    table = Table(title="[b]Filmes - Óscares[/b]",title_style="yellow1", box=box.ROUNDED, border_style="medium_spring_green")
    # Adicionar as colunas à tabela
    table.add_column("Filme", justify="left", no_wrap=True)
    table.add_column("Pontuação (0-20)", justify="center")

    #filmes_ordenados_lista = sorted(filmes.items(), key = lambda ordenar_pelo: ordenar_pelo[1], reverse=True)
    #filmes_ordenados_dict = dict(filmes_ordenados_lista)                ###### FUNÇÃO EM BAIXO É IGUAL A TER ESTAS DUAS JUNTAS######
    filmes_ordenados = dict(sorted(filmes.items(), key = lambda ordenar_pelo: ordenar_pelo[1], reverse=True))

    # Adicionar dados às linhas da tabela
    for filme, pontuacao in filmes_ordenados.items():
        table.add_row(filme, str(pontuacao))
    # Dar print à tabela
    console.print(table, justify="center")
def pesquisar_dados():
    separador()
    console.print("------------- ", end="")
    console.print(" Pesquisar ", style="yellow1", end="")
    console.print(" --------------")
    separador()
    pesquisar_input = input("Qual é o filme? ")
    for filme, pontuacao in filmes.items():
        if pesquisar_input == filme:
            console.print(f"O filme [b]{pesquisar_input}[/b] tem pontuação de [b]{pontuacao}[/b].\n", highlight=False)
            break
    else:
        console.print(f"O filme [b]{pesquisar_input}[/b] não está na lista.\n")
def podio_dados():
    filmes_ordenados = dict(sorted(filmes.items(), key = lambda ordenar_pelo: ordenar_pelo[1], reverse=True))   
    filmes_ordenados_iter = iter(filmes_ordenados)        #Itera pelo dicionario e pega na primeira key usando o next().
    primeiro_filme = next(filmes_ordenados_iter)          #Dá o valor associado ao primeiro filme.
    primeira_pontuacao = filmes_ordenados[primeiro_filme] 

    segundo_filme = next(filmes_ordenados_iter)           #Dá o segundo valor, porque é segunda vez a usar o next()
    segunda_pontuacao = filmes_ordenados[segundo_filme]

    terceiro_filme = next(filmes_ordenados_iter)
    terceira_pontuacao = filmes_ordenados[terceiro_filme]

    #TABELA 1º LUGAR
    Podio1 = Table(title="1ºLugar", box=box.ROUNDED, border_style="yellow1", title_style="yellow1", title_justify="center", expand=True)
    Podio1.add_column("Filme", justify="center")
    Podio1.add_column("Pontos", justify="center")
    Podio1.add_row(primeiro_filme, str(primeira_pontuacao))

    #TABELA 2º LUGAR
    Podio2 = Table(title="2ºLugar", box=box.ROUNDED, border_style="grey78", title_style="grey78", title_justify="center", expand=True)
    Podio2.add_column("Filme", justify="center")
    Podio2.add_column("Pontos", justify="center")
    Podio2.add_row(segundo_filme, str(segunda_pontuacao))

    #TABELA 3º LUGAR
    Podio3 = Table(title="3ºLugar", box=box.ROUNDED, border_style="gold3", title_style="orange3", title_justify="center", expand=True)
    Podio3.add_column("Filme", justify="center")
    Podio3.add_column("Pontos", justify="center")
    Podio3.add_row(terceiro_filme, str(terceira_pontuacao))
    
    #PRINT PODIO 
    layout = Layout()
    layout.split_row(Podio1, Podio2, Podio3) #Mete tabelas lado a lado
    console.print(Panel(layout, title="[b]### Pódio ###[/b]",border_style="blue1" ,height=9, width=120), justify="center") #Print com panel à volta
    
    #Tabela Restantes
    tabela_restantes = Table(title="[b]Restantes Ordenados[/b]", border_style="medium_spring_green",box=box.ROUNDED, title_style="medium_spring_green", title_justify="center")
    # Adicionar as colunas à tabela
    tabela_restantes.add_column("Filme", justify="left", style="white")
    tabela_restantes.add_column("Pontuação (0-20)", justify="center", style="white")
    
    filmes_ordenados_inverso = dict(sorted(filmes.items(), key = lambda ordenar_pelo: ordenar_pelo[1], reverse=False))
    #Usa a tabela ordenada ao contrario, para tirar os valores de Podio.
    for _ in range(3):
        filmes_ordenados_inverso.popitem() #Remove os três ultimas keys e valores.

    filmes_ordenados_sem_podio = dict(sorted(filmes_ordenados_inverso.items(), key = lambda ordenar_pelo: ordenar_pelo[1], reverse=True))
    
    for filme, pontuacao in filmes_ordenados_sem_podio.items():
        tabela_restantes.add_row(filme, str(pontuacao))
        
    # Dar print à tabela
    console.print(tabela_restantes, justify="center")

def guardar_dados():
    pass
def carregar_dados():
    pass
def sair():
    print("A sair.")
    time.sleep(0.6)
    print("A sair..")
    time.sleep(0.6)
    print("A sair...")
    time.sleep(0.6)
    exit()

### Menu ###
while True: #Repete sempre para mostrar sempre o menu até escolher opção sair.
    console.print(" ### [b]Menu[/b] ###", style="blue1")
    print(" 1. Introdução dados")
    print(" 2. Geração dados (preenchimento dos vetores (lista) de forma automática)")
    print(" 3. Alterar dados")
    print(" 4. Eliminar dados")
    print(" 5. Consultar")
    print(" 6. Pesquisar (ver dados de um filme)")
    print(" 7. Pódio")
    print(" 8. Guardar em ficheiro")
    print(" 9. Carregar dados do ficheiro")
    print("10. Sair")
    
    menu = input("Escolha uma opção do menu: ")
    print("")
    match menu:
        case "1":
            introduzir_dados()
        case "2":
            if len(filmes) == 0: # Se Lista estiver vazia, faz a função.
                gerar_dados()
            else:
                console.print("Lista de Filmes já não está vazia.\n", style="red1")
        case "3":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                alterar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.\n", style="red1")
        case "4":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                eliminar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.\n", style="red1")
        case "5":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                consultar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.\n", style="red1")
        case "6":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                pesquisar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.\n", style="red1")
        case "7":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                podio_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.\n", style="red1")
        case "8":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                guardar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.\n", style="red1")
        case "9":
            carregar_dados()
        case "10":
            sair() # Pode-se usar break para sair do loop e teria o mesmo efeito.
        case _:
            console.print("Tem de escolher um numero do menu.\n", style="red1")

    
