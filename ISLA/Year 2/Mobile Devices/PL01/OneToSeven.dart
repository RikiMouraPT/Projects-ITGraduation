import 'dart:io';

double dividir() {
  try {
    int? inputA;
    int? inputB;

    do {
      stdout.write("Digite o valor de a: ");
      inputA = int.tryParse(stdin.readLineSync()!);
    } while (inputA is! int);
    do {
      stdout.write("Digite o valor de b: ");
      inputB = int.tryParse(stdin.readLineSync()!);
    } while (inputB is! int);

    if (inputB == 0){
      throw Exception("Divisão por zero.");
    } 

    double resultado = inputA / inputB;
    return resultado;

  } catch (e) {
    stdout.write("Erro: $e\n");
    return 0;
  }
}

List filtrarPares(List<int> lista){
  return lista.where((k) => k % 2 == 0).toList();
}

Map contarCaracteres (String string){
  Map<String, int> mapa = {};

  for (var char in string.split('')) {
    mapa[char] = (mapa[char] ?? 0) + 1;
  }
  
  return mapa;
}

Set adicionarNome(Set set, String nome){
  try {
    set.add(nome);
  } catch (e) {
    print("Erro: $e");
  }

  return set;
}

Map criarPerfilUtilizador ({required String nome, required String email, int idade=0 , String cidade="ND"}){
  Map mapa = {
    "Nome": nome,
    "Email": email,
    "Idade": idade,
    "Cidade": cidade
  };

  return mapa;
}

List<int> somaDiagonais(List<List<int>> matriz1, List<List<int>> matriz2){
  List<int> resultado = [];
  int linhas = matriz1.length;
  int j = matriz1[0].length - 1;

  for (var i = 0; i < linhas; i++) {
    resultado.add(matriz1[i][i] + matriz2[i][i]); //Diagonal Principal
    resultado.add(matriz1[i][j] + matriz2[i][j]); //Diagonal Secundaria
    j--;
  }

  return resultado;
}

List<List<int>> transporMatriz(List<List<int>> matriz){
  int linhas = matriz.length;
  int colunas = matriz[0].length;

  List<List<int>> matrizTransposta = []; 
  for (var i = 0; i < linhas; i++) {
    matrizTransposta.add(List.filled(colunas, 0));
  }

  for (var i = 0; i < matriz.length; i++) {
    for (var j = matriz.length - 1; j >= 0; j--) {
      matrizTransposta[j][i] = matriz[i][j]; 
    }
  }

  return matrizTransposta;
}

void main(){
  //Exercicio 1
  /*  
  print(dividir());
  */

  //Exercicio 2
  /*
  List<int> lista = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
  print(filtrarPares(lista));
  */
  
  //Exercicio 3
  /* 
  print(contarCaracteres("banana"));
  */

  //Exercicio 4
  /* 
  Set set = {"Ricardo", "Vitor", "Joana"};
  String nome = "Joana";
  print(adicionarNome(set, nome));
  */

  //Exercicio 5
  /* 
  print(criarPerfilUtilizador(nome: "Ricardo", email: "ricardo@teste.com"));
  print(criarPerfilUtilizador(nome: "Ricardo", email: "ricardo@teste.com", idade: 23));
  print(criarPerfilUtilizador(nome: "Ricardo", email: "ricardo@teste.com", cidade: "Porto"));
  print(criarPerfilUtilizador(nome: "Ricardo", email: "ricardo@teste.com", idade: 23, cidade: "Porto"));
  */

  //Exercicio 6
  /*
  List<List<int>> matriz1 = [
    [6,2,5],
    [3,2,5],
    [4,4,5]
  ];
    List<List<int>> matriz2 = [
    [9,5,8],
    [6,3,8],
    [7,7,8]
  ];
  print(somaDiagonais(matriz1, matriz2));
  */

  //Exercicio 7
  /*
  List<List<int>> matriz = [
    [6,2,5],
    [3,2,5],
    [4,4,5]
  ];
  print(matriz);
  print(transporMatriz(matriz));
  */

  //Exercicio 8
  
}