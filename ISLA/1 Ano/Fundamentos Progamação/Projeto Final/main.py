#Delays
import time
import sys
#Para formatar melhor o terminal
from rich.console import Console
console = Console()
from rich.table import Table
from rich.layout import Layout
from rich.panel import Panel
from rich import box
#Para export e import
import json
import os
#Para 18. Info Filme
import imdb
ia = imdb.Cinemagoer()
#Importa filmes de outro ficheiro
import filmes_db
#Para escolher um dicionario à sorte
import random
#Para configurar o programa mais facilmente
import config

#### GLOBAIS ####
#Para usar variavel na Função ls_dir e no Menu
ultimo_index = -1
#Usar para Export/Import/LSDir/ApagarExport
python_parent_dir_path = os.path.dirname(__file__)
dir_name = "Ficheiros_Exportados"
full_dir_path = os.path.join(python_parent_dir_path, dir_name)

#Usado para testes
""" FILMES PARA TESTES
filmes_testes = {
    "Matrix":             18,
    "O Poderoso Chefão":  15,
    "Parasita":           20,
    "Titanic":            12,
    "Pulp Fiction":       17,
    "Interestelar":       20,
    "O Senhor dos Anéis": 14,
    "Forrest Gump":       16,
    "A":                  19,
    "Cidade de Deus":     13
}
"""
#Dicionario para guardar {Filmes: Pontuação}
filmes = {}

#Funções MENU
def separador():
    console.print("----------------------------------------", style= config.cor_separador)
def loading_animation(texto):
    console.print(texto, style= config.cor_primaria)
    animation = ["[■□□□□□□□□□] 10%","[■■□□□□□□□□] 20%", "[■■■□□□□□□□] 30%", "[■■■■□□□□□□] 40%", "[■■■■■□□□□□] 50%", "[■■■■■■□□□□] 60%", "[■■■■■■■□□□] 70%", "[■■■■■■■■□□] 80%", "[■■■■■■■■■□] 90%", "[■■■■■■■■■■] 100%"]
    #region OUTRAS ANIMAÇÕES
    animation2 =[" ⢿", " ⣻", " ⣽", " ⣾", " ⣷", " ⣯", " ⣟", " ⡿"]
    animation3 =[" ·", " •", " ●", " •", " ·"]
    animation4 =[" ◓", " ◑", " ◒", " ◐"]
    animation5 =[" •", " ○", " •", " ·", " ●", " ·"]
    animation6 =[" <• ", " <•>", "  •>", "  • "]
    animation7 =[" ·", " •", " ••", " •••", " ••••", " •••", " ••", " •"]
    animation8 =[" _", " ▁", " ▂", " ▃", " ▄", " ▅", " ▆", " ▇", " █"]
    animation9 =["⠋", "⠙", "⠹", "⠸", "⠼", "⠴", "⠦", "⠧", "⠇", "⠏"]
    animation10=[" ←", " ↖", " ↑", " ↗", " →", " ↘", " ↓", " ↙"]
    animation11=[" |", " /", " -", " \\"]
    #endregion
    for _ in range(1):
        for frame in animation:
            time.sleep(0.3)
            console.print(frame, end="\r", style= config.cor_loading_animation, highlight=False)
def introduzir_dados():
    #region HEADER
    separador()
    console.print("----------- ", end="", style= config.cor_separador)
    console.print("Introduzir Dados", style=config.cor_primaria, end="")
    console.print(" -----------", style= config.cor_separador)
    separador()
    #endregion
    for i in range(10):
        filme_input = console.input(f"[{config.cor_secundaria}]Nome do {i+1}º filme:[/{config.cor_secundaria}]")
        while True: #Pede pontuação até que seja um valor entre 0 e 20.
            try:    #Necessário usar try para o caso de colocarem TEXTO no input de PONTUAÇÃO, caso metam texto, vai dar o EXCEPT
                pontuacao_input = int(console.input(f"[{config.cor_secundaria}]Pontuação do {i+1}º filme: [/{config.cor_secundaria}]"))                 #e volta a tentar até ter inteiro
                if 0 <= pontuacao_input <= 20:
                    break
                else:
                    console.print("Pontuação deve estar entre 0 e 20 (inclusive).", style= config.cor_erro, highlight=False)
            except ValueError:
                console.print("Por favor, insira um valor inteiro.", style= config.cor_erro)
        filmes[filme_input] = pontuacao_input
