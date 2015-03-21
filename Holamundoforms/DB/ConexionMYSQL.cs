using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace Holamundoforms.BD
{
    class ConexionMYSQL
    {
        //propiedad
        public MySqlConnection miConectorNET = new MySqlConnection();
        public ADODB.Connection miConectorODBC = new ADODB.Connection();


        public string MYSQL_CONEXION_NET = "Server=localhost; User ID=root; Password=root;" + "Persist Security info=true; Database=pvpatolin";

        public string MYSQL_CONEXION_ODBC = "Driver={MySQL ODBC 5.3}; Server=localhost;" + "User=vendedor; Password=vendedor; Database=pvpatolin;" + "Opcion=3;";

        //metodo constructor

        public ConexionMYSQL()
        { }

        //METODO PARA CONECTARNOS CON LA LIBRERIA MYSQL.DATA
        public void establecerConexionNET()
        {
            miConectorNET.ConnectionString = MYSQL_CONEXION_NET;
            miConectorNET.Open();
        }
        public void cerrarConexionNET()
        {
            miConectorNET.Close();

        }     //METODO PARA CONECTARNOS  CON LA LIBRERIA ADOBD






        public void establecerConexionODBC()
        {
            miConectorODBC.ConnectionString = MYSQL_CONEXION_ODBC;
            miConectorODBC.Open(null, null, null, 0);

        }
        public void cerrarConexionODBC()
        {
            miConectorODBC.Close();

        }

        //METODO QUE VERIFICQUE SI EXISTE UNA INFORMACION EN LA TABLA 
        // DE LA BASE DE DATOS


        public bool MYSQL_EXISTE_DATO(string instruccionSQL)
        {
            this.establecerConexionODBC();

            bool functionReturnValue = false;
            ADODB.Recordset rst = new ADODB.Recordset();
            rst.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            try
            {
                rst.Open(instruccionSQL, MYSQL_CONEXION_ODBC, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);
                if (!rst.EOF)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
                rst.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            rst = null;
            this.cerrarConexionODBC();
            return functionReturnValue;

        }
    }
}
          

          
         


  
      
      

    
    
      
  
     

    
    


   
         