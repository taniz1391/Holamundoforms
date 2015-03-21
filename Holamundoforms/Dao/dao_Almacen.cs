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
    class dao_Almacen
    {
        //PROPIEDADES
 ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
 DataSet dsAlmacen = null;
 string instruccionSQL;
 MySqlCommand comandoMySQL;
 MySqlDataAdapter datAdapterMySQL;
 //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
 public int agregarNuevoRegistro(object elNuevoRegistro)
 {
 //convertimos nuestro objeto generico a uno de la clase
Almacen objetoTablaAlmacen = (Almacen)elNuevoRegistro;
 //preparamos el commando de MySQL
 comandoMySQL = new MySqlCommand();
 //preparar el dataset
 dsAlmacen = new DataSet();
 //preparar el dataAdapter...
 datAdapterMySQL = new MySqlDataAdapter();
 //Establecer la conexion 
 comandoMySQL.Connection = oBasedeDatos.miConectorNET;
 oBasedeDatos.establecerConexionNET();
 //ARMAR la instruccion MYSQL: insert
 instruccionSQL = "INSERT INTO almacen(" +
 "num_almacen, cod_producto, cantidad, stock_minimo) VALUES ( " +
 objetoTablaAlmacen.Num_almacen.ToString() + "," +
 pcs(objetoTablaAlmacen.Cod_producto) + "," +
 objetoTablaAlmacen.Cantidad.ToString() + "," +
 objetoTablaAlmacen.Stock_minimo.ToString() + " ) ";
 comandoMySQL.CommandText = instruccionSQL; 
 int resultadodelComando = comandoMySQL.ExecuteNonQuery();
 if (resultadodelComando <= 0)
 {
 return 0; //HAY UN ERROR
 }
 return 1;
 }
 public String pcs(string Valor)
 {
 return "'" + Valor + "'";
 }
 }
}
   