"""Uma sociedade de beneficência fez o seu peditório anual, que rendeu 25000 €., sendo
distribuídos por 100 famílias mais necessitadas da cidade, de acordo com o seguinte critério:
▪ Cada família recebe 150€. de base mais uma parcela igual a 10% do valor de base por
cada filho até 3 anos e 15% por cada filho com idade superior a 3 anos.
Elabore um programa que leia para cada família o número de filhos e respectivas idades e
indique quanto vai receber cada família, qual foi a média de donativos por família e se o
peditório foi suficiente para cobrir o total das despesas. ---- #########  CHATGPT  ########"""

def calcular_donativo_base():
    return 150

def calcular_donativo_por_filho(idade):
    if idade <= 3:
        return 0.1
    else:
        return 0.15

def calcular_donativo_familia(num_filhos, idades_filhos):
    donativo_base = calcular_donativo_base()
    donativo_total = donativo_base

    for idade in idades_filhos:
        donativo_total += donativo_base * calcular_donativo_por_filho(idade)

    return donativo_total

def main():
    total_peditorio = 25000
    num_familias = 10
    donativos = []

    for i in range(num_familias):
        num_filhos = int(input(f"Digite o número de filhos da família {i + 1}: "))
        idades_filhos = [int(input(f"Digite a idade do filho {j + 1}: ")) for j in range(num_filhos)]
        
        donativo_familia = calcular_donativo_familia(num_filhos, idades_filhos)
        donativos.append(donativo_familia)

    media_donativos = sum(donativos) / num_familias

    print("\nResultados:")
    for i, donativo in enumerate(donativos, 1):
        print(f"Família {i}: Receberá {donativo:.2f} €")

    print(f"\nMédia de donativos por família: {media_donativos:.2f} €")

    if sum(donativos) <= total_peditorio:
        print("O peditório foi suficiente para cobrir o total das despesas.")
    else:
        print("O peditório não foi suficiente para cobrir o total das despesas.")

if __name__ == "__main__":
    main()
