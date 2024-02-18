import random
import time
min = int(input("What's the minimum number you would like? "))
max = int(input("What's the maximum number you would like? "))

num1 = int(random.randint(min,max))
num2 = 0

while num1 != num2:
    num2 = int(input(f"What number do you think is it? ({min},{max})\n"))
    if num1 == num2:
        print("Nice, you got it!")
        time.sleep(1)
    elif num1 > num2:
        print("Higher!")
    elif num1 < num2:
        print("Lower!")