CREATE TABLE Socio(
    scod char(5) CONSTRAINT cp_socio PRIMARY KEY DEFERRABLE,
    nombre varchar2(60),
    direccion varchar2(50),
    tel varchar2(20)
);

CREATE TABLE Libro(
    lcod char(5) CONSTRAINT cp_libro PRIMARY KEY DEFERRABLE,
    titulo varchar2(100),
    tematica varchar2(15) CONSTRAINT r1_tematica check(tematica in('fisica', 'electricidad','mecánica', 'óptica')) DEFERRABLE
);

CREATE TABLE Autores(
    lcod char(5) CONSTRAINT ca_autores_libro REFERENCES Libro(lcod) DEFERRABLE,
    autor varchar2(40),
    CONSTRAINT cp_autores PRIMARY KEY (lcod, autor) DEFERRABLE
);

CREATE TABLE Prestamo(
    scod char(5) CONSTRAINT ca_prestamo_socio REFERENCES Socio(scod) DEFERRABLE CONSTRAINT scod_nulo NOT NULL DEFERRABLE,
    lcod char(5) CONSTRAINT ca_prestamo_libro REFERENCES Libro(lcod) DEFERRABLE,
    fecha_pre DATE,
    fecha_dev DATE,
    CONSTRAINT cp_prestamo PRIMARY KEY (scod, lcod) DEFERRABLE,
    CONSTRAINT r2 check((fecha_dev IS NULL) OR (fecha_dev > fecha_pre))
);

COMMIT;

set constraint ca_prestamo_socio deferred;
update socio set scod = 's5' where scod = 's1' ;
update prestamo set scod = 's5' where scod = 's1';
COMMIT;

