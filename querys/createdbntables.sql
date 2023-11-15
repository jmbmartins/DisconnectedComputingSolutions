CREATE TABLE Cliente (
    ClienteId INT PRIMARY KEY,
    Nome VARCHAR(255),
    Morada VARCHAR(255)
);

CREATE TABLE Produto (
    ProdutoId INT PRIMARY KEY,
    Designacao VARCHAR(255),
    Preco DECIMAL(10, 2),
    QtdStock INT,
    QtdEncomendado INT
);

CREATE TABLE Encomenda (
    EncId INT PRIMARY KEY,
    ClienteId INT,
    Data DATE,
    Total DECIMAL(10, 2),
    FOREIGN KEY (ClienteId) REFERENCES Cliente(ClienteId)
);

CREATE TABLE LinhaEnc (
    EncId INT,
    ProdutoId INT,
    Qtd INT,
    PRIMARY KEY (EncId, ProdutoId),
    FOREIGN KEY (EncId) REFERENCES Encomenda(EncId),
    FOREIGN KEY (ProdutoId) REFERENCES Produto(ProdutoId)
);