def gerar_dados():
    global filmes
    separador()
    loading_animation("A gerar dados")
    num = random.randint(0,6)
    filmes_lista = [filmes_db.filmes_gerar_1, filmes_db.filmes_gerar_2, filmes_db.filmes_gerar_3, filmes_db.filmes_gerar_4, filmes_db.filmes_gerar_5, filmes_db.filmes_gerar_6, filmes_db.filmes_gerar_7]
    filmes = filmes_lista[num]
    console.print("[b]\nDados gerados[/b]", style= config.cor_primaria)
    separador()
    #filmes = filmes_testes.copy()
def alterar_dados():
    #region HEADER
    separador()
    console.print("------------ ", end="", style= config.cor_separador)
    console.print("Alterar Dados", style=config.cor_primaria, end="")
    console.print(" -------------", style= config.cor_separador)
    separador()
    #endregion
    filme_alterar = console.input(f"[{config.cor_secundaria}]Que filme quer alterar? [/{config.cor_secundaria}]")
    if filme_alterar in filmes:
        while True: #Pede pontuação até que seja um valor entre 0 e 20.
            try:    #Necessário usar try para o caso de colocarem TEXTO no input de PONTUAÇÃO, caso metam texto, vai dar o EXCEPT
                pontuacao_input = int(console.input(f"[{config.cor_secundaria}]Qual é a nova pontuação? [/{config.cor_secundaria}]"))         #e volta a tentar até ter inteiro
                if 0 <= pontuacao_input <= 20:
                    break
                else:
                    console.print("Pontuação deve estar entre 0 e 20 (inclusive).", style= config.cor_erro)
            except ValueError:
                console.print("Por favor, insira um valor inteiro.", style= config.cor_erro)
        filmes[filme_alterar] = pontuacao_input
        console.print(f"O filme [{config.cor_primaria}][b]{filme_alterar}[/b][/{config.cor_primaria}] foi alterado para [{config.cor_primaria}][b]{pontuacao_input}[/b][/{config.cor_primaria}] pontos.", style= config.cor_secundaria, highlight=False)
        separador()
    else:
        console.print(f"O filme [{config.cor_secundaria}][b]{filme_alterar}[/b][/{config.cor_secundaria}] não foi encontrado na lista.")
        separador()
def eliminar_dados():
    #region HEADER
    separador()
    console.print("------------ ", end="", style= config.cor_separador)
    console.print("Eliminar Dados", style= config.cor_primaria, end="")
    console.print(" ------------", style= config.cor_separador)
    separador()
    #endregion HEADER
    filme_eliminar = console.input(f"[{config.cor_secundaria}]Que filme quer eliminar? [/{config.cor_secundaria}]")
    if filme_eliminar in filmes:
        del filmes[filme_eliminar]
        console.print(f"O filme [{config.cor_primaria}][b]{filme_eliminar}[/b][/{config.cor_primaria}] foi eliminado.", style= config.cor_secundaria)
        separador()
    else:
        console.print(f"O filme [{config.cor_primaria}][b]{filme_eliminar}[/b][/{config.cor_primaria}] não foi encontrado na lista.", style= config.cor_secundaria)
        separador()
def consultar_dados():
    #Criar tabela para dados.
    table = Table(title="[b]Filmes - Óscares[/b]",title_style= config.cor_primaria, box=box.ROUNDED, border_style= config.cor_borda_tabela_consultar)
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
    #region HEADER
    separador()
    console.print("------------- ", end="", style= config.cor_separador)
    console.print(" Pesquisar ", style= config.cor_primaria, end="")
    console.print(" --------------", style= config.cor_separador)
    separador()
    #endregion 
    pesquisar_input = console.input(f"[{config.cor_secundaria}]Qual é o filme? [/{config.cor_secundaria}]")
    
    for filme, pontuacao in filmes.items():
        if pesquisar_input == filme:
            console.print(f"O filme [{config.cor_primaria}][b]{pesquisar_input}[/b][/{config.cor_primaria}] tem pontuação de [{config.cor_primaria}][b]{pontuacao}[/b][/{config.cor_primaria}].", style=config.cor_secundaria, highlight=False)
            separador()
            break
    else:
        console.print(f"O filme [{config.cor_primaria}][b]{pesquisar_input}[/b][/{config.cor_primaria}] não está na lista.", style= config.cor_secundaria)
        separador()
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
    Podio1 = Table(title="1ºLugar", box=box.ROUNDED, border_style=config.cor_1lugar, title_style=config.cor_1lugar, title_justify="center", expand=True)
    Podio1.add_column("Filme", justify="center")
    Podio1.add_column("Pontos", justify="center")
    Podio1.add_row(primeiro_filme, str(primeira_pontuacao))

    #TABELA 2º LUGAR
    Podio2 = Table(title="2ºLugar", box=box.ROUNDED, border_style=config.cor_2lugar, title_style=config.cor_2lugar, title_justify="center", expand=True)
    Podio2.add_column("Filme", justify="center")
    Podio2.add_column("Pontos", justify="center")
    Podio2.add_row(segundo_filme, str(segunda_pontuacao))

    #TABELA 3º LUGAR
    Podio3 = Table(title="3ºLugar", box=box.ROUNDED, border_style=config.cor_3lugar, title_style=config.cor_3lugar, title_justify="center", expand=True)
    Podio3.add_column("Filme", justify="center")
    Podio3.add_column("Pontos", justify="center")
    Podio3.add_row(terceiro_filme, str(terceira_pontuacao))
    
    #PRINT PODIO 
    layout = Layout()
    layout.split_row(Podio1, Podio2, Podio3) #Mete tabelas lado a lado
    console.print(Panel(layout, title="[b]### Pódio ###[/b]",border_style=config.cor_panel_podio ,height=9, width=120), justify="center") #Print com panel à volta
    #Tabela Restantes
    tabela_restantes = Table(title="[b]Restantes Ordenados[/b]", border_style=config.cor_borda_tabela_restantes, box=box.ROUNDED, title_style=config.cor_primaria, title_justify="center")
    # Adicionar as colunas à tabela
    tabela_restantes.add_column("Filme", justify="left")
    tabela_restantes.add_column("Pontuação (0-20)", justify="center")
    
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
    global filmes
    #region HEADER
    separador()
    console.print("-------------- ", end="", style= config.cor_separador)
    console.print("Exportar", style=config.cor_primaria, end="")
    console.print(" ----------------", style=config.cor_separador)
    separador()
    #endregion
    ficheiro = console.input(f"[{config.cor_secundaria}]Nome do ficheiro? [/{config.cor_secundaria}]")
    #Criar pasta no diretorio do ficheiro .py
    global python_parent_dir_path
    global dir_name
    global full_dir_path
    
    #Logica para criar ou não a pasta. Dependendo se já existe ou não.
    if os.path.exists(full_dir_path):
        console.print("\nPasta ../Ficheiros_Exportados/ já existe!", style=config.cor_secundaria, highlight=False)
        time.sleep(1)
    else:
        os.mkdir(full_dir_path)
        console.print("\nPasta ../Ficheiros Exportados/ criada com sucesso em:", style=config.cor_primaria, highlight=False)
        console.print(python_parent_dir_path, style=config.cor_path, highlight=False)
        time.sleep(0.5)

    #Save File
    file_path = os.path.join(full_dir_path, ficheiro) #Path para o ficheiro .json
    if os.path.exists(f'{file_path}.json'):
        console.print("\nNão pode guardar um ficheiro com um nome já existente.", style=config.cor_erro)
        separador()
    else:
        with open(f'{file_path}.json', 'w') as fl:
            loading_animation("A guardar")
            json.dump(filmes, fl)
            console.print("\nLista de Filmes foi guardada com éxito!", style=config.cor_secundaria)
            separador()
def carregar_dados():
    global filmes
    global full_dir_path
    #region HEADER
    separador()
    console.print("-------------- ", end="", style=config.cor_separador)
    console.print("Importar", style=config.cor_primaria, end="")
    console.print(" ----------------", style=config.cor_separador)
    separador()
    #endregion
    ficheiro = console.input(f"[{config.cor_secundaria}]Nome do ficheiro que quer abrir? [/{config.cor_secundaria}]")
    file_path = os.path.join(full_dir_path, ficheiro)
    if os.path.exists(f'{file_path}.json'):
        with open(f'{file_path}.json', 'r') as fl:
            filmes = json.load(fl)
            loading_animation("A carregar")
            console.print("\nFicheiro carregado com sucesso.", style=config.cor_secundaria)
            separador()
    else:
        console.print("Esse ficheiro não existe.", style=config.cor_secundaria)
        separador()
