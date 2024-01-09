
import os
def limpa():
    os.system('cls')

def cabecalho(texto):
    limpa()
    print("="*30)
    print(texto)
    print("-"*30)

def ler_dados():
    cabecalho("LER DADOS")
    
    contador = len(lista_dados) + 1
    while True:
        print("Registo nº " + str(contador))
        numero = int(input(" Numero (0 termina).: "))
        
        if numero == 0:
            break
        
        nome = input(" Nome...............: ")
        nota = float(input(" Nota...............: "))

        registo = [numero, nome, nota]
        #print(registo)
        
        lista_dados.append(registo)
        #print(lista_dados)

        contador = contador + 1
        print()

def ver_dados():
    cabecalho("CONSULTA DADOS")
    print()
    print("#    Numero    Nome                            Nota")
    print("="*51)

    contador = 1
    for elemento in lista_dados:
        numero = elemento[0]
        nome = elemento[1]
        nota = elemento[2]

        print(contador, " "*(3-len(str(contador))), numero, " "*(8-len(str(numero))) , nome, " "*(30-len(str(nome))), nota)
        
        contador = contador + 1
    
    print()    
    input("ENTER p / continuar....")


def mostra_media():
    cabecalho("MEDIA NOTAS")

    soma = 0
    n = len(lista_dados)
    for i in range(n):
        soma = soma + lista_dados[i][2]
    
    media = 0
    if n >0:
        media = soma / n
    
    print(f"Média: {media}")
    
    print()    
    input("ENTER p/ continuar....")

def mostra_maximo():
    cabecalho("NOTA MAIOR")

    n = len(lista_dados)

    if n >0:
        max = lista_dados[0][2]
        pos = 0
    
    for i in range(n):
        if lista_dados[i][2] > max:
            max = lista_dados[i][2]
            pos = i
    
    print()
    if n > 0:
        print(f"Nota maior.: {max}")
        print(f"Numero.....: {lista_dados[pos][0]}")
        print(f"Nome.......: {lista_dados[pos][1]}")
        print(f"Nota.......: {lista_dados[pos][2]}")
        print()
    
    input("ENTER p/ continuar....")

def guardar_ficheiro():
    cabecalho("GUARDAR FICHEIRO")

    ficheiro = open("dados_notas.txt","w")
    ficheiro.write("numero, nome, nota\n")
    for i in range(len(lista_dados)):
        ficheiro.write(f"{lista_dados[i][0]}, {lista_dados[i][1]}, {lista_dados[i][2]}\n")
    
    ficheiro.close()
    
    print()
    print("Ficheiro guardado!")
    input("ENTER p/ continuar....")


def abrir_ficheiro():
    #cabecalho("ABRIR FICHEIRO")
   
    nome_ficheiro = "dados_notas.txt"
   
    if os.path.exists(nome_ficheiro):
        
        ficheiro = open(nome_ficheiro,"r")
        print()

        contador = 1
        for linha in ficheiro.readlines():
            #print(linha)
            if (contador > 1): # ignorar a 1ª linha
                # reconstruir lista
                campos = linha.split(",") # separa a linha pelo separador ";" e coloca na lista campos
                #print(campos)
                #print(campos[1])
                # retira "\n" do campo -> campos[2].rstrip("\n")
                registo = [int(campos[0]), campos[1].lstrip(), float(campos[2].rstrip("\n"))]
                #print(registo)
                lista_dados.append(registo)            
        
            contador = contador + 1

    #print(lista_dados)
    print()
    #print("Ficheiro aberto!")
    print()
    #input("ENTER p/ continuar....")

def alterar_dados():
    cabecalho("ALTERAR DADOS")
    # mostra dados
    print()
    print("# Numero Nome Nota")
    print("="*53)
    contador = 1
    
    for elemento in lista_dados:
        numero = elemento[0]
        nome = elemento[1]
        nota = elemento[2]
        print(contador, " "*(3-len(str(contador))), numero, " "*(8-len(str(numero))) , nome, " "*(30-len(str(nome))), nota)
        contador = contador + 1
    
    print()
    registo = int(input("Nº Registo a alterar (#).: "))    

    if registo > 0 and registo < contador:
        # mostra registo
        registo = registo -1
        print()
        print(f"Numero.....: {lista_dados[registo][0]}")
        print(f"Nome.......: {lista_dados[registo][1]}")
        print(f"Nota.......: {lista_dados[registo][2]}")
        
        print()
        print("Alterar registo:")
        novo_nome = input(" Alterar nome...............: ")
        nova_nota = float(input(" Alterar nota...............: "))
       
        # alterar registo
        lista_dados[registo][1] = novo_nome
        lista_dados[registo][2] = nova_nota

        print()
        print("Registo alterado!")
        input("ENTER p/ continuar....")

def eliminar_dados():
    cabecalho("ELIMINAR DADOS")
      # mostra dados
    print()
    print("# Numero Nome Nota")
    print("="*53)
    contador = 1
    
    for elemento in lista_dados:
        numero = elemento[0]
        nome = elemento[1]
        nota = elemento[2]
        print(contador, " "*(3-len(str(contador))), numero, " "*(8-len(str(numero))) , nome, " "*(30-len(str(nome))), nota)
        contador = contador + 1
    
    print()
    registo = int(input("Nº Registo a eliminar (#).: "))    

    if registo > 0 and registo < contador:
        # mostra registo
        registo = registo -1
        print()
        print(f"Numero.....: {lista_dados[registo][0]}")
        print(f"Nome.......: {lista_dados[registo][1]}")
        print(f"Nota.......: {lista_dados[registo][2]}")
        
        print()
        
        lista_dados.pop(registo) # exclui registro da lista
        print()
        print("Registo eiminado!")
        input("ENTER p/ continuar....")
               
        

def main():

    
    abrir_ficheiro()

    while True:
        cabecalho("M E N U")
        print(" 1. Introduzir dados")
        print(" 2. Ver notas")
        print(" 3. Media notas")
        print(" 4. Nota maxima")
        print(" 5. Guardar em ficheiro")
        print(" 6. Abrir ficheiro")
        print(" 7. Alterar dados")
        print(" 8. Eliminar dados")
        print(" 9. Sair")
        print()
        opcao = int(input("Escolha a opcao: "))    

        if opcao == 1:
            ler_dados()
        elif opcao == 2:
            ver_dados()
        elif opcao == 3:
            mostra_media()
        elif opcao == 4:
            mostra_maximo()
        elif opcao == 5:
            guardar_ficheiro()
        elif opcao == 6:
            abrir_ficheiro()
        elif opcao == 7:
            alterar_dados()
        elif opcao == 8:
            eliminar_dados()
        elif opcao == 9:
            break
        else:
            print("Opção errada!")

# global
# definir a lista lista_dados
lista_dados = []

# chamar o main
main()