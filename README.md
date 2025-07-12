# 🏨 Sistema de Hospedagem de Hotel

Este é um projeto desenvolvido em **C# (.NET)** que simula um sistema básico de gerenciamento de hospedagem para um hotel. O sistema permite cadastrar hóspedes, criar suítes com diferentes tipos e capacidades, e gerenciar reservas, calculando o valor total com base na diária e nos dias reservados. O código inclui tratamento de exceções para garantir a robustez e segue uma estrutura orientada a objetos.

---

## ✨ Funcionalidades Principais

* **Cadastro de Hóspedes:** Permite registrar múltiplos hóspedes.
* **Criação de Suítes:** Define suítes com tipo, capacidade e valor da diária.
* **Gerenciamento de Reservas:** Cria reservas associando hóspedes a uma suíte por um determinado número de dias.
* **Validação de Capacidade:** Garante que o número de hóspedes não exceda a capacidade da suíte.
* **Cálculo de Diárias:** Calcula o valor total da hospedagem, com um desconto de 10% para reservas de 10 dias ou mais.
* **Tratamento de Exceções:** Lida com erros comuns, como tentativa de reserva com mais hóspedes do que a capacidade permitida.

---

## 🛠️ Estrutura do Projeto

* **`/Models`**: Contém as classes de domínio `Pessoa`, `Suite` e `Reserva`, que representam as entidades principais do sistema.
* **`Program.cs`**: Arquivo principal que contém a lógica de execução, criação de instâncias e simulação do sistema.
* **`02_Sistema_De_Hospedagem_Hotel.csproj`**: Arquivo de projeto .NET que define as configurações e dependências.
* **`/bin`** e **`/obj`**: Diretórios de saída gerados durante a compilação do projeto.

---

## ⚙️ Pré-requisitos

* [.NET SDK 9.0](https://dotnet.microsoft.com/download) ou superior.
* Um editor de código de sua preferência (Visual Studio, VS Code, JetBrains Rider).

---

## 🚀 Como Executar

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/CiceroGGS/trilha-net-explorando-desafio.git](https://github.com/CiceroGGS/trilha-net-explorando-desafio.git)
    ```

2.  **Navegue até o diretório do projeto:**
    ```bash
    cd trilha-net-explorando-desafio
    ```

3.  **Restaure as dependências do projeto:**
    ```bash
    dotnet restore
    ```

4.  **Compile e execute a aplicação:**
    ```bash
    dotnet run
    ```

---

## 📄 Exemplo de Saída

Ao executar o projeto, o console exibirá um resumo da reserva, como o exemplo abaixo:

```console
Hóspedes: 2
Valor diária: 100
```
(O valor pode variar dependendo dos dados inseridos no arquivo Program.cs)

