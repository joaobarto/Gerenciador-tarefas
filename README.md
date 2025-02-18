# Gerenciador de Tarefas

Este projeto é um simples **Gerenciador de Tarefas** em C# que permite ao usuário adicionar, listar, concluir e remover tarefas. O aplicativo é executado em um terminal/console, e a interface é interativa, permitindo a manipulação de tarefas de forma fácil e prática.

## Funcionalidades

- **Adicionar Tarefa**: Permite adicionar novas tarefas com uma descrição fornecida pelo usuário.
- **Listar Tarefas**: Exibe todas as tarefas cadastradas no sistema.
- **Concluir Tarefa**: Marca uma tarefa como concluída, fornecendo o ID da tarefa.
- **Remover Tarefa**: Remove uma tarefa com base no ID fornecido pelo usuário.
- **Sair**: Encerra o programa.

## Estrutura do Projeto

### Classes e Namespaces

O código está dividido em três namespaces principais:

1. **Namespace `Layout`**: Contém funcionalidades para formatação de texto no console.
   - **Classe `Formatacao`**: Métodos para exibir cabeçalhos no console e manipular cores do texto.

2. **Namespace `GerenciarTarefa`**: Contém a lógica do gerenciamento de tarefas.
   - **Classe `Gerenciador`**: Métodos para adicionar, listar, concluir e remover tarefas.
   
3. **Namespace `Tarefas`**: Presumido conter a classe `Tarefa`, que representa uma tarefa individual.

4. **Classe `Program`**: Ponto de entrada do programa, onde o menu de interação é exibido.

## Métodos

### `Formatacao.Cor(string mensagem, ConsoleColor cor)`
- **Descrição**: Exibe uma mensagem no console com a cor de texto especificada.
- **Parâmetros**:
  - `mensagem` (string): Texto a ser exibido.
  - `cor` (ConsoleColor): Cor que será aplicada ao texto.
  
### `Formatacao.ImprimirCabecalho()`
- **Descrição**: Exibe um cabeçalho formatado com bordas no console, contendo o título "GERENCIADOR DE TAREFAS".
  
### `Formatacao.CentralizarTexto(string texto, int larguraConsole)`
- **Descrição**: Centraliza o texto fornecido com base na largura do console.
- **Parâmetros**:
  - `texto` (string): Texto a ser centralizado.
  - `larguraConsole` (int): Largura atual do console.
- **Retorno**: Texto centralizado com espaços à esquerda.

### `Gerenciador.AdicionarTarefa(string descricao)`
- **Descrição**: Adiciona uma nova tarefa à lista de tarefas com a descrição fornecida.
- **Parâmetros**:
  - `descricao` (string): Descrição da tarefa a ser adicionada.
  
### `Gerenciador.ListarTarefas()`
- **Descrição**: Exibe todas as tarefas cadastradas no sistema. Se não houver tarefas, exibe uma mensagem informando.
  
### `Gerenciador.ConcluirTarefa()`
- **Descrição**: Marca uma tarefa como concluída, baseado no ID fornecido pelo usuário.
- **Processo**:
  - O usuário insere o ID da tarefa a ser concluída.
  - O sistema busca a tarefa e a marca como concluída.
  
### `Gerenciador.RemoverTarefas()`
- **Descrição**: Remove uma tarefa do sistema com base no ID fornecido.
- **Processo**:
  - O usuário insere o ID da tarefa a ser removida.
  - O sistema remove a tarefa, se ela existir.

### `Program.Main(string[] args)`
- **Descrição**: Ponto de entrada principal do programa, onde o menu interativo é exibido e o usuário pode escolher as opções.
- **Processo**:
  - Apresenta um menu com as opções de adicionar, listar, concluir, remover tarefas ou sair.
  - Chama os métodos da classe `Gerenciador` para executar as ações solicitadas.