def sair():
    console.print("A sair.", style=config.cor_primaria)
    time.sleep(0.6)
    console.print("A sair..", style=config.cor_primaria)
    time.sleep(0.6)
    console.print("A sair...", style=config.cor_primaria, highlight=False) #Highlight false para ficar com a cor direita, senão ... ficava amarelo
    time.sleep(0.6)
    exit()
#Extras
def eliminar_lista():
    #region HEADER
    separador()
    console.print("------------ ", end="", style= config.cor_separador)
    console.print("Eliminar Lista", style= config.cor_primaria, end="")
    console.print(" ------------", style= config.cor_separador)
    separador()
    #endregion HEADER
    while True:
        opcao = console.input(f"[{config.cor_primaria}]Tem a certeza que quer apagar a lista de filmes toda?[/{config.cor_primaria}] (y/n) ")
        if opcao == "y":
            filmes.clear()
            loading_animation("A eliminar lista")
            console.print(f"\n[{config.cor_primaria}][b]Lista Apagada.[/b][/{config.cor_primaria}]")
            time.sleep(0.5)
            break
        elif opcao == "n":
            console.print(f"[{config.cor_primaria}][b]Lista Intacta.[/b][/{config.cor_primaria}]")
            time.sleep(0.5)
            break
        else:
            console.print(f"[{config.cor_erro}]Opção Invalida.[/{config.cor_erro}]")
def ls_dir():
    #region HEADER
    separador()
    console.print("-------------- ", end="", style=config.cor_separador)
    console.print("Diretório", style=config.cor_primaria, end="")
    console.print(" ---------------", style=config.cor_separador)
    separador()
    #endregion
    global full_dir_path
    console.print(full_dir_path, style=config.cor_path, highlight=False)
    if not os.path.exists(full_dir_path): #Se a pasta NÃO existir, dá erro
        console.print("Deves primeiro exportar um ficheiro para criar a pasta de exportados.", style=config.cor_erro)
    else:
        files = os.listdir(full_dir_path)
        console.print("Ficheiro_Exportados/", style=config.cor_primaria)
        global ultimo_index
        ultimo_index = int(len(files) - 1)
        if ultimo_index < 0:
            print("└──Pasta Vazia")
        else:
            for file in files:
                if file == files[ultimo_index]:
                    print(f"└──{file}")
                else:
                    print(f"├──{file}")
        separador()
def apagar_exportado():
    #region HEADER
    separador()
    console.print("---------- ", end="", style=config.cor_separador)
    console.print("Eliminar Ficheiro", style=config.cor_primaria, end="")
    console.print(" -----------", style=config.cor_separador)
    separador()
    #endregion
    global full_dir_path
    ficheiro = console.input(f"[{config.cor_secundaria}]Nome do ficheiro? [/{config.cor_secundaria}]")
    file_path = os.path.join(full_dir_path, ficheiro)
    if os.path.exists(f'{file_path}.json'):
            loading_animation("A remover")
            os.remove(f'{file_path}.json')
            console.print(f"\n[{config.cor_primaria}]{ficheiro}.json[/{config.cor_primaria}] foi removido com éxito!", style=config.cor_secundaria)
            separador()
    else:
            console.print("Esse ficheiro não existe.", style=config.cor_erro)
            separador()
