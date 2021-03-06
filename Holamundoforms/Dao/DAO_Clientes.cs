﻿using System;
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
    class DAO_Clientes
    {
        //PROPIEDADES
 ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
 DataSet dsClientes = null;
 string instruccionSQL;
 MySqlCommand comandoMySQL;
 MySqlDataAdapter datAdapterMySQL;
 //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS
 public int agregarNuevoRegistro(object elNuevoRegistro)
 {
 //convertimos nuestro objeto generico a uno de la clase
 Cat_clientes objetoTablaProducto = (Cat_clientes)elNuevoRegistro;
 //preparamos el commando de MySQL
 comandoMySQL = new MySqlCommand();
 //preparar el dataset
 dsClientes = new DataSet();
 //preparar el dataAdapter...
 datAdapterMySQL = new MySqlDataAdapter();
 //Establecer la conexion
 comandoMySQL.Connection = oBasedeDatos.miConectorNET;
 oBasedeDatos.establecerConexionNET();
 //ARMAR la instruccion MYSQL: insert
 instruccionSQL = "INSERT INTO cat_clientes (" +
 "razon_social, rfc, calle, numero_exterior, numero_interiror, referencia, colonia, codigo_postal, municipio, estado, correo,telefono" 
 + ") VALUES ( " +
 pcs(objetoTablaProducto.Razon_social) + "," +
 pcs(objetoTablaProducto.Rfc) + "," +
 objetoTablaProducto.Calle.ToString() + "," +
 objetoTablaProducto.Numero_exterior.ToString() + "," +
 objetoTablaProducto.Numero_interior1.ToString() + "," +
 pcs(objetoTablaProducto.Referencia) + "," +
 pcs(objetoTablaProducto.Colonia) + "," +
 objetoTablaProducto.Codigo_postal.ToString() + "," +
 pcs(objetoTablaProducto.Municipio) + "," +
 pcs(objetoTablaProducto.Estado) + "," +
 pcs(objetoTablaProducto.Correo) + "," +
 objetoTablaProducto.Telefono.ToString() + 
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
  