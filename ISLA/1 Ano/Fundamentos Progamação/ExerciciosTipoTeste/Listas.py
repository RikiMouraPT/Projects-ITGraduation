def mes_maior_vendas(N, vendas_anual):
    max = 0
    for venda in vendas_anual:
        if venda > max:
            max = venda
    return max

def media_vendas(N, vendas_anual):
    media = 0
    for venda in vendas_anual:
        media = media + venda/N
    return media

def quant_meses_media(N, vendas_anual):
    qtd_meses = 0
    media = media_vendas(N, vendas_anual)
    for venda in vendas_anual:
        if venda > media:
            qtd_meses += 1
    return qtd_meses

vendas_anual = []

while True:
    try:
        N = int(input("Quantos meses trabalhou? "))
        if 1 <= N <= 12:
            break
        else:
            print("Digite um valor entre 1 e 12.")
    except ValueError:
        print("Digite um numero inteiro.")


for i in range(N):
    valor_mes = float(input(f"Digite o valor de vendas do mês {i+1}: "))
    vendas_anual.append(valor_mes)


mes_maior = mes_maior_vendas(N, vendas_anual)
print("Mês com maior vendas: ", mes_maior)

media = media_vendas(N, vendas_anual)
print("Mêdias de vendas: ", media)

quant_meses = quant_meses_media(N, vendas_anual)    
print("Quantidade de meses em que as vendas foram superiores à média: ", quant_meses) 