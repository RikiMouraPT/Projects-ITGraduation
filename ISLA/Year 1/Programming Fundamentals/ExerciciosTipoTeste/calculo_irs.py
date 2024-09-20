"""
Construa uma função (calcula_irs) (Python) que receba como parâmetro um valor em euros
 e calcule o valor do IRS de acordo com as seguintes condições: 
 -Se valor euros menor que 1000 então IRS é 10% 
 -Se valor euros maior de 1000 e inferior a 1500 então IRS é 20% 
 -Se valor euros maior de 1500 então IRS é 30%

 Exemplo de chamada da função:  
 valor_euros = float(input(“Salário: “)
 valor_IRS = calcula_irs(valor_euros)
 print(f“Valor IRS: {valor_IRS}”)
 Apresente também o programa principal (procedimento), com respetiva chamada da função e escrita da informação pedida.
 """

def calcula_irs(valor):
    if valor <= 1000:
        irs = valor*0.10
    elif valor <= 1500:
        irs = valor*0.20
    else:
        irs = valor*0.30
    return irs

valor_euros = float(input("Salário? "))
valor_irs = calcula_irs(valor_euros)
print(f"Valor IRS: {valor_irs:.2f}€")