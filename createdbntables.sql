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

-- Inserting dummy data
INSERT INTO Cliente VALUES (1, 'John Doe', '123 Main St');
INSERT INTO Produto VALUES (1, 'Product A', 9.99, 100, 0);
INSERT INTO Encomenda VALUES (1, 1, CURDATE(), 0.00);
INSERT INTO LinhaEnc VALUES (1, 1, 1);