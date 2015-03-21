using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Holamundoforms.Bo;
using System.Data;
using Holamundoforms.BD;
using Holamundoforms.Gui;


namespace Holamundoforms.Dao
{
    class DAO_productos
    {
         //propiedades
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsProductos = null;
        string instruccionSQL;
        MySqlCommand comandoMySQL;
        MySqlDataAdapter datAdapterMySQL;

        //Metodo para insertar un nuevo registro en la base de datos 
        public int agregarNuevoRegistro(object elNuevoregistro)
        {// comvertimos nuestro objeto generico a una de la clase
           Productos objetoTablaProducto = (Productos)elNuevoregistro;
            //preparamos el comando de MySQL
            comandoMySQL = new MySqlCommand();
            //preparar el dataset
            dsProductos = new DataSet();

            //preparar el dataAdapter....
            datAdapterMySQL = new MySqlDataAdapter();

            //establecer la conexion
            comandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            //armar la instruccion MySQL: insert
            instruccionSQL = "INSERT INTO cat_productos (" +
                "cod_producto,nombre_completo,precio,costo,fecha_ingreso" +
                ") values (" +
                pcs(objetoTablaProducto.Cod_productos) + "," +
                pcs(objetoTablaProducto.Nombre_completo) + "," +
                objetoTablaProducto.Precio.ToString() + "," +
                objetoTablaProducto.Costo.ToString() + "," + 
                "CURDATE()" +
                ")";
                
               

            comandoMySQL.CommandText = instruccionSQL;
            int resultadodelComando = comandoMySQL.ExecuteNonQuery();
            if (resultadodelComando <= 0)
            {
                return 0;//hay un error
            }
                                

            return 1;
        }

        public string pcs(string Valor)
        {
            return "'" + Valor + "'";
        }
        
    }
}



