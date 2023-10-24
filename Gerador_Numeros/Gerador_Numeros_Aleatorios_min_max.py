import random

#####Gerador de Números Aleatório #####
# Faça um programa que gere números aleatórios e ofereça opções
# para configurar os intervalos e a quantidade de números a serem gerados.

range_min = float(input("Whats the minimum number?"))
range_max = float(input("Whats the maximum number?"))

if range_min < range_max:
    print(random.randint(range_min, range_max))
else:
    print("Minimum number can't be more than maximum.")