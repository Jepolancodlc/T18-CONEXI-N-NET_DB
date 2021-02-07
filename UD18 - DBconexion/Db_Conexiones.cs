using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UD18___DBconexion
{
    class Db_Conexiones
    {
        SqlConnection conexion;

        //Establece la conexion con el servidor y la base de datos asignada por parametros.
        public SqlConnection Db_Conectar(string db)
        {

            conexion = new SqlConnection("Data Source=192.168.1.142; Initial Catalog=" + db + "; Persist Security Info=True; User ID=admin; Password=1qazxsw2");

            try
            {
                conexion.Open();
                Console.WriteLine("Conexion con la base de datos completada con exito!");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }

            return conexion;
        }


        //Establece conexion con el servidor, sin base de datos asignada.
        public SqlConnection Sv_Conectar()
        {

            conexion = new SqlConnection("Data Source=192.168.1.142; Persist Security Info=True; User ID=admin; Password=1qazxsw2");
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion con el servidor completada con exito!");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Fallo");
            }
            return conexion;
        }


        //Cierra la conexion con el servidor
        public void Sv_Desconectar()
        {
            try
            {
                this.conexion.Close();
                Console.WriteLine("Se cerró la conexión con el servidor exitosamente");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Fallo");
            }

        }
    }
}
