# 🚀 Minimal API em .NET com JWT, MySQL e Testes Automatizados

Este projeto foi desenvolvido seguindo templates e aulas do Professor **Danilo Aparecido** no **bootcamp da DIO "Avanade - Back-end com .NET e IA"** e consiste em uma **Minimal API em .NET**, utilizando:

- **Autenticação JWT**
- **Entity Framework Core + MySQL**
- **Padrão de Serviços (Injeção de Dependência)**
- **Swagger com suporte a autenticação**
- **Testes automatizados com MSTest**
- **Mocks e WebApplicationFactory para testes de integração**


------------------------------------------------------------------------

## 📌 Tecnologias Utilizadas

-   .NET 7+
-   Minimal API
-   Entity Framework Core (MySQL)
-   JWT Authentication
-   Swagger (Swashbuckle)
-   MSTest
-   Dependency Injection
-   WebApplicationFactory (para testes de integração)
-   MySQL

------------------------------------------------------------------------

## 📁 Estrutura do Projeto

    /MinimalApi
    │── MinimalApi.csproj
    │── Startup.cs
    │── Program.cs
    │
    ├── Dominio
    │   ├── Entidades
    │   ├── Enuns
    │   ├── Interfaces
    │   ├── ModelViews
    │   └── Servicos
    │
    ├── Infraestrutura
    │   └── Db
    │
    └── DTOs

------------------------------------------------------------------------

## 🔐 Autenticação JWT

A API utiliza **JWT** para autenticação.\
O token é gerado no endpoint:

    POST /administradores/login

Exemplo de corpo:

``` json
{
  "email": "adm@teste.com",
  "senha": "123456"
}
```

Ao autenticar corretamente, retorna:

``` json
{
  "email": "adm@teste.com",
  "perfil": "Adm",
  "token": "..."
}
```

Use esse token no Swagger clicando em **Authorize**.

------------------------------------------------------------------------

## 🗄️ Banco de Dados -- MySQL

Configure o `appsettings.json`:

``` json
{
  "ConnectionStrings": {
    "MySql": "server=localhost;database=minimal_api;user=root;password=123456"
  },
  "Jwt": "CHAVE_SUPER_SECRETA_AQUI"
}
```

------------------------------------------------------------------------

## 📚 Endpoints Principais

## 🔐 **Administradores**

| Método | Rota                       | Autorização       | Descrição |
|--------|-----------------------------|--------------------|-----------|
| POST   | `/administradores/login`    | ❌ Anônimo         | Realiza login e retorna JWT |
| GET    | `/administradores`          | ✔️ Adm             | Lista administradores (com paginação) |
| GET    | `/administradores/{id}`     | ✔️ Adm             | Busca administrador pelo ID |
| POST   | `/administradores`          | ✔️ Adm             | Cadastra um novo administrador |

---

## 🚗 **Veículos**

| Método | Rota                | Autorização       | Descrição |
|--------|----------------------|--------------------|-----------|
| POST   | `/veiculos`          | ✔️ Adm, Editor     | Cadastra um veículo |
| GET    | `/veiculos`          | ✔️ Logado          | Lista veículos |
| GET    | `/veiculos/{id}`     | ✔️ Adm, Editor     | Busca veículo por ID |
| PUT    | `/veiculos/{id}`     | ✔️ Adm             | Atualiza veículo |
| DELETE | `/veiculos/{id}`     | ✔️ Adm             | Remove veículo |

------------------------------------------------------------------------

## 🧪 Testes Automatizados

O projeto inclui testes:

-   Unitários
-   De integração com **WebApplicationFactory**
-   Uso de **Mocks** com `AdministradorServicoMock`

Para rodar os testes:

``` bash
dotnet test
```

------------------------------------------------------------------------

## ▶️ Executando a API

1.  Configure o `appsettings.json`
2.  Execute as migrations (se existirem)
3.  Rode o projeto:

``` bash
dotnet run
```

Acesse o Swagger:

    https://localhost:5001/swagger

------------------------------------------------------------------------

## 🤝 Contribuição

Pull requests são bem-vindos!

------------------------------------------------------------------------

## 📜 Licença

Este projeto é distribuído sob a licença **MIT**.

CORS está liberado para qualquer origem (AllowAnyOrigin)

Tokens expiram em 1 dia

Perfis de administrador são controlados pela enum Perfil
