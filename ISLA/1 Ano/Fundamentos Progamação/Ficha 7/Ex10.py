"""
▪ nota máxima;
▪ nota mínima;
▪ n.º de positivas (>= 10);
▪ percentagem de negativas;
▪ média das notas;
▪ média das notas positivas.
"""
notas = []
positivas = []
negativas = []

while True:

    nota = float(input("Qual foi a nota? "))
    if nota > 20:
        continue
    
    if nota < 0:
        break
    
    # Dá append de cada nota a notas[]
    notas.append(nota)
    len_notas = len(notas) # Tamanho da lista

    # Minimo e Maximo
    nota_maxima = max(notas) # Maximo duma lista
    nota_minima = min(notas) # Maximo duma lista

    if nota >= 10:
        positivas.append(nota)         # Dá append de cada nota a positivas[] se nota >= 10
        len_positivas = len(positivas) # Tamanho da lista
    if nota < 10:
        negativas.append(nota)         # Dá append de cada nota a negativas[] se nota < 10
        len_negativas = len(negativas) # Tamanho da lista
    
    
percentagem_negativas = (len_negativas/len_notas)*100
media_notas = (sum(notas))/len_notas
media_notas_positivas = (sum(positivas))/len_positivas

print(f"A nota maxima é..............: {nota_maxima}")
print(f"A nota minima é..............: {nota_minima}")
print(f"O nº de positivas é..........: {len_positivas}")
print(f"A percentagem de negativas é.: {percentagem_negativas:.2f}%")
print(f"A média das notas é..........: {media_notas:.2f}%")
print(f"A média das notas positivas é: {media_notas_positivas}")
