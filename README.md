# Query per creare e popolare il database 

CREATE TABLE Anagrafica (
    IdAnagrafica INT PRIMARY KEY AUTO_INCREMENT,
    Cognome NVARCHAR(50),
    Nome NVARCHAR(50),
    Indirizzo NVARCHAR(50),
    Città NVARCHAR(50),
    CAP NVARCHAR(5),
    CodFisc NVARCHAR(16)
);


CREATE TABLE Violazione (
    IdViolazione INT PRIMARY KEY AUTO_INCREMENT,
    Descrizione NVARCHAR(MAX)
);


CREATE TABLE Verbale (
    IdVerbale INT PRIMARY KEY AUTO_INCREMENT,
    IdViolazione INT,
    IdAnagrafica INT,
    DataViolazione DATETIME,
    IndirizzoViolazione NVARCHAR(50),
    NominativoAgente NVARCHAR(50),
    DataTrascrizioneVerbale DATETIME,
    Importo MONEY,
    DecurtamentoPunti INT,
    FOREIGN KEY (IdViolazione) REFERENCES Violazione(IdViolazione),
    FOREIGN KEY (IdAnagrafica) REFERENCES Anagrafica(IdAnagrafica)
);


INSERT INTO Anagrafica (Cognome, Nome, Indirizzo, Città, CAP, CodFisc)
VALUES
    ('Rossi', 'Mario', 'Via Roma 12', 'Milano', '20123', 'RSSMRA99M99L999X'),
    ('Verdi', 'Anna', 'Via Verdi 10', 'Firenze', '50123', 'VRDAAN99F99L999X'),
    ('Bianchi', 'Luca', 'Via Cavour 3', 'Napoli', '80134', 'BNCLCA99M99L999X'),
    ('Esposito', 'Maria', 'Via Dante 5', 'Torino', '10123', 'SPRMEA99F99L999X'),
    ('Romano', 'Francesco', 'Via Garibaldi 2', 'Palermo', '90134', 'RMNFRC99M99L999X'),
    ('Colombo', 'Giuseppe', 'Via Mazzini 4', 'Genova', '16123', 'CLMBGP99M99L999X'),
    ('Cesare', 'Giulio', 'Viale Mentana 34', 'Parma', '43120', 'CSRGL45DFVVSAKSX');

INSERT INTO Verbale (IdViolazione, IdAnagrafica, DataViolazione, IndirizzoViolazione, NominativoAgente, DataTrascrizioneVerbale, Importo, DecurtamentoPunti)
VALUES
    (1, 1, '2024-02-29 09:00:00.000', 'Viale Mazzini 45', 'Marco Lombardi', '2024-03-01 10:00:00.000', 160.00, 3),
    (2, 2, '2024-02-28 11:00:00.000', 'Via Toledo 154', 'Sofia Esposito', '2024-03-01 00:00:00.000', 323.00, 6),
    (3, 3, '2024-02-27 12:00:00.000', 'Via Dante Alighieri 2', 'Anna Ferrari', '2024-02-28 15:00:00.000', 41.00, 2),
    (4, 4, '2024-02-26 08:00:00.000', 'Piazza del Campo 3', 'Luca Rossi', '2024-02-28 14:00:00.000', 168.00, 4),
    (5, 5, '2024-02-25 00:00:00.000', 'Via Garibaldi 27', 'Sofia Esposito', '2024-02-26 10:30:00.000', 532.00, 10),
    (6, 5, '2024-02-27 13:00:00.000', 'Via Vittorio Emanuele 55', 'Luca Rossi', '2024-03-01 08:00:00.000', 50.00, 3),
    (7, 7, '2024-02-24 11:30:00.000', 'Piazza Garibaldi 1', 'Marco Lombardi', '2024-02-28 12:00:00.000', 157.00, 5),
    (8, 2, '2024-02-23 13:00:00.000', 'Piazzale Corridoni 1', 'Sofia Esposito', '2024-02-24 08:00:00.000', 630.00, 12);

INSERT INTO Violazione (Descrizione)
VALUES
    ('Eccesso di velocità'),
    ('Sorpasso Vietato'),
    ('Sosta Vietata'),
    ('Revisione Scaduta'),
    ('Guida in stato di ebrezza'),
    ('Possesso di sostanze stupefacenti');

