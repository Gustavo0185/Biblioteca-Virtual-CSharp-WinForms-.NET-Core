CREATE TABLE tbleditoras
(
    ediid int PRIMARY KEY,
    edinome varchar(50),
    edisigla varchar(50),
    ediobservacoes varchar(500)
);


CREATE TABLE tbllivros
(
    livid int PRIMARY KEY,
    livnome varchar(50),
    livanopublicacao int,
    livisbn decimal(14),
    livobservacoes varchar(500),
    ediid int,
    FOREIGN KEY (ediid) REFERENCES tbleditoras(ediid)
);


CREATE TABLE tblautores
(
    autid int PRIMARY KEY,
    autnome varchar(50),
    aupseudonimo varchar(50),
    autobservacoes varchar(500)
);


create table tblautliv 
(
Clivid int foreign key (Clivid) references tbllivros(livid),
Cautid int foreign key (Cautid) references tblautores(autid)
);

CREATE TABLE Usuarios
(
    Username varchar (50)  PRIMARY KEY,
    Password varchar(50),
 
);

