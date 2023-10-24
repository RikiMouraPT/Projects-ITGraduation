import random

def RandomNumber(L):
    min = pow(10, L-1)
    max = pow(10, L)-1
    return random.randint(min, max)

length = float(input("How many digits? "))

print(RandomNumber(length))
