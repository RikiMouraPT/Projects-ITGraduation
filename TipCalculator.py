

people = int(input("How many persons are included?\n"))
bill_price = float (input("How much is the bill?\n"))
tip = float(input("How much tip dou you want to give, in percentage?\n"))

price_per_person = (bill_price + (bill_price*(tip/100)))/people

print(f"Each person needs to pay {price_per_person}€")