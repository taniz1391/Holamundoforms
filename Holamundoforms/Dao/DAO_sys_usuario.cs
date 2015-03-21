using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Holamundoforms.Bo;
using Holamundoforms.BD;
using MySql.Data;
using System.Data;

namespace Holamundoforms.Dao
{
    class DAO_sys_usuario
    {//PROPIEDADES
 ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
 DataSet dssys_usuarios = null;
 string instruccionSQL;
 MySqlCommand comandoMySQL;
 MySqlDataAdapter datAdapterMySQL;
 //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
 public int agregarNuevoRegistro(object elNuevoRegistro)
 {
 //convertimos nuestro objeto generico a uno de la clase
sys_usuarios objetoTablaProducto = (sys_usuarios)elNuevoRegistro;
 //preparamos el commando de MySQL
 comandoMySQL = new MySqlCommand();
 //preparar el dataset
 dssys_usuarios = new DataSet();
 //preparar el dataAdapter...
 datAdapterMySQL = new MySqlDataAdapter();
 //Establecer la conexion
 comandoMySQL.Connection = oBasedeDatos.miConectorNET;
 oBasedeDatos.establecerConexionNET();
 //ARMAR la instruccion MYSQL: insert
 instruccionSQL = "INSERT INTO sys_usuarios  (" +
     "usuario,contrasenia,nombre_completo,tipo_usuario" 
     + ") VALUES ( " +
 pcs(objetoTablaProducto.Usuario) + "," +
 pcs(objetoTablaProducto.Contrasenia) + "," +
 pcs(objetoTablaProducto.Nombre_completo) + "," +
 pcs(objetoTablaProducto.Tipo_usuario) +  
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
    

