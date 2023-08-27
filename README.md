# Modelagen de Domínios Ricos

- Criando pastas
    - PaymentContext.Domain
    - PaymentContext.Shared
    - PaymentContext.Tests
- Criando os projetos
    - cd PaymentContext.Domain - <strong>dotnet new classlib</strong>
    - cd PaymentContext.Shared - <strong>dotnet new classlib</strong>
    - cd PaymentContext.Tests - <strong>dotnet new mstest</strong>
- Adicionando referenciado dos projetos na solução
    - dotnet sln add PaymentContext.Domain\PaymentContext.Domain.csproj
    - dotnet sln add PaymentContext.Shared\PaymentContext.Shared.csproj
    - dotnet sln add PaymentContext.Tests\PaymentContext.Tests.csproj
