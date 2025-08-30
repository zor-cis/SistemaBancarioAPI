create database bakingsys;
use bakingsys;

CREATE TABLE client (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    documentTypeId INT UNIQUE NOT NULL,
    email VARCHAR(150) NOT NULL,
    phone_number INT,
    dateOfBirth DATE,
    password VARCHAR(15)
);

create index cliente_email on client(email);

alter table client drop column phone_number;
alter table client add column phone_number bigint;
alter table client drop column password;
alter table client add column password varchar(255);
alter table client add column age int;