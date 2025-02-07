# 🎬 Sistema de Avaliação de Filmes com Windows Forms, C# e MySQL

## 📌 Sobre o Projeto
Este projeto é um sistema de avaliação de filmes desenvolvido em **C# (Windows Forms)**, utilizando o padrão **Domain-Driven Design (DDD)**, estilizado com **Realtaizor** e integrado ao **MySQL**. O objetivo é permitir que usuários avaliem filmes, armazenando notas e comentários.

## 🛠 Tecnologias Utilizadas
- **C#** (.NET Framework)
- **Windows Forms**
- **Domain-Driven Design (DDD)**
- **Realtaizor** (Biblioteca de UI)
- **MySQL** (Banco de dados relacional)
- **MySQL Workbench** (Gerenciador de banco de dados)
- **Entity Framework** (ORM para manipulação do banco de dados)

## 🎯 Estrutura do Projeto (DDD)
O projeto segue o padrão **DDD**, sendo dividido nas seguintes camadas:

📂 **ProjetoRaiz**
   - 📂 **Domain** (Regras de negócio)
     - 📂 Entities (Entidades do domínio)
     - 📂 Interfaces (Interfaces para os repositórios)
   - 📂 **Application** (Lógica de aplicação)
     - 📂 Services (Serviços para manipulação de dados)
   - 📂 **Infrastructure** (Acesso a dados e persistência)
     - 📂 Repositories (Implementação dos repositórios)
     - 📂 Context (Contexto do banco de dados via EF)
   - 📂 **Presentation** (Interface gráfica - Windows Forms)
     - 📂 Views (Formulários e componentes visuais)
     - 📂 Controls (Componentes customizados com Realtaizor)

## 📂 Modelagem do Banco de Dados
A estrutura do banco de dados contém as seguintes tabelas:

```sql
CREATE TABLE Categorias (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL
);

CREATE TABLE Usuarios (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    senha VARCHAR(255) NOT NULL,
    fotousuario BLOB 
);

CREATE TABLE Filmes (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(255) NOT NULL,
    descricao TEXT,
    ano_lancamento YEAR,
    duracao INT,  
    id_categoria INT,  
    imagemfilme BLOB, 
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id)
);

CREATE TABLE Avaliacoes (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_filme INT,
    id_usuario INT,
    nota INT CHECK (nota >= 1 AND nota <= 5),  
    comentario TEXT,
    data_avaliacao DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (id_filme) REFERENCES Filmes(id),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id)
);
```

## 📦 Configuração do Ambiente
### 🔹 Pré-requisitos
Antes de rodar o projeto, certifique-se de ter instalado:
- **.NET Framework** compatível com Windows Forms
- **Visual Studio** (com suporte a Windows Forms e .NET)
- **MySQL Server** e **MySQL Workbench**
- **Entity Framework** (NuGet Package)
- **Realtaizor** (NuGet Package)

### 🔹 Configuração do Banco de Dados
1. Abra o **MySQL Workbench** e crie o banco de dados conforme o script acima.
2. Configure a string de conexão no arquivo `app.config` do projeto Windows Forms:
   ```xml
   <connectionStrings>
       <add name="MySqlConnection" connectionString="server=localhost;database=NomeDoBanco;uid=root;pwd=senha;" providerName="MySql.Data.MySqlClient" />
   </connectionStrings>
   ```
3. Utilize as migrations do **Entity Framework** para criar as tabelas automaticamente:
   ```sh
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## 🚀 Executando o Projeto
1. Clone este repositório:
   ```sh
   git clone https://github.com/seu-usuario/nome-do-repo.git
   ```
2. Abra o projeto no **Visual Studio**.
3. Configure a **string de conexão** corretamente.
4. Compile e execute a aplicação.

## 📌 Funcionalidades Implementadas
✅ Cadastro e gerenciamento de categorias de filmes  
✅ Cadastro de usuários com senha protegida  
✅ CRUD de filmes com imagens  
✅ Sistema de avaliações com notas e comentários  
✅ Interface estilizada com **Realtaizor**  
✅ Persistência dos dados via **Entity Framework** e **MySQL**  

## 📄 Licença
Este projeto é acadêmico e pode ser utilizado para fins educacionais.

---

📧 **Contato:** Se tiver dúvidas ou sugestões, entre em contato!

