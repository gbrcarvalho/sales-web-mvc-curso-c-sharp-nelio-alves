# Sales Web MVC

Um sistema simples de gerenciamento de vendas desenvolvido em **C#** com o framework **ASP .NET Core**, utilizando **Entity Framework** para acesso a dados, **MySQL** como banco de dados, **Razor** como motor de templates para renderização das views, e **Bootstrap** para estilização da interface.

Este projeto segue a arquitetura **MVC (Model-View-Controller)** e permite realizar operações CRUD (Create, Read, Update, Delete) para vendedores e departamentos, além de permitir a filtragem de vendas por data.

> Projeto baseado no curso do professor **Nélio Alves**.

## 🔧 Tecnologias Utilizadas

- **ASP .NET Core**
- **Entity Framework Core**
- **MySQL**
- **Razor View Engine**
- **Bootstrap 4/5**
- **LINQ**
- **C#**

## Funcionalidades

- **Departamentos**
  - Cadastro de novos departamentos
  - Edição de departamentos existentes
  - Exclusão de departamentos

- **Vendedores**
  - Cadastro de novos vendedores com associação a departamentos
  - Edição de dados de vendedores
  - Exclusão de vendedores
  - Visualização de detalhes de um vendedor

- **Vendas**
  - Registro de vendas por vendedor
  - Filtro de vendas por período (data inicial/final)
  - Consulta de somatório de vendas

## Interface

A interface é responsiva e construída com **Bootstrap**, garantindo boa usabilidade e visual moderno.

## 🔗 Repositório

Acesse o projeto completo no GitHub:

[https://github.com/gbrcarvalho/sales-web-mvc-curso-c-sharp-nelio-alves](https://github.com/gbrcarvalho/sales-web-mvc-curso-c-sharp-nelio-alves)

## 🚀 Como Executar o Projeto

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versão compatível com ASP.NET Core usada no projeto)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- [Visual Studio](https://visualstudio.microsoft.com/) com suporte a ASP.NET e Entity Framework Core

### Passos para executar:

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/gbrcarvalho/sales-web-mvc-curso-c-sharp-nelio-alves.git
   cd sales-web-mvc-curso-c-sharp-nelio-alves
   ```

2. **Configure a string de conexão com o MySQL**

   No arquivo appsettings.json, edite a seção de conexão com o banco de dados:  
   ```bash
   "ConnectionStrings": {
      "SalesWebMvcContext": "server=localhost;userid=seu_usuario;password=sua_senha;database=saleswebmvcapp"
   }
   ```

4. **Execute as migrações para criar o banco de dados:**

   No terminal do Visual Studio ou usando o CLI do .NET:

   ```
   dotnet ef database update
   ```

5. **Execute o projeto:**

   ```bash
   dotnet run
   ```

6. **O sistema estará disponível no navegador, geralmente em:**

   https://localhost:5001

## 🗂️ Estrutura do Projeto

   ```bash
   SalesWebMvc/
   │
   ├── Controllers/        → Lógica dos controladores MVC
   ├── Models/             → Entidades e modelos de domínio
   ├── Views/              → Páginas Razor (HTML + C#)
   ├── Data/               → Seed e contexto do EF Core
   ├── Services/           → Lógica de negócios separada dos controllers
   ├── wwwroot/            → Arquivos estáticos (CSS, JS, imagens)
   └── appsettings.json    → Configurações do projeto
   ```

## 📚 Créditos

Este projeto foi desenvolvido seguindo o curso:

Nélio Alves - Curso C# Completo Programação Orientada a Objetos + Projetos