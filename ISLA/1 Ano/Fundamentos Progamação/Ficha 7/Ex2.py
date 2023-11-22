import time

ano_inicial = int(input("Ano Inicial..: "))
ano_final = int(input("Ano Final..: "))
inicio_tempo = time.time()  # Registra o tempo de início
ano = ano_inicial

while ano <= ano_final:
    if (ano % 4 == 0 and ano % 100 != 0) or (ano % 400 == 0):
        print(f"{ano} - Bissexto")
    else:
        print(f"{ano} - Não Bissexto")
    ano = ano + 1

fim_tempo = time.time()  # Registra o tempo de fim
tempo_decorrido = fim_tempo - inicio_tempo  # Calcula o tempo decorrido em segundos

print(f"Tempo decorrido: {tempo_decorrido:.6f} segundos")