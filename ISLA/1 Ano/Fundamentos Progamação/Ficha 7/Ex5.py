"""Na empresa X.P.T.O, L.da, os funcionários são pagos a 3,50€ hora. Pretende-se um
programa que a partir da leitura do número de horas de laboração de um empregado em
cada um dos 5 dias da semana, calcule e apresente no êcran o vencimento semanal bruto e
liquido e respectivos descontos do funcionário, tendo em consideração:
▪ desconto para segurança social : 15%
▪ desconto para IRS : 10%                                                               """ 
taxa_ss = 0.15
taxa_irs = 0.10
valor_hora = 3.50
dia_semana = ["Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado", "Domingo"]

horas_trabalho = [float(input(f"Horas na {dia}: ")) for dia in dia_semana]

vencimento_bruto = sum(horas * valor_hora for horas in horas_trabalho)

desconto_ss = vencimento_bruto * taxa_ss
desconto_irs = vencimento_bruto * taxa_irs

vencimento_liquido = vencimento_bruto - desconto_ss - desconto_irs

print("\nResultados:")
print(f"Vencimento Bruto Semanal: {vencimento_bruto:.2f} €")
print(f"Desconto para Segurança Social (15%): {desconto_ss:.2f} €")
print(f"Desconto para IRS (10%): {desconto_irs:.2f} €")
print(f"Vencimento Líquido Semanal: {vencimento_liquido:.2f} €")
