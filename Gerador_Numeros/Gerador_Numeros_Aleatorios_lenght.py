import random

def RandomNumber(L):
    min = pow(10, L-1)
    max = pow(10, L)-1
    return random.randint(min, max)

lenght = float(input("How many digits? "))

print(RandomNumber(lenght))

