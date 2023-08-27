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
    - <strong>dotnet sln add PaymentContext.Domain\PaymentContext.Domain.csproj</strong>
    - <strong>dotnet sln add PaymentContext.Shared\PaymentContext.Shared.csproj</strong>
    - <strong>dotnet sln add PaymentContext.Tests\PaymentContext.Tests.csproj</strong>
- Adicionando Referencia entre projetos
    - PaymentContext.Domain: 
        <p><strong>dotnet add PaymentContext.Domain reference PaymentContext.Shared</strong></p>
    - PaymentContext.Shared: <strong>Não referencia niguem</strong>
    - PaymentCotnext.Tests: <strong>
        <p>dotnet add PaymentContext.Tests reference PaymentContext.Domain</p>
        
        <p>dotnet add PaymentContext.Tests reference PaymentContext.Shared</p>
    </strong>
