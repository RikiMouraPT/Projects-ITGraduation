segundos = 0 
minutos = 0 
horasresto = 0 
horas = 0 
minutosresto = 0 
segundos =  int(input("Quantos segundos quer converter em formato HH:MM:SS\n"))
horasresto = segundos % 3600
horas = segundos // 3600
minutosresto = horasresto % 60
minutos = horasresto // 60
print( "As horas é: " , end="")
print(horas  , end="")
print( "\nOs minutos é: " , end="")
print(minutos  , end="")
print( "\nOs segundos é: " , end="")
print(minutosresto  , end="")
print( "\nHH:MM:SS -> " , end="")
print(horas  , end="")
print( ":" , end="")
print(minutos  , end="")
print( ":" , end="")
print(minutosresto  , end="")


#Python 3  - Automatic translated by Algorithmi 23.09a
#(c) Ant0nio M@nso 	Qua, 2023 out 25 19:35
