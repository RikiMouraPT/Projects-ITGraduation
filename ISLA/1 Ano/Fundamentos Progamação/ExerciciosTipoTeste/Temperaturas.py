"""
Faça um algoritmo em Python que leia um conjunto de 20 temperaturas em graus 
celsius (pode ter casas decimais). O algoritmo deve apresentar no ecrã a média
das temperaturas, a temperatura máxima e temperatura mínima.
"""
temperaturas = []
media = 0
tam_lista = 5

for i in range(tam_lista):
    while True:
        try:
            temperatura = float(input(f"Digite a {i+1}º temperatura em graus Celsius: "))
            break
        except ValueError:
            print("Digite uma temperatura.")
    media = media + temperatura/tam_lista
    if i == 0:
        max_temp = temperatura
        min_temp = temperatura
    if temperatura > max_temp:
        max_temp = temperatura
    if temperatura < min_temp:
        min_temp = temperatura
    temperaturas.append(temperatura)

print("Media: ", media)
print("Maximo: ", max_temp)
print("Minimo: ", min_temp)

print("Temperaturas: ", temperaturas)