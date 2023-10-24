import random

min = 1
max = 99
num1 = random.randint(min,max)
num2 = 0

min = input("What's the minimum number you would like? ")
max = input("What's the maximum number you would like? ")

while num1 != num2:
    num2 = int(input(f"What number do you think is it? ({min},{max})\n"))
    if num1 == num2:
        print("Nice, you got it!")
    elif num1 > num2:
        print("Higher!")
    elif num1 < num2:
        print("Lower!")