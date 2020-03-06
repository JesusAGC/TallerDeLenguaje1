create TABLE Movimientos(
IDMovimiento integer primary key autoincrement,
Cantidad float,
Descripcion TEXT ,
Tipo TEXT,
fecha date,
Usuario text 
);
create table Usuarios(
ID INTEGER PRIMARY KEY AUTOINCREMENT,
Usuario text,
Nombre text,
Email text
);

insert into Usuarios(ID,Usuario,Nombre,Email)values(1,'Default','Usuario0','testmail@mail.com');
