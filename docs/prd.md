# API RESTful de Gestão com Autenticação JWT

## Goals and Background Context

### Goals
- Desenvolver uma API RESTful minimal em .NET 7+ para gerenciar um domínio específico.
- Implementar autenticação e autorização com JWT.
- Garantir segurança e boas práticas de desenvolvimento.
- Fornecer documentação e testes básicos.

### Background Context
Esta API será utilizada para gerenciar um domínio específico (ex.: biblioteca, estoque, tarefas). O sistema deve incluir autenticação baseada em JWT, permitindo diferentes níveis de acesso (Admin e Editor). A arquitetura seguirá o padrão Clean Architecture, garantindo separação de responsabilidades e escalabilidade.

### Change Log
| Date       | Version | Description                          | Author |
|------------|---------|--------------------------------------|--------|
| 2025-11-20 | 1.0     | Documento inicial                    | BMad   |

---

## Requirements

### Functional Requirements
1. **FR1**: O sistema deve permitir login com JWT Bearer Token.
2. **FR2**: O sistema deve suportar perfis de usuário: Admin e Editor.
3. **FR3**: O token JWT deve ter expiração configurável.
4. **FR4**: O sistema deve permitir CRUD completo de usuários (apenas Admin).
5. **FR5**: O sistema deve permitir listagem paginada de usuários.
6. **FR6**: O sistema deve validar email e senha ao criar usuários.
7. **FR7**: O sistema deve permitir CRUD completo da entidade principal (ex.: Livros/Produtos/Tarefas).
8. **FR8**: O sistema deve permitir listagem paginada e filtrada da entidade principal.
9. **FR9**: O sistema deve aplicar permissões: Admin (total), Editor (criar/visualizar).

### Non-Functional Requirements
1. **NFR1**: A API deve ser desenvolvida em .NET 7 ou superior.
2. **NFR2**: A arquitetura deve seguir o padrão Clean Architecture.
3. **NFR3**: O banco de dados deve ser MySQL ou PostgreSQL.
4. **NFR4**: O sistema deve incluir documentação Swagger/OpenAPI.
5. **NFR5**: O sistema deve incluir testes unitários com xUnit.
6. **NFR6**: O sistema deve implementar injeção de dependência nativa.

---

## Technical Assumptions

### Repository Structure
- Monorepo

### Service Architecture
- Monolith

### Testing Requirements
- Unit + Integration

### Additional Technical Assumptions
- Uso de Entity Framework Core para acesso ao banco de dados.
- Configuração de CORS para segurança.
- Senhas armazenadas com hash (bcrypt/argon2).

---

## Entities

### Usuario
- **Id**: Identificador único.
- **Email**: Endereço de email único e válido.
- **Senha**: Hash da senha.
- **Perfil**: Admin ou Editor.
- **DataCriacao**: Data de criação do usuário.

### EntidadePrincipal (ex.: Livro/Produto/Tarefa)
- **Id**: Identificador único.
- **Nome**: Nome da entidade.
- **Descricao**: Descrição detalhada.
- **Categoria**: Categoria da entidade.
- **Status**: Status atual (ativo/inativo).
- **DataCriacao**: Data de criação.

---

## Endpoints

### Autenticação
- **POST /login**: Realiza login e retorna um JWT.

### Gestão de Usuários
- **GET /usuarios**: Lista usuários (Admin).
- **POST /usuarios**: Cria um novo usuário (Admin).
- **PUT /usuarios/{id}**: Atualiza um usuário existente (Admin).
- **DELETE /usuarios/{id}**: Remove um usuário (Admin).

### Gestão da Entidade Principal
- **GET /[entidade]**: Lista entidades com paginação e filtros.
- **POST /[entidade]**: Cria uma nova entidade (Admin/Editor).
- **PUT /[entidade]/{id}**: Atualiza uma entidade existente (Admin).
- **DELETE /[entidade]/{id}**: Remove uma entidade (Admin).

---

## Epics

### Epic 1: Foundation & Core Infrastructure
- Estabelecer configuração inicial do projeto, autenticação e gestão básica de usuários.

### Epic 2: Core Business Entities
- Criar e gerenciar as entidades principais com operações CRUD.

### Epic 3: User Workflows & Interactions
- Implementar fluxos de trabalho e interações principais para usuários.

---

## Next Steps
1. Configurar o projeto inicial com .NET 7 e EF Core.
2. Implementar autenticação JWT.
3. Desenvolver endpoints de gestão de usuários.
4. Desenvolver endpoints de gestão da entidade principal.
5. Configurar Swagger e testes unitários.