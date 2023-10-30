from random import shuffle
import random
import string

#List of all characters
upper_letters = string.ascii_uppercase
lower_letters = string.ascii_lowercase
numbers = string.digits
spec = string.punctuation

## Inputs
length = int(input("Whats the password lenght? -> "))

if length == 0:
    print("That's Impossible!")
    exit()
else:
    upper_length = int(input("How many capital letters? -> "))
    spec_length = int(input("How many special characters? -> "))
    numbs_length = int(input("How many numbers? -> "))

if length >= (upper_length+spec_length+numbs_length) and length != 0:
    pass_upper = random.choices(upper_letters, k = upper_length)
    pass_lower = random.choices(lower_letters, k = length - upper_length - spec_length - numbs_length)
    pass_spec = random.choices(spec, k = spec_length)
    pass_numbs = random.choices(numbers, k = numbs_length)

    password = pass_spec + pass_numbs + pass_upper + pass_lower
    shuffle(password)
    pass_concatenated = "".join(password)
    print(f"Here's your password super secure password: {pass_concatenated}")

else:
    print("That math doesn't make sense. Try again.")
