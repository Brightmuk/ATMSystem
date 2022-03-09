var commands = [
    "CREATE TABLE users(FirstName varchar(255) NOT NULL, LastName varchar(255) NOT NULL, IdNumber varchar(255) NOT NULL, KraPin varchar(255) NOT NULL, Pin varchar(255) NOT NULL, DateOfBirth date NOT NULL, PRIMARY KEY(IdNumber));",
        "INSERT INTO users(FirstName, LastName, IdNumber, KraPin, Pin, DateOfBirth) VALUES ('Bright','Mukonesi','37789587','A01649335','1234','2000-10-19');",
    "CREATE TABLE bankAccounts(AccNumber varchar(255), Owner varchar(255), Balance int DEFAULT 0, PRIMARY KEY(AccNumber), FOREIGN KEY(owner) REFERENCES users(IdNumber));",
        "INSERT INTO bankAccounts(AccNumber,Owner,Balance) VALUES ('123456890','37789587', 800000);",
    "CREATE TABLE transactions(TransactionId varchar(255), Owner varchar(255), Type varchar(255), Amount varchar(255), CreationDate datetime DEFAULT CURRENT_TIMESTAMP, PRIMARY KEY(TransactionId), FOREIGN KEY(owner) REFERENCES users(IdNumber));",
        "INSERT INTO transactions(TransactionId, Owner, Type, Amount, Date) VALUES ('001','37789587','Deposit',3000, '2000-10-19');"
]