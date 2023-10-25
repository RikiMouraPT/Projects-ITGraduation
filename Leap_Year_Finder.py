"""
Desenvolva um algoritmo que:
Leia um número representando um determinado ano. Descobrir se esse número (ano)
representa um ano bissexto. Um ano é bissexto se cumprir a seguintes condições:
(1) se for divisível por 4,
(2) se não for divisível por 100.
Há uma excepção a esta última regra:
(3) no caso de ser divisível por 100, será bissexto se for divisível por 400.
"""

year = int(input("Choose a year: "))
if year % 4 == 0 and year % 100 != 00 or year % 400 == 0:
    print("Nice, it's a leap year.")
else:
    print("Unfortunately, it's not a leap year.")