import math

salliquido = 0 
valorirs = 0 
valorss = 0 
salbruto =  float(input("Quanto é o salario bruto?\n"))
IRS =  float(input("Quanto desconta para IRS?\n"))
valorirs = salbruto * ( IRS / 100 )
valorss = salbruto * 0.11
salliquido = salbruto - valorirs - valorss
print( "O desconto para IRS é: " , end="")
print(valorirs  , end="")
print( "\nO desconto para a Segurança Social é: " , end="")
print(valorss  , end="")
print( "\nO salario liquido é: " , end="")
print(salliquido  , end="")