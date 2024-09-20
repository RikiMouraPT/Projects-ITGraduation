#Faça um programa que calcule a média de N números introduzidos pelo utilizador.
#O valor para N é pedido ao utilizador.

n = int(input("Quantos numeros quer calcular?\n"))
nums = 0
for i in range(1, n + 1):
    num = float(input(f"Digite o {i}º numero: "))
    nums += num
media = 0.0
media = nums/n
print(f"A média desses {i} numeros é: {media}")