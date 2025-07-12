Sistema de Hospedagem Hotel
Descrição
Este é um projeto desenvolvido em C# (.NET) que simula um sistema básico de gerenciamento de hospedagem para um hotel. O sistema permite cadastrar hóspedes, criar suítes com diferentes tipos e capacidades, e gerenciar reservas, calculando o valor total com base na diária. O código inclui tratamento de exceções para garantir robustez e uma estrutura orientada a objetos.
Funcionalidades

Cadastro de hóspedes em uma lista.
Definição de suítes com tipo, capacidade e valor da diária.
Criação de reservas com número de dias reservados.
Associação de suítes a reservas.
Validação da capacidade da suíte em relação ao número de hóspedes.
Cálculo do valor total da diária com base nos dias reservados.
Tratamento de erros para casos como excesso de hóspedes.

Estrutura do Projeto

Models/: Contém as classes Pessoa, Suite e Reserva, que representam os principais objetos do sistema.
bin/Debug/net9.0/: Pasta de saída com os arquivos compilados.
obj/: Arquivos gerados durante a compilação.
02_Sistema_De_Hospedagem_Hotel.csproj: Arquivo de projeto .NET.
Program.cs: Arquivo principal com a lógica de execução.

Pré-requisitos

.NET SDK 9.0 ou superior.
Um editor de código como Visual Studio, Visual Studio Code ou JetBrains Rider.

Como Executar

Clone o repositório:git clone https://github.com/CiceroGGS/trilha-net-explorando-desafio.git


Navegue até o diretório do projeto:cd trilha-net-explorando-desafio


Restaure as dependências:dotnet restore


Compile e execute o projeto:dotnet run


O programa exibirá no console a quantidade de hóspedes e o valor total da diária calculado.

Exemplo de Saída
Ao executar o código fornecido, a saída pode ser algo como:
Hóspedes: 2
Valor diária: 100

(O valor da diária é calculado como valorDiaria * diasReservados, neste caso 10 * 10 = 100, mas pode variar conforme os dados inseridos.)
Contribuindo

Faça um fork do repositório.
Crie uma branch para sua feature ou correção:git checkout -b minha-feature


Commit suas alterações:git commit -m "Descrição da mudança"

Envie para o repositório remoto:git push origin minha-feature

Abra um pull request com uma descrição clara das mudanças.

Autor

Cícero Guilherme Gonzaga Silvestre  
GitHub: @CiceroGGS  
LinkedIn: linkedin.com/in/cicero-guilsestre-9-44773260
