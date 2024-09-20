import math

i = 1
s = 0.0
x = 0.0
y = 0.0
lista_valores = []
while i <= 5:
    t = float(input(f"Introduza valor {i}: "))
    lista_valores.append(t)

    s = s + t
    if i == 1:
        x = t
        y = t
    else:
        if t > x:
            x = t
        if t < y:
            y = t
    i = i + 1

media = s / 5
dp = math.sqrt(((pow((lista_valores[0]-media), 2) + pow((lista_valores[1]-media), 2) + pow((lista_valores[2]-media), 2)) + pow((lista_valores[3]-media), 2) + pow((lista_valores[4]-media), 2))/5)

print(f"Valor de s: {s} ")
print(f"Valor de x: {x} ")
print(f"Valor de y: {y} ")
print(f"Valor da media: {media}")
print(f"Desvio Populacional: {dp:.4f}")