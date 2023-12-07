CREATE TABLE Meta (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Symbol NVARCHAR(255) NOT NULL,
    RegularMarketPrice FLOAT NOT NULL,
    DateTime DATETIME NOT NULL
);