"""Escreva um programa que leia uma sequência de números inteiros terminada em zero e
calcule:
▪ máximo,
▪ mínimo,
▪ a soma dos números introduzidos,
▪ total dos números pares e ímpares introduzidos"""
sum = 0
total_pares = 0
total_impares = 0
i = 1
while True:
    numero = int(input(f"Digite o {i}º número (0 para sair): "))
    if i == 1:
        maximo = numero
        minimo = numero
    i += 1
        
    if numero == 0:
        break

    if numero > maximo:
        maximo = numero
    if numero < minimo:
        minimo = numero

    sum = sum + numero

    if numero % 2 == 0:
        total_pares += 1
    else:
        total_impares += 1
    
print(f"Máximo: {maximo}")
print(f"Mínimo: {minimo}")
print(f"Soma total: {sum}")
print(f"Total de números pares: {total_pares}")
print(f"Total de números ímpares: {total_impares}")