create database proyecto1_taller
use proyecto1_taller

create table profesion(
id_profesion varchar(3)  primary key,
profesion varchar(100)
) 
create table cliente(
rut numeric(9)primary key,
nombre varchar(100),
apellido1 varchar(100),
apellido2 varchar(100),
fecha_nacimiento date,
sueldo_liquido numeric(10),
profesion varchar (100),
edad int
)
create table tipos_de_creditos(
codigo varchar(5) primary key,
nombre_credito varchar(100),
tasa_interes numeric(6),
edad_maxima int,
monto_minimo int,
monto_maximo int,
sueldo_minimo int
)
 create table creditos_solicitados (
 codigo_solicitud int  identity (1,1) primary key,
codigo varchar(5) foreign key references   tipos_de_creditos(codigo),
 monto_solicitado int,
 plazo_pago numeric(4),
 )
 create table credito_cliente(
  codigo_solicitud int  identity (1,1),
   rut numeric(9) foreign key references cliente(rut),
 )
select * from tipos_de_creditos
 --comandos de conexion 
"select id_profesion, profesion  from profesion"
"insert cliente (sueldo_liquido,rut,nombre,apellido1,apellido2,fecha_nacimiento,id_profesion) values ('" + sueldo + "','" + Rut + "', '" + Nombre + "','" + Apellido1 + "',   '" + Apellido2 + "',  '" + fechanacimiento + "',   '" + profesion + "'      )";
"insert tipos_de_creditos (codigo,nombre_credito,tasa_interes,edad_maxima,monto_minimo,monto_maximo,sueldo_minimo) values ('" + codigo + "','" + nombre + "','" + tasainteres + "','" + edadmaxima + "','" + montominimo + "','" + montomaximo + "','" + sueldominimo + "')";
"select sueldo_minimo, edad_maxima, monto_minimo, monto_maximo from tipos_de_creditos where nombre_credito= " + tipocredito + " ";

UPDATE cliente SET edad = DATEDIFF(YEAR, fecha_nacimiento, GETDATE()) -  CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, fecha_nacimiento, GETDATE()), fecha_nacimiento) > GETDATE() THEN 1 ELSE 0 END;

 insert into profesion (profesion,id_profesion)
values ('Actuaci�n y Teatro',1),
('Administraci�n de Empresas e Ing. Asociadas',2),
('Administraci�n Gastron�mica',3),
('Administraci�n P�blica',4),
('Administraci�n P�blica Antropolog�a',5),
('Administraci�n Tur�stica y Hotelera',6),
('Agronom�a',7),
('Analista Qu�mico',8),
('Arquitectura',9),
('Artes y Licenciatura en Artes',10),
('Bibliotecolog�a',11),
('Biolog�a Marina y Ecolog�a Marina',12),
('Bioqu�mica',13),
('Ciencias Pol�ticas',14),
('Comunicaci�n Audiovisual y/o Multimedia',15),
('Construcci�n Civil',16),
('Contador Auditor',17),
('Derecho',18),
('Dise�o',19),
('Dise�o de Ambientes e Interiores',20),
('Dise�o de Vestuario',21),
('Dise�o Gr�fico',22),
('Dise�o Industrial',23),
('Enfermer�a',24),
('Fonoaudiolog�a',25),
('Fotograf�a',26),
('Geograf�a',27),
('Geolog�a',28),
('Ingenier�a Agr�cola',29),
('Ingenier�a Civil Ambiental',30),
('Ingenier�a Civil El�ctrica',31),
('Ingenier�a Civil Electr�nica',32),
('Ingenier�a Civil en Biotecnolog�a y/o Bioingenier�a',33),
('Ingenier�a Civil en Computaci�n e Inform�tica',34),
('Ingenier�a Civil en Minas',35),
('Ingenier�a Civil en Obras Civiles',36),
('Ingenier�a Civil Industrial',37),
('Ingenier�a Civil Mec�nica',38),
('Ingenier�a Civil Metal�rgica',39),
('Ingenier�a Civil Qu�mica',40),
('Ingenier�a Civil, plan com�n y licenciatura en Ciencias de la Ingenier�a',41),
('Ingenier�a Comercial',42),
('Ingenier�a en Acuicultura y Pesca',43),
('Ingenier�a en Alimentos',44),
('Ingenier�a en Automatizaci�n, Instrumentaci�n y Control',45),
('Ingenier�a en Biotecnolog�a y Bioingenier�a',46),
('Ingenier�a en Comercio Exterior',47),
('Ingenier�a en Computaci�n e Inform�tica',48),
('Ingenier�a en Conectividad y Redes',49),
('Ingenier�a en Construcci�n',50),
('Ingenier�a en Control de Gesti�n',51),
('Ingenier�a en Electricidad',52),
('Ingenier�a en Electr�nica',53),
('Ingenier�a en Finanzas',54),
('Ingenier�a en Geomensura y Cartograf�a',55),
('Ingenier�a en Gesti�n P�blica',56),
('Ingenier�a en Log�stica',57),
('Ingenier�a en Marketing',58),
('Ingenier�a en Matem�tica y Estad�stica',59),
('Ingenier�a en Mec�nica Automotriz',60),
('Ingenier�a en Medio Ambiente',61),
('Ingenier�a en Minas y Metalurgia',62),
('Ingenier�a en Prevenci�n de Riesgos',63),
('Ingenier�a en Qu�mica',64),
('Ingenier�a en Recursos Humanos',65),
('Ingenier�a en Recursos Renovables',66),
('Ingenier�a en Sonido',67),
('Ingenier�a en Telecomunicaciones',68),
('Ingenier�a en Transporte y Tr�nsito',69),
('Ingenier�a Forestal',70),
('Ingenier�a Industrial',71),
('Ingenier�a Marina y Mar�timo Portuaria',72),
('Ingenier�a Mec�nica',73),
('Kinesiolog�a',74),
('Licenciatura en Letras y Literatura',75),
('Matem�ticas y/o Estad�sticas',76),
('Medicina',77),
('Medicina Veterinaria',78),
('M�sica, Canto o Danza',79),
('Nutrici�n y Diet�tica',80),
('Obstetricia y Puericultura',81),
('Odontolog�a',82),
('Orientaci�n Familiar y Relaciones Humanas',83),
('Pedagog�a en Artes y M�sica',84),
('Pedagog�a en Ciencias',85),
('Pedagog�a en Educaci�n B�sica',86),
('Pedagog�a en Educaci�n de P�rvulos',87),
('Pedagog�a en Educaci�n Diferencial',88),
('Pedagog�a en Educaci�n F�sica',89),
('Pedagog�a en Filosof�a y Religi�n',90),
('Pedagog�a en Historia, Geograf�a y Ciencias Sociales',91),
('Pedagog�a en Ingl�s',92),
('Pedagog�a en Lenguaje, Comunicaci�n y/o Castellano',93),
('Pedagog�a en Matem�ticas y Computaci�n',94),
('Periodismo',95),
('Psicolog�a',96),
('Psicopedagog�a',97),
('Publicidad',98),
('Qu�mica Ambiental',99),
('Qu�mica y Farmacia',100),
('Qu�mica, Licenciado en Qu�mica',101),
('Realizador de Cine y Televisi�n',102),
('Relaciones P�blicas',103),
('Sociolog�a',104),
('Tecnolog�a M�dica',105),
('Terapia Ocupacional',106),
('Trabajo Social',107),
('Sin profesion o tiene oficio',108)