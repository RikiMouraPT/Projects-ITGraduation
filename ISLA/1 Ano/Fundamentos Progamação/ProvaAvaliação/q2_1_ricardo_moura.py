def converte_horas (segundos):
    h = 0
    m = 0
    s = 0
    h = segundos // 3600
    seg_rest = segundos % 3600
    m = seg_rest // 60
    s = seg_rest % 60
    return print(f"{h:02.0f}:{m:02.0f}:{s:02.0f}")

def main():
    converte_horas(3800)
    segundos = int(input("Segundos para converter: "))
    converte_horas(segundos)

main()