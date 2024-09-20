def is_prime(num):
    if num < 2:
        return False
    for i in range(2, int(num)):
        if num % i == 0:
            return False
    return True
    
num = int(input("Numero: "))

is_prime(num)

if is_prime(num):
    print("É primo")
else:
    print("Não é primo")