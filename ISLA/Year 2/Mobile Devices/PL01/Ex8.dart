/*
8. Implemente um sistema simples para gestão de uma biblioteca utilizando os conceitos de Programação
Orientada a Objetos (POO) em Dart. O sistema deve ser capaz de registar livros, gerir os empréstimos e controlar
a disponibilidade dos livros.
  a. Classe Livro: titulo (String), autor (String), anoPublicacao (int) e disponibilidade (bool). Inclua um
construtor que inicialize estes atributos de forma opcional e um método toString() para mostrar as
informações do livro.
  b. Classe Biblioteca: para gerir os livros. A classe deve conter:
    i. Uma lista de objetos Livro.
    ii. Um método adicionarLivro(),
    iii. Um método emprestarLivro(), que recebe o título de um livro e marca o livro como não disponível (caso esteja disponível).
    iv. Um método devolverLivro(), que recebe o título de um livro e marca o livro como disponível.
    v. Um método listarLivrosDisponiveis(), que devolve todos os livros disponíveis na biblioteca.
    vi. Um método listarLivrosEmprestados(), que mostra todos os livros que não estão disponíveis no momento.
  c. No main, crie um objeto Biblioteca e adicione livros. Simule o empréstimo e a devolução de livros,
usando os métodos criados. Liste os livros disponíveis e os livros emprestados após estas operações.
 */

class Livro{
  String titulo;
  String autor;
  int anoPublicacao;
  bool disponibilidade;

  Livro([
    this.titulo = "ND", 
    this.autor = "ND", 
    this.anoPublicacao = 0000, 
    this.disponibilidade = false
  ]);

  String toString(){
    return "Titulo: $titulo\n Autor: $autor\n Ano de Pubblicação: $anoPublicacao\n Disponibilidade: ${disponibilidade ? 'Sim' : 'Não'}";
  }
}

class Biblioteca{
  List<Livro> livros = List.empty(growable: true);

  Biblioteca();

  adicionarLivro(String titulo, String autor, int anoPublicacao, bool disponibilidade){
    Livro livro = new Livro(titulo, autor, anoPublicacao, disponibilidade);
    this.livros.add(livro);
  }

  emprestarLivro(String titulo){
    for (var livro in this.livros) {
      if (livro.titulo == titulo && livro.disponibilidade == true) {
        livro.disponibilidade = false;
        return 0;
      }
      else if(livro.disponibilidade == false){
        print("Livro já emprestado");
        return 0;
      }
    }
    print("Livro não existe");
    return 1;
  }

  devolverLivro(String titulo){
    for (var livro in this.livros) {
      if (livro.titulo == titulo && livro.disponibilidade == false) {
        livro.disponibilidade = true;
        return 0;
      }
      else if(livro.disponibilidade == true){
        print("Livro já emprestado");
        return 0;
      }
    }
    print("Livro não existe");
    return 1;
  }

  listarLivrosDisponiveis(){
    for (var livro in this.livros) {
      if(livro.disponibilidade == true){
        print(livro.toString());
      }
    }
  }

  listarLivrosEmprestados(){
    for (var livro in this.livros) {
      if(livro.disponibilidade == false){
        print(livro.toString());
      }
    }
  }
}

main() {
  Biblioteca biblioteca = Biblioteca();

  // Adicionando livros
  biblioteca.adicionarLivro("Livro 1", "Autor A", 2020, true);
  biblioteca.adicionarLivro("Livro 2", "Autor B", 2018, true);
  biblioteca.adicionarLivro("Livro 3", "Autor C", 2015, false);

  // Listando livros disponíveis
  print("Livros Disponíveis:");
  biblioteca.listarLivrosDisponiveis();

  // Listando livros emprestados
  print("\nLivros Emprestados:");
  biblioteca.listarLivrosEmprestados();

  // Emprestando um livro
  print("\nEmprestando 'Livro 1':");
  biblioteca.emprestarLivro("Livro 1");

  // Verificando listas após o empréstimo
  print("\nLivros Disponíveis após empréstimo:");
  biblioteca.listarLivrosDisponiveis();
  print("\nLivros Emprestados após empréstimo:");
  biblioteca.listarLivrosEmprestados();

  // Devolvendo o livro
  print("\nDevolvendo 'Livro 1':");
  biblioteca.devolverLivro("Livro 1");

  // Verificando listas após a devolução
  print("\nLivros Disponíveis após devolução:");
  biblioteca.listarLivrosDisponiveis();
  print("\nLivros Emprestados após devolução:");
  biblioteca.listarLivrosEmprestados();

  // Tentando emprestar um livro que não existe
  print("\nTentando emprestar 'Livro Não Existente':");
  biblioteca.emprestarLivro("Livro Não Existente");

  // Tentando devolver um livro que não foi emprestado
  print("\nTentando devolver 'Livro Não Existente':");
  biblioteca.devolverLivro("Livro Não Existente");

  // Tentando devolver um livro que não foi emprestado
  print("\nTentando devolver 'Livro 2' (não emprestado):");
  biblioteca.devolverLivro("Livro 2");
}
