
codigo = ""
i = 0
chances = 3
while codigo != "isla":
    if i == 3:
        print("Locked for 3 years.")
        quit()
    codigo = input(f"Introduza password, tens {chances} chances: ")
    chances -= 1
    i += 1

print("Access Granted!")