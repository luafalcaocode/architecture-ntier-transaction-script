# architecture-ntier-transaction-script
An sketch to develop applications using Fowler N-Tier architecture with Transaction Script organization. This project uses ASP .NET Core as a framework and some Design Patterns such as Repository, DI, Facade and Adapters.


## Documentação da API:

https://localhost:44332/swagger/index.html

## Pré-requisitos:

Antes de executar o projeto certifique-se de ter as configurações abaixo instaladas no seu ambiente.

+ .NET Core SDK 3.1
+ PostgreSQL 2.1.4
+ Visual Studio 2019 ou o Visual Studio Code
+ Privilégios de administrador no Sistema Operacional
+ Configurar uma variável de ambiente no sistema operacional como administrador com o nome **SECRET** e um valor  (isto será usado para autenticação JWT durante login e acesso aos endpoints protegidos)
+ GIT 2.26.2 ou uma versão superior
+ pgAdmin 4
+ Postman 

## Rodando o projeto:

Siga os passos abaixo para rodar o projeto.

1. Clone este repositório utilizando o GIT para um diretório na sua máquina: **git clone** https://github.com/luafalcaocode/alterdata-aspnetcore-api.git
2. Abra o projeto no Visual Studio 2019 (em modo Administrador).
3. Altere a string de conexão **PostgreSQLConnection** configurada no arquivo **appsettings.json** para apontar para as configurações da sua máquina com um servidor PostgreSQL;
4. Abra o console do Visual Studio (**navegue até Ferramentas > Gerenciador de Pacotes do Nuget > Console do Gerenciador de Pacotes**), verifique se o projeto principal está selecionado (**alterdata.api.Web**) e execute os dois comandos a seguir para configurar e gerar a estrutura do banco de dados:

- **Add-Migration InitialCreate** (este comando registra o modelo de dados e habilita a sincronização com a estrutura física)
- **Update-Database** (este comando cria o banco de dados baseado na configuração do arquivo **appsettings.json**)

**Obs.:** Se os comandos acima não forem reconhecidos no seu sistema então será necessário configurar o recurso **migrations** executando o seguinte comando no console: **dotnet tool install --global dotnet-ef**. Em seguida, execute novamente os comandos acima.

Alternativamente você pode rodar o projeto utilizando o Visual Studio Code ou outra ferramenta executando os comandos da .NET CLI para rodar o projeto. 

5. Pressione F5 

## Solução de problemas

Em caso de problemas para executar o projeto, tente as seguintes opções:

+ Se ao rodar o projeto você visualizar uma mensagem de erro, verifique se o seu Antivírus está bloqueando a execução do projeto. O Avast, por exemplo, faz uma varredura ao iniciar a aplicação e só após sua conclusão é possível iniciar o projeto (nesse caso pressione F5 novamente). 

+ Se os projetos não forem carregados na solução, abra o Visual Studio e rode-o novamente com permissão de Administrador.

+ Se a autenticação apresentar problemas, verifique se uma variável de ambiente de sistema com o nome **SECRET** está configurada no seu sistema operacional. Isto é necessário para garantir a segurança da API.
