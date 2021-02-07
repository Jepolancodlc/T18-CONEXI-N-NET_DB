using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UD18___DBconexion
{
    class Ejercicios
    {

        //Ejercicio 1
        public void e1()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "TiendaInformatica"; //Nombre para la base de datos
            db.Db_CreateDB(nombreDB);   //Creamos la base de datos

            //Tabla fabricantes 
            string nTablaFabricantes = "Fabricantes"; //Nombre de la tabla
            string FabCol = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100)"; //Creacion de columnas que pertenecen a la anterior tabla

            db.DB_CreateTable(nombreDB, nTablaFabricantes, FabCol); //Creamos la tabla

            //Insertamos 5 registros en la tabla fabricantes
            db.insertarValor(nombreDB, nTablaFabricantes, @"('Fab1')");
            db.insertarValor(nombreDB, nTablaFabricantes, @"('Fab2')");
            db.insertarValor(nombreDB, nTablaFabricantes, @"('Fab3')");
            db.insertarValor(nombreDB, nTablaFabricantes, @"('Fab4')");
            db.insertarValor(nombreDB, nTablaFabricantes, @"('Fab5')");


            //Tabla articulos 
            string nTablaArticulos = "Articulos";
            string ArtCol = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100), Precio INT," +
                " Fabricante INT FOREIGN KEY REFERENCES FABRICANTES(Codigo) ON DELETE SET NULL ON UPDATE CASCADE"; //Creacion de columnas que pertenecen a la anterior tabla

            db.DB_CreateTable(nombreDB, nTablaArticulos, ArtCol); //Creamos la tabla

            //Insertamos 5 registros en la tabla articulos
            db.insertarValor(nombreDB, nTablaArticulos, @"('Art1',100, 5)");
            db.insertarValor(nombreDB, nTablaArticulos, @"('Art2',30, 3)");
            db.insertarValor(nombreDB, nTablaArticulos, @"('Art3',65, 3)");
            db.insertarValor(nombreDB, nTablaArticulos, @"('Art4',200, 2)");
            db.insertarValor(nombreDB, nTablaArticulos, @"('Art5',80, 1)");
        }


        //Repeticion del proceso ya menciando e2-e9


        //Ejercio2
        public void e2()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "Empleados"; //Nombre para la base de datos
            db.Db_CreateDB(nombreDB);   //Creamos la base de datos

            //Tabla departamentos 
            string tablaDep = "Departamentos"; //Nombre de la tabla 
            string DepCol = "Codigo INT PRIMARY KEY, Nombre NVARCHAR(100), Presupuesto INT"; //Creacion de columnas que pertenecen a la anterior tabla

            db.DB_CreateTable(nombreDB, tablaDep, DepCol);

                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaDep, @"(1,'Dep2', 100000)");
            db.insertarValor(nombreDB, tablaDep, @"(2,'Dep4', 600010)");
            db.insertarValor(nombreDB, tablaDep, @"(3,'Dep5', 200400)");
            db.insertarValor(nombreDB, tablaDep, @"(4,'Dep1', 400000)");
            db.insertarValor(nombreDB, tablaDep, @"(5,'Dep3', 140600)");

            //Tabla Empleados
            string tablaEmp = "Empleados"; //Nombre de la tabla 
            string EmpCol = "DNI VARCHAR(8) PRIMARY KEY, Nombre NVARCHAR(100), Apellidos NVARCHAR(100), " +
                "Departamento INT FOREIGN KEY REFERENCES DEPARTAMENTOS(Codigo) ON DELETE SET NULL ON UPDATE CASCADE"; //Creacion de columnas que pertenecen a la anterior tabla

            db.DB_CreateTable(nombreDB, tablaEmp, EmpCol);

                //Insertamos 5 registros en la tabla
            db.insertarValor(nombreDB, tablaEmp, @"('A1234567', 'Juan', 'Lopez', 1)");
            db.insertarValor(nombreDB, tablaEmp, @"('B1234567', 'Felipe', 'Dia', 2)");
            db.insertarValor(nombreDB, tablaEmp, @"('C1234567', 'Pedro', 'Loas', 3)");
            db.insertarValor(nombreDB, tablaEmp, @"('D1234567', 'Fran', 'Jumo', 4)");
            db.insertarValor(nombreDB, tablaEmp, @"('E1234567', 'Pablo', 'Marquez', 5)");
        }

        //Ejercico 3
        public void e3()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "LosAlmacenes"; 
            db.Db_CreateDB(nombreDB);   

            //Tabla Almacenes
            string tablaAlm = "Almacenes";
            string AlmCol = "Codigo INT PRIMARY KEY IDENTITY (1,1), Lugar NVARCHAR(100), Capacidad INT";

            db.DB_CreateTable(nombreDB, tablaAlm, AlmCol);

                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaAlm, @"('alm 1', 1200)");
            db.insertarValor(nombreDB, tablaAlm, @"('alm 2', 6010)");
            db.insertarValor(nombreDB, tablaAlm, @"('alm 3', 3020)");
            db.insertarValor(nombreDB, tablaAlm, @"('alm 4', 4000)");
            db.insertarValor(nombreDB, tablaAlm, @"('alm 5', 1400)");

            //Tabla Cajas
            string tablaCaj = "Cajas";
            string CojCol = "NumReferencia CHAR(5) PRIMARY KEY, Contenido NVARCHAR(100), Valor INT, Almacen INT FOREIGN KEY REFERENCES ALMACENES(Codigo) ON DELETE SET NULL ON UPDATE CASCADE";

            db.DB_CreateTable(nombreDB, tablaCaj, CojCol);

                   //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaCaj, @"('42144', 'Con 1', 120, 5)");
            db.insertarValor(nombreDB, tablaCaj, @"('12342', 'Con 2', 60, 4)");
            db.insertarValor(nombreDB, tablaCaj, @"('64231', 'Con 5', 80, 3)");
            db.insertarValor(nombreDB, tablaCaj, @"('92833', 'Con 3', 20, 2)");
            db.insertarValor(nombreDB, tablaCaj, @"('23232', 'Con 4', 100, 1)");
        }

        //Ejercico 4
        public void e4()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "PeliculasYSalas";
            db.Db_CreateDB(nombreDB);


            //Tabla Peliculas
            string tablaPel = "Peliculas";
            string pelCol = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100), CalificacionEdad INT";

            db.DB_CreateTable(nombreDB, tablaPel, pelCol);

                 //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaPel, @"('Pel 1', 12)");
            db.insertarValor(nombreDB, tablaPel, @"('Pel 2', 18)");
            db.insertarValor(nombreDB, tablaPel, @"('Pel 3', 0)");
            db.insertarValor(nombreDB, tablaPel, @"('Pel 4', 12)");
            db.insertarValor(nombreDB, tablaPel, @"('Pel 5', 16)");

            //Tabla salas
            string tablaSal = "Salas";
            string salCol = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100), Pelicula INT FOREIGN KEY REFERENCES PELICULAS(Codigo) ON DELETE SET NULL ON UPDATE CASCADE";

            db.DB_CreateTable(nombreDB, tablaSal, salCol);
                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaSal, @"('Sala 1', 4)");
            db.insertarValor(nombreDB, tablaSal, @"('Sala 2', 3)");
            db.insertarValor(nombreDB, tablaSal, @"('Sala 3', 2)");
            db.insertarValor(nombreDB, tablaSal, @"('Sala 2', 5)");
            db.insertarValor(nombreDB, tablaSal, @"('Sala 5', 1)");
        }

        //Ejercico 5
        public void e5()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "LosDirectores";
            db.Db_CreateDB(nombreDB);


            //Tabla Despacho
            string tablaDes = "Despachos";
            string DeslCol = "Numero INT PRIMARY KEY , Capacidad INT";

            db.DB_CreateTable(nombreDB, tablaDes, DeslCol);

               //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaDes, @"(1, 12)");
            db.insertarValor(nombreDB, tablaDes, @"(2, 10)");
            db.insertarValor(nombreDB, tablaDes, @"(3, 7)");
            db.insertarValor(nombreDB, tablaDes, @"(4, 7)");
            db.insertarValor(nombreDB, tablaDes, @"(5, 7)");

            //Tabla Directores
            string tablaDir = "Directores";
            string DirCol = "DNI VARCHAR(8) PRIMARY KEY, NomApels NVARCHAR(255), DNIJefe VARCHAR(8) FOREIGN KEY REFERENCES DIRECTORES(DNI), Despacho INT FOREIGN KEY REFERENCES DESPACHOS(Numero)";

            db.DB_CreateTable(nombreDB, tablaDir, DirCol);

                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaDir, @"('A1234567', 'Nom 1', 'A1234567', 1)");
            db.insertarValor(nombreDB, tablaDir, @"('B1234567', 'Nom 2', 'A1234567', 5)");
            db.insertarValor(nombreDB, tablaDir, @"('C1234567', 'Nom 3', 'A1234567', 4)");
            db.insertarValor(nombreDB, tablaDir, @"('D1234567', 'Nom 4', 'A1234567', 3)");
            db.insertarValor(nombreDB, tablaDir, @"('E1234567', 'Nom 5', 'A1234567', 2)");
        }

        //Ejercicio 6
        public void e6()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "PiezasProveedores";
            db.Db_CreateDB(nombreDB);


            //Tabla Piezas
            string tablaPiez = "Piezas";
            string PiezaCol = "Codigo INT PRIMARY KEY IDENTITY(1,1) , Nombre NVARCHAR(100)";

            db.DB_CreateTable(nombreDB, tablaPiez, PiezaCol);

                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaPiez, @"('Pieza 1')");
            db.insertarValor(nombreDB, tablaPiez, @"('Pieza 2')");
            db.insertarValor(nombreDB, tablaPiez, @"('Pieza 3')");
            db.insertarValor(nombreDB, tablaPiez, @"('Pieza 4')");
            db.insertarValor(nombreDB, tablaPiez, @"('Pieza 5')");

            //Tabla Proveedor
            string tablaProv = "Proveedores";
            string provCol = "Id char(4) PRIMARY KEY, Nombre NVARCHAR(100)";

            db.DB_CreateTable(nombreDB, tablaProv, provCol);

               //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaProv, @"('1413', 'Proveedor 1')");
            db.insertarValor(nombreDB, tablaProv, @"('3313', 'Proveedor 2')");
            db.insertarValor(nombreDB, tablaProv, @"('7898', 'Proveedor 3')");
            db.insertarValor(nombreDB, tablaProv, @"('3831', 'Proveedor 4')");
            db.insertarValor(nombreDB, tablaProv, @"('6323', 'Proveedor 5')");

            //Tabla Suministra
            string tablaSum = "Suministra";
            string sumCol = "codigoPieza int foreign key references Piezas(Codigo) on delete cascade, " +
                "proveedorID char(4) foreign key references Proveedores(Id)on delete cascade," +
                " precio int, primary key(codigoPieza, proveedorID)";
            db.DB_CreateTable(nombreDB, tablaSum, sumCol);

            //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaSum, @"(1,'1413',700)");
            db.insertarValor(nombreDB, tablaSum, @"(5,'3313',500)");
            db.insertarValor(nombreDB, tablaSum, @"(2,'7898',200)");
            db.insertarValor(nombreDB, tablaSum, @"(4,'3831',100)");
            db.insertarValor(nombreDB, tablaSum, @"(1,'6323',500)");
        }

        //Ejercicio 7

        public void e7()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "Cientificos";
            db.Db_CreateDB(nombreDB);


            //Tabla Cientificos
            string tablaCie = "Cientificos";
            string cieCOl = "dni varchar(8) primary key not null, nomApels nvarchar(255)";

            db.DB_CreateTable(nombreDB, tablaCie, cieCOl);

                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaCie, @"('A1234567','Alejandro')");
            db.insertarValor(nombreDB, tablaCie, @"('E1234567','Juan')");
            db.insertarValor(nombreDB, tablaCie, @"('D1234567','Maria')");
            db.insertarValor(nombreDB, tablaCie, @"('B1234567','Leon')");
            db.insertarValor(nombreDB, tablaCie, @"('C1234567','Marcos')");

            //Tabla Proyecto
            string tablaProy = "ProyectO";
            string ProyCol = "idProyecto char(4) not null primary key, nombre nvarchar, horas int";

            db.DB_CreateTable(nombreDB, tablaProy, ProyCol);

                 //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaProy, @"('pr04','A', 210)");
            db.insertarValor(nombreDB, tablaProy, @"('pr05','B', 160)");
            db.insertarValor(nombreDB, tablaProy, @"('pr02','C', 280)");
            db.insertarValor(nombreDB, tablaProy, @"('pr01','D', 500)");
            db.insertarValor(nombreDB, tablaProy, @"('pr03','E', 320)");

            //Tabla AsignadoA
            string tablaAsig = "Asignado_A";
            string asigCol = "cientificoID varchar(8) foreign key references cientificos(dni) on delete cascade, proyectoID char(4) foreign key references proyecto(idProyecto) on delete cascade,primary key(cientificoID, proyectoID)";

            db.DB_CreateTable(nombreDB, tablaAsig, asigCol);

            //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaAsig, @"('A1234567','pr05')");
            db.insertarValor(nombreDB, tablaAsig, @"('B1234567','pr04')");
            db.insertarValor(nombreDB, tablaAsig, @"('C1234567','pr03')");
            db.insertarValor(nombreDB, tablaAsig, @"('D1234567','pr02')");
            db.insertarValor(nombreDB, tablaAsig, @"('E1234567','pr01')");
        }

        //Ejercicio 8
       public void e8()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "GrandesAlmacenes";
            db.Db_CreateDB(nombreDB);


            //Tabla cajeros
            string tablaCajero = "Cajeros";
            string cajCol = "idCajero int identity(1,1) not null primary key, nomApels nvarchar(255)";

            db.DB_CreateTable(nombreDB, tablaCajero, cajCol);
    
                  //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaCajero, @"('Caja A')");
            db.insertarValor(nombreDB, tablaCajero, @"('Caja B')");
            db.insertarValor(nombreDB, tablaCajero, @"('Caja C')");
            db.insertarValor(nombreDB, tablaCajero, @"('Caja D')");
            db.insertarValor(nombreDB, tablaCajero, @"('Caja E')");

            //Tabla MaquinasReg
            string tablaMaq = "MaquinasRegistradas";
            string MaqCol = "Codigo int identity(1,1) not null primary key, piso int";

            db.DB_CreateTable(nombreDB, tablaMaq, MaqCol);

                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaMaq, @"(1)");
            db.insertarValor(nombreDB, tablaMaq, @"(2)");
            db.insertarValor(nombreDB, tablaMaq, @"(3)");
            db.insertarValor(nombreDB, tablaMaq, @"(4)");
            db.insertarValor(nombreDB, tablaMaq, @"(5)");


            //Tabla Productos
            string tablaPro = "Productos";
            string proCol = " idProducto int identity(1,1) not null primary key, nombre nvarchar(100),precio int";

            db.DB_CreateTable(nombreDB, tablaPro, proCol);

                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaPro, @"('Producto 1' ,25)");
            db.insertarValor(nombreDB, tablaPro, @"('Producto 2' ,42)");
            db.insertarValor(nombreDB, tablaPro, @"('Producto 3' ,125)");
            db.insertarValor(nombreDB, tablaPro, @"('Producto 4' ,53)");
            db.insertarValor(nombreDB, tablaPro, @"('Producto 5' ,34)");


            //Tabla Productos
            string tablaVen = "Venta";
            string venCol = "	cajeroID int foreign key references Cajeros(idCajero) on delete cascade, " +
                "Maquina int foreign key references MaquinasRegistradas(Codigo) on delete cascade," +
                "Producto int foreign key references Productos(idProducto) on delete cascade,	primary key(cajeroID, Maquina, Producto)";

            db.DB_CreateTable(nombreDB, tablaVen, venCol);

            //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaVen, @"(5,1,5)");
            db.insertarValor(nombreDB, tablaVen, @"(4,2,4)");
            db.insertarValor(nombreDB, tablaVen, @"(3,3,3)");
            db.insertarValor(nombreDB, tablaVen, @"(2,4,2)");
            db.insertarValor(nombreDB, tablaVen, @"(1,5,1)");

        }

        //Ejercicio 9
        public void e9()
        {
            //Creacion de base de datos
            Db_Crud db = new Db_Crud();
            string nombreDB = "Investigadores";
            db.Db_CreateDB(nombreDB);

            //Tabla Facultad
            string tablaFac = "Facultad";
            string facCol = "idFacultad int primary key not null, nombre nvarchar(100)";

            db.DB_CreateTable(nombreDB, tablaFac, facCol);

                //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaFac, @"(1 , 'Fac A')");
            db.insertarValor(nombreDB, tablaFac, @"(2 , 'Fac B')");
            db.insertarValor(nombreDB, tablaFac, @"(3 , 'Fac C')");
            db.insertarValor(nombreDB, tablaFac, @"(4 , 'Fac D')");
            db.insertarValor(nombreDB, tablaFac, @"(5 , 'Fac E')");


            //Tabla EQUIPOS
            string tablaEq = "Equipos";
            string eqCol= "numSerie char(4) primary key not null,nombre nvarchar(100), facultadID int foreign key references facultad(idFacultad) on delete cascade";

            db.DB_CreateTable(nombreDB, tablaEq, eqCol);

            //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaEq, @"('e1', 'Equipo A', 1)");
            db.insertarValor(nombreDB, tablaEq, @"('e2', 'Equipo B', 4)");
            db.insertarValor(nombreDB, tablaEq, @"('e3', 'Equipo C', 5)");
            db.insertarValor(nombreDB, tablaEq, @"('e4', 'Equipo D', 2)");
            db.insertarValor(nombreDB, tablaEq, @"('e5', 'Equipo E', 3)");

            //Tabla investigadores
            string tablaIn = "Investigadores";
            string InCol = "dni varchar(8) primary key not null, nomApels nvarchar(255),facultadID int foreign key references Facultad(idFacultad) on delete cascade";

            db.DB_CreateTable(nombreDB, tablaIn, InCol);

            //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaIn, @"('A1234567', 'Alejandro Lopez', 1)");
            db.insertarValor(nombreDB, tablaIn, @"('B1234567', 'Maria Juarez', 2)");
            db.insertarValor(nombreDB, tablaIn, @"('C1234567', 'Jaime Lio', 3)");
            db.insertarValor(nombreDB, tablaIn, @"('D1234567', 'Laia Gil', 4)");
            db.insertarValor(nombreDB, tablaIn, @"('E1234567', 'Juan Deraq', 5)");

            //Tabla reservas
            string tablaRes = "Reserva";
            string resCol = " investigadorDNI varchar(8) foreign key references Investigadores(dni) on delete no action," +
                "equipoNumSerie char(4) foreign key references Equipos(numSerie) on delete no action, comienzo datetime,  fin datetime," +
                "primary key(investigadorDNI, equipoNumSerie)";

            db.DB_CreateTable(nombreDB, tablaRes, resCol);

            //Insertamos 5 registros en la tabla 
            db.insertarValor(nombreDB, tablaRes, @"('A1234567', 'e1', '20200210','20211211')");
            db.insertarValor(nombreDB, tablaRes, @"('B1234567', 'e2', '20200210','20211211')");
            db.insertarValor(nombreDB, tablaRes, @"('C1234567', 'e4', '20200210','20211211')");
            db.insertarValor(nombreDB, tablaRes, @"('D1234567', 'e3', '20200210','20211211')");
            db.insertarValor(nombreDB, tablaRes, @"('E1234567', 'e5', '20200210','20211211')");
        }

    }
}