def info_filme(): 
    #region HEADER
    separador()
    console.print("--------------- ", end="", style=config.cor_separador)
    console.print(" Filme ", style=config.cor_primaria, end="")
    console.print(" ----------------", style=config.cor_separador)
    separador()
    #endregion
    filme_input = console.input(f"[{config.cor_secundaria}]Que filme quer pesquisar? [/{config.cor_secundaria}]")
    filmes = ia.search_movie(filme_input)
    top3_filmes = filmes[:config.list_movies]
    
    if filmes: #se tiver algo dentro de filmes == TRUE
        console.print(f"Foram encontrados os seguintes filmes:\n", style=config.cor_secundaria)
        i = 1
        for filme in top3_filmes:
            console.print(f"[{config.cor_secundaria}][b]{i}-[/b][/{config.cor_secundaria}] {filme['title']} - {filme['year']}", highlight=False)
            i += 1
        escolha = int(console.input(f"\n[{config.cor_secundaria}]De qual filme quer ver o info?[{config.cor_secundaria}] "))
        filme = top3_filmes[escolha-1]

        ia.update(filme) #Dá mais info do filme
        print("")

        #region HEADER
        separador()
        console.print("--------------- ", end="", style= config.cor_separador)
        console.print(" DADOS ", style= config.cor_primaria, end="")
        console.print(" ----------------", style= config.cor_separador)
        separador()
        #endregion HEADER
        console.print(f'[{config.cor_secundaria}]Título: [/{config.cor_secundaria}]{filme["title"]}', highlight=False)          #Titulo
        console.print(f'[{config.cor_secundaria}]Ano: [/{config.cor_secundaria}]{filme["year"]}', highlight=False)               #Ano
        console.print(f'[{config.cor_secundaria}]Avaliação: [/{config.cor_secundaria}]{filme["rating"]}/10', highlight=False)    #Rating

        duracoes = filme.get("runtime", "N/A")                                                                                   #Duração   |
        duracao = duracoes[0]                                                                                                    #Duração   |-> Como dá lista de durações, é preciso fazer assim.
        console.print(f'[{config.cor_secundaria}]Duração: [/{config.cor_secundaria}]{duracao} minutos', highlight=False)         #Duração   |

        diretores = filme.get("director", "N/A")                                                                                 #Diretor   |
        diretor = diretores[0]                                                                                                   #Diretor   |-> Como dá lista de diretores, é preciso fazer assim.
        console.print(f'[{config.cor_secundaria}]Diretor do Filme: [/{config.cor_secundaria}]{diretor}', highlight=False)        #Diretor   |

        plot = filme.get("plot outline", "N/A")                                                                                  #plot
        console.print(f'[{config.cor_secundaria}]Plot: [/{config.cor_secundaria}]{plot}', highlight=False)                       #plot
        #console.print(f'[yellow1]Budget: [/yellow1]{filme["budget"]}', highlight=False)                                         #Budget estimado
        separador()
    else:
        console.print("Filme não encontrado.", style=config.cor_erro)
        separador()

### Menu ###
while True: #Repete sempre para mostrar sempre o menu até escolher opção sair.
    console.print("\n ### [b]Menu[/b] ###", style=config.cor_primaria)
    print(" 1. Introdução dados")
    print(" 2. Geração dados (preenchimento dos vetores (lista) de forma automática)")
    print(" 3. Alterar dados")
    print(" 4. Eliminar dados")
    print(" 5. Consultar")
    print(" 6. Pesquisar (ver dados de um filme)")
    print(" 7. Pódio")
    print(" 8. Export")
    print(" 9. Import")
    print("10. Sair")
    console.print("\n ### [b]Extras[/b] ###", style=config.cor_primaria)
    print("15. Eliminar Lista.")
    print("16. Ver ficheiros exportados")
    print("17. Apagar Ficheiros Exportados")
    print("18. Info Filme\n")
    menu = input("Escolha uma opção do menu: ")
    print("")
    time.sleep(0.2)
    os.system('cls')
    match menu:
        case "1":
            if len(filmes) == 0: # Se Lista estiver vazia, faz a função.
                introduzir_dados()
            else:
                console.print("Lista de Filmes já não está vazia.", style="red1")
        case "2":
            if len(filmes) == 0: # Se Lista estiver vazia, faz a função.
                gerar_dados()
            else:
                console.print("Lista de Filmes já não está vazia.", style="red1")
        case "3":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                alterar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.", style="red1")
        case "4":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                eliminar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.", style="red1")
        case "5":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                consultar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.", style="red1")
        case "6":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                pesquisar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.", style="red1")
        case "7":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                podio_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.", style="red1")
        case "8":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                guardar_dados()
            else:
                console.print("Lista de Filmes ainda está vazia.", style="red1")
        case "9":
            if len(filmes) == 0: # Se Lista estiver vazia, faz a função.
                carregar_dados()
            else:
                console.print("Lista de Filmes já não está vazia.", style="red1")
        case "10":
            sair() # Pode-se usar break para sair do loop e teria o mesmo efeito.

            ##### EXTRAS ####
        case "15":
            if len(filmes) != 0: # Se Lista estiver vazia, não faz a função.
                eliminar_lista()
            else:
                console.print("Lista de Filmes ainda está vazia.", style="red1")
        case "16":
            ls_dir()
        case "17":
            if ultimo_index < 0:
                console.print("Não existe ficheiros na pasta para eliminar.", style="red1")
            else:
                apagar_exportado()
        case "18":
            info_filme()
        case _:
            console.print("Tem de escolher um numero do menu.", style="red1")

    
