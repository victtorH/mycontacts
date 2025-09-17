# mycontacts

**MyContacts** é uma aplicação web de gerenciamento de contatos desenvolvida em **ASP.NET Core MVC**. O projeto permite a criação, visualização, edição e exclusão de contatos, utilizando o **Entity Framework Core** para a persistência de dados em um banco de dados **SQL Server**.

<br>

## Funcionalidades 😂

- **Listagem de Contatos**: Exibe uma lista de todos os contatos cadastrados.
- **Adicionar Novo Contato**: Permite ao usuário adicionar um novo contato com informações como nome, e-mail e telefone.
- **Edição de Contato**: Possibilita a atualização dos dados de um contato existente.
- **Remoção de Contato**: Funcionalidade para excluir um contato do sistema.
<br>
<br>

## Tecnologias Utilizadas
>[!TIP]
O projeto foi construído com as seguintes tecnologias e bibliotecas:
<br>

- **ASP.NET Core MVC**: Framework para construção da aplicação web.

- **.NET 8.0**: Versão do framework.
- **Microsoft.EntityFrameworkCore**: ORM (Object-Relational Mapper) para interação com o banco de dados.

- **Microsoft.EntityFrameworkCore.SqlServer**: Provedor de banco de dados para SQL Server.

- **SQL Server**: Sistema de gerenciamento de banco de dados relacional.
<br>
<br>

## Pré-requisitos

>[!WARNING]
Para rodar o projeto localmente, você precisa ter o seguinte instalado:

- **do .NET 8.0**

- **SQL Server**
<br>
<br>

## Configuração e Execução
>[!important]
Siga os passos abaixo para configurar e executar o projeto em sua máquina:
<br>

1. **Clone o repositorio:**
    
 <sub>Bash</sub>
```
git clone https://github.com/victtorH/mycontacts.git
cd mycontacts
```
<br>

2. **Configurar o Banco de Dados:**

- Abra o arquivo `appsettings.json`
- Para apontar ao seu servidor e banco de dados basta **Altere a string de conexão** como no exemplo `SEU_SERVIDOR` e `SEU_BANCO_DE_DADOS`.
  <br>
  
 <sub>JSON</sub>
```
"ConnectionStrings": {
"Database": "Server=SEU_SERVIDOR;Database=SEU_BANCO_DE_DADOS;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
- O projeto utiliza migrações do Entity Framework. Execute os comandos abaixo no terminal, na pasta do projeto, para criar o banco de dados e as tabelas:
<br>

 <sub>Bash</sub>
```
dotnet ef database update
```
<br>

3. **Executar a Aplicação:**

- Rode o projeto a partir da linha de comando:
   <br>

<sub>Bash</sub> 
```
dotnet run
```
<br>

- A aplicação será iniciada e o endereço para acesso estará disponível no terminal (geralmente `https://localhost:7xxx`).
<br><br>

  ## Arquitetura do Projeto
  - `CreatedMVC.csproj`: Contém a string de conexão para o banco de dados, que é configurada para o SQL Server.
  - `Program.cs`: Ponto de entrada da aplicação. Ele configura os serviços da aplicação, injeta o contexto do banco de dados (`BancoContext`) e o repositório (`ContatoRepositorio`). A string de conexão do `appsettings.json` é utilizada para configurar o contexto do banco de dados.
    
