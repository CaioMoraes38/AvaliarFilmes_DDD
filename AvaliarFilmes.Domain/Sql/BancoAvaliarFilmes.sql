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