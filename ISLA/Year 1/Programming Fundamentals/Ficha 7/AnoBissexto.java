import java.util.Scanner;

public class AnoBissexto {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ano Inicial..: ");
        int anoInicial = scanner.nextInt();

        System.out.print("Ano Final..: ");
        int anoFinal = scanner.nextInt();

        long inicioTempo = System.currentTimeMillis();  // Registra o tempo de início

        int ano = anoInicial;

        while (ano <= anoFinal) {
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)) {
                System.out.println(ano + " - Bissexto");
            } else {
                System.out.println(ano + " - Não Bissexto");
            }
            ano++;
        }

        long fimTempo = System.currentTimeMillis();  // Registra o tempo de fim
        double tempoDecorrido = (fimTempo - inicioTempo) / 1000.0;  // Calcula o tempo decorrido em segundos

        System.out.printf("Tempo decorrido: %.6f segundos%n", tempoDecorrido);

        scanner.close();
    }
}
