using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using Holamundoforms.BD;
using Holamundoforms.Bo;




namespace Holamundoforms.Dao
{
    class DAO_sucursales
    {
        //PROPIEDADES
 ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
 DataSet dssucursales = null;
 string instruccionSQL;
 MySqlCommand comandoMySQL;
 MySqlDataAdapter datAdapterMySQL;
 //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
 public int agregarNuevoRegistro(object elNuevoRegistro)
 {
 //convertimos nuestro objeto generico a uno de la clase
 Cat_sucursales objetoTablaProducto = (Cat_sucursales)elNuevoRegistro;
 //preparamos el commando de MySQL
 comandoMySQL = new MySqlCommand();
 //preparar el dataset
 dssucursales = new DataSet();
 //preparar el dataAdapter...
 datAdapterMySQL = new MySqlDataAdapter();
 //Establecer la conexion
 comandoMySQL.Connection = oBasedeDatos.miConectorNET;
 oBasedeDatos.establecerConexionNET();
 //ARMAR la instruccion MYSQL: insert
 instruccionSQL = "INSERT INTO cat_sucursal (" +
 "codigo, nombre_sucursal, direccion, responsable" + 
 ") VALUES ( " +
  objetoTablaProducto.Codigo.ToString() + "," +
 pcs(objetoTablaProducto.Nombre_sucursal) + "," +
 pcs(objetoTablaProducto.Direccion) + "," +
pcs(objetoTablaProducto.Responsable) + 
 " ) ";
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
    