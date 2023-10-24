import random
list = ['ricardo','baguette']
palavras = ['Maria','Alice','Benedita', 'Beatriz', 'Margarida', 'Francisca', 'Camila', 'Francisco', 'Afonso', 'Duarte', 'Santiago', 'Martim', 'Miguel', 'Gabriel']
palavra = random.choice(palavras)
chances = 5
letras_tentativa = []
res = []
ganhou = False

while True:
    for letra in palavra:
        if letra.lower() in letras_tentativa:
            print(letra, end=" " )
        else:
            print ("_", end=" " )
    print(f"| Tens {chances} chances.")
    print(f"\nJá usaste {letras_tentativa}\n") 

    tentativa = input("Escolhe uma letra: ")
    letras_tentativa.append(tentativa.lower())
    
    if tentativa.lower() not in palavra.lower(): ## Tira uma chance sempre que erra
        chances -= 1
    
### WIN CONDITION ###

    ganhou = True
    for letra in palavra:
        if letra.lower() not in letras_tentativa:
            ganhou = False

    if chances == 0 or ganhou == True:
        break


## Last Message ##
if ganhou == True:
    print("\n### Ganhaste! ###")
else:
    print(f"Perdeste, a palavra era {palavra}.")