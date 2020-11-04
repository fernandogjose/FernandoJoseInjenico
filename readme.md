### Projeto
- **Desenvolvido por:** Fernando José
- **Descrição:**
Criação de uma página na web onde o cliente possa calcular o valor da ligação. 
O cliente pode escolher os códigos das cidades de origem e destino, o tempo da ligação em minutos e escolher qual o plano FaleMais. 
O sistema deve mostrar dois valores: (1) o valor da ligação com o plano e (2)
sem o plano. 

### Padrões e Tecnologias utilizadas
- Angular 9.1.7
- Net Core 3.1
- DDD
- API
- XUnit
- Swagger
- SQL Server
- MongoDB
- Dapper
- IoC
- Moq
- C#
- Middeware
-- RequestResponseMiddleware: Responsável por logar e tratar tudo que entre e sai da API
-- ExceptionMiddleware: Responsável por pegar e tratar todos os erros inesperados na aplicação

### Configuração

#### Pré requisitos
- nodeJS
- Angular CLI
- Net Core 3.1

#### Front
- Abrir Terminal (PowerShell ou outro)
- Acessar a pasta onde está o projeto
- Acessar a pasta .\Src\FernandoJose.Angular
- npm install
- npm install -g @angular/cli (necessário se não tiver o angular cli)
- ng serve

#### BackEnd
- Abrir Terminal (PowerShell ou outro)
- Acessar a pasta onde está o projeto
- Acessar a pasta .\Src\FernandoJose.Api
- dotnet restore
- dotnet build
- dotnet run

### Testar
- **Swagger: ** https://localhost:44337/swagger/index.html
- **WebPage: ** http://localhost:4200