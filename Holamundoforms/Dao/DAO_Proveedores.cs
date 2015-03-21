using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Holamundoforms.Bo;
using Holamundoforms.BD;


namespace Holamundoforms.Dao
{
    class DAO_Proveedores
    {
        //PROPIEDADES
 ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
 DataSet dsProveedores = null;
 string instruccionSQL;
 MySqlCommand comandoMySQL;
 MySqlDataAdapter datAdapterMySQL;
 //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
 public int agregarNuevoRegistro(object elNuevoRegistro)
 {
 //convertimos nuestro objeto generico a uno de la clase
 Cat_proveedores objetoTablaProducto = (Cat_proveedores)elNuevoRegistro;
 //preparamos el commando de MySQL
 comandoMySQL = new MySqlCommand();
 //preparar el dataset
 dsProveedores = new DataSet();
 //preparar el dataAdapter...
 datAdapterMySQL = new MySqlDataAdapter();
 //Establecer la conexion
 comandoMySQL.Connection = oBasedeDatos.miConectorNET;
 oBasedeDatos.establecerConexionNET();
 //ARMAR la instruccion MYSQL: insert
 instruccionSQL = "INSERT INTO cat_proveedores (" +
 "razon_social,rfc, calle, numero_exterior, numero_interiror, referencia,colonia,codigo_postal, municipio,estado, telefono,correo" +
 ") VALUES ( " +
 pcs(objetoTablaProducto.Razon_social) + "," +
 pcs(objetoTablaProducto.Rfc) + "," +
 objetoTablaProducto.Calle.ToString() + "," +
 objetoTablaProducto.Numero_exterior.ToString() + "," + 
 objetoTablaProducto.Num_interior.ToString() + "," +
 pcs(objetoTablaProducto.Referencia) + "," +
 pcs(objetoTablaProducto.Colonia) + ","  +
 objetoTablaProducto.Codigo_postal.ToString() + "," +
 pcs(objetoTablaProducto.Municipio) + "," +
 pcs(objetoTablaProducto.Estado) + "," +
 objetoTablaProducto.Telefono.ToString() + "," +
 pcs(objetoTablaProducto.Correo) +
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
    
