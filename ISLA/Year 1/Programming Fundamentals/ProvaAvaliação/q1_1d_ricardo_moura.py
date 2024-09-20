i = 1
s = 0.0
x = 0.0
y = 0.0

while i <= 5:
    t = float(input(f"Introduza valor {i}: "))
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

print(f"Valor de s: {s} ")
print(f"Valor de x: {x} ")
print(f"Valor de y: {y} ")