import time
def print_pizza_oven():
    pizza_oven = (
        "   ______   \n"
        "  /      \\  \n"
        " /________\\ \n"
        "|  ____  []|\n"
        "| |    |  ||\n"
        "| |____|  ||\n"
        "|  ________|\n"
        "| |        |\n"
        "|_|________|"
    )
    print(pizza_oven)
def print_pepperoni_pizza():
    pizza = (
        "    _..._    \n"
        "  .:::::::.  \n"
        " ::::::::::: \n"
        " ::::::::::: \n"
        " `:::::::::' \n"
        "   `':::`'   "
    )
    print(pizza)
prices = {"Small": 15, "Medium": 20, "Large": 25, "Cheese": 1, "Pepperoni_Small": 2, "Pepperoni_Medium_Large": 3} 
bill = float(0.0)
print("Welcome to Python Pizza")
print("What pizza size do you want?\n1 - Small $15\n2 - Medium $20\n3 - Large $25")

pizza_size = input("What size do you want? - ")

match (pizza_size):
        case "1":
            print("Small it is.")
            cheese = input("Do you want extra cheese in your small pizza? Y(Yes) N(No) - ").upper()
            pepperoni = input("Do you want pepperoni in your small pizza? Y(Yes) N(No) - ").upper()
            if cheese == "Y" and pepperoni == "Y":
                bill =prices["Small"] + prices["Cheese"] + prices["Pepperoni_Small"]
            elif cheese == "Y" and pepperoni == "N":
                bill =prices["Small"] + prices["Cheese"]   
            elif cheese == "N" and pepperoni == "Y":
                bill =prices["Small"] + prices["Pepperoni_Small"]
            else:
                print("You are dumb and can't follow rules, so no pizza for you, bye!")
                time.sleep(1)
                exit()
            print("Your pizza is in the oven")
            print_pizza_oven()
            time.sleep(4.5)
            print("YOUR PIZZA IS READYYYYYYYY")
            print_pizza_oven
            time.sleep(1)
            print(f"Your final bill is ${bill}")
        case "2":
            print("\nMedium it is.")
            cheese = input("Do you want extra cheese in your small pizza? Y(Yes) N(No)").upper()
            pepperoni = input("Do you want pepperoni in your small pizza? Y(Yes) N(No)").upper()
            if cheese == "Y" and pepperoni == "Y":
                bill =prices["Medium"] + prices["Cheese"] + prices["Pepperoni_Medium_Large"]
            elif cheese == "Y" and pepperoni == "N":
                bill =prices["Medium"] + prices["Cheese"]   
            elif cheese == "N" and pepperoni == "Y":
                bill =prices["Medium"] + prices["Pepperoni_Medium_Large"]
            else:
                print("You are dumb and can't follow rules, so no pizza for you, bye!")
                time.sleep(1)
                exit()
            print("Your pizza is in the oven")
            print_pizza_oven()
            time.sleep(4.5)
            print("YOUR PIZZA IS READYYYYYYYY")
            print_pepperoni_pizza()
            time.sleep(1)
            print(f"Your final bill is ${bill}")
        case "3":
            print("\nLarge it is.")
            cheese = input("Do you want extra cheese in your small pizza? Y(Yes) N(No)").upper()
            pepperoni = input("Do you want pepperoni in your small pizza? Y(Yes) N(No)").upper()
            if cheese == "Y" and pepperoni == "Y":
                bill =prices["Large"] + prices["Cheese"] + prices["Pepperoni_Medium_Large"]
            elif cheese == "Y" and pepperoni == "N":
                bill =prices["Large"] + prices["Cheese"]   
            elif cheese == "N" and pepperoni == "Y":
                bill =prices["Large"] + prices["Pepperoni_Medium_Large"]
            else:
                print("You are dumb and can't follow rules, so no pizza for you, bye!")
                time.sleep(1)
                exit()
            print("Your pizza is in the oven")
            print_pizza_oven()
            time.sleep(4.5)
            print("YOUR PIZZA IS READYYYYYYYY")
            print_pepperoni_pizza()
            time.sleep(1)
            print(f"Your final bill is ${bill}")
