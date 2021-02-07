using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Microsoft.IdentityModel.Protocols;

namespace UD18___DBconexion
{
    class Db_Crud
    {
        Db_Conexiones dbCon = new Db_Conexiones();

        // Crea una nueva base de datos
        public void Db_CreateDB(string db)
        {
            SqlConnection connection = dbCon.Sv_Conectar();
            string cadena = "CREATE DATABASE " + db;

            try
            {
                SqlCommand command = new SqlCommand(cadena, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Base de datos creada!");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error a la hora de crear la base de datos " + db + ": \n");
                Console.WriteLine(e);
            }

            connection.Close();
        }


        // Crea una nueva tabla 
        public void DB_CreateTable(string db, string nomTabla, string col)
        {
            SqlConnection connection = dbCon.Db_Conectar(db);
            string cadena = "CREATE TABLE " + nomTabla + "(" + col + ")";

            try
            {
                SqlCommand command = new SqlCommand(cadena, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Tabla creada con exito!");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error a la hora de crear la tabla " + nomTabla + ": \n");
                Console.WriteLine(e);
            }

        }

        //Añade un nuevo registro a la tabla asignada
        public void insertarValor(string db, string tabla, string valores)
        {
            SqlConnection connection = dbCon.Db_Conectar(db);
            string cadena = "INSERT INTO " + tabla + " VALUES " + valores;

            try
            {
                SqlCommand command = new SqlCommand(cadena, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Registro insertado con exito!");

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error a la hora de insertar el registro: \n");
                Console.WriteLine(e);
            }
            connection.Close();
        }

        //Consulta datos de una tabla 
        public void consultarDatos(string db, string tabla)
        {
            SqlDataAdapter sqlDA;
            SqlConnection connection = dbCon.Db_Conectar(db);
            string cadena = "SELECT * FROM " + tabla;
            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand command = new SqlCommand(cadena, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                sqlDA = new SqlDataAdapter(command);
                
                Console.WriteLine(dataTable);
            }
            catch (SqlException e)
            {

                Console.WriteLine(e);
            }
            connection.Close();
        }

        //Elimina registros de una base de datos
        public void borrarValor(string db, string tabla, string valores)
        {
            SqlConnection connection = dbCon.Db_Conectar(db);
            string cadena = "Delete from " + tabla + " where " + valores;

            try
            {
                SqlCommand command = new SqlCommand(cadena, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Registro borrado con exito!");

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error a la hora de borrar el regsitro: \n");
                Console.WriteLine(e);
            }
            connection.Close();
        }
    }
}
