year = int(input("Choose a year: "))
if year % 4 == 0 and year % 100 != 00 or year % 400 == 0:
    print("Nice, it's a leap year.")
else:
    print("Unfortunately, it's not a leap year.")