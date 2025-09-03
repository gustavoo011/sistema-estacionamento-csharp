# 🚗 Sistema de Estacionamento (C# Console)

Este é um sistema de estacionamento desenvolvido em **C# Console**, com foco em praticar conceitos fundamentais da linguagem e boas práticas de programação.  

## 📌 Funcionalidades
- Cadastro de veículos.
- Remoção de veículos com cálculo de tempo de permanência e valor a pagar.
- Exibição da lista de veículos estacionados.
- Encerramento do sistema de forma controlada.

## 🛠️ Tecnologias e Recursos Utilizados
- **C# Console Application**
- **Classe `Estacionamento`** para organização e encapsulamento da lógica do sistema.
- **Consistência de dados na entrada** utilizando validações (`TryParse`) para evitar erros de digitação e formato inválido.
- **Coleção `List<string>`** para armazenar as placas dos veículos.
- **Estrutura `switch-case`** para o menu interativo e navegação entre opções.

## 📖 Estrutura do Sistema
1. O usuário informa o **preço inicial** e o **valor por hora**.
2. O menu interativo oferece as opções:
   - Adicionar veículo
   - Remover veículo
   - Listar veículos
   - Encerrar
3. As operações são processadas pela classe **Estacionamento**, garantindo clareza e separação de responsabilidades.
