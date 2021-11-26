using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;


namespace Web.Logica.Clases
{
    class clsPruebas
    {
        string stConexion = "";
        SqlCommand sqlcomand = null; //permite ejecutar un comando sql ya sea un query o un procedimiento almacenado
        SqlConnection sqlconnection = null; // permite establecer conexion con servidor de base de datos
        SqlParameter sqlparameter = null; // permite manejar los parametros a nivel de procedimiento almacenados
        SqlDataAdapter sqladapter = null; // adapta un origen de dato, ejemplo dataset o data table


        public clsPruebas()
        {
            Web.Clases.clsConexion objconexion = new Web.Clases.clsConexion();
            stConexion = objconexion.stGetConexion();
        }

        public DataSet mostrarPruebas()
        {
            try
            {
                DataSet dsconsulta = new DataSet();

                sqlconnection = new SqlConnection(stConexion);
                sqlconnection.Open();

                sqlcomand = new SqlCommand("", sqlconnection);
                sqlcomand.CommandType = CommandType.Text;
                sqlcomand.CommandText = "SELECT * FROM tbpruebas";
                sqlcomand.ExecuteNonQuery();
                sqladapter = new SqlDataAdapter(sqlcomand);
                sqladapter.Fill(dsconsulta);

                return dsconsulta;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        public DataSet stconsultarPruebas(string id)
        {
            try
            {
                DataSet dsconsulta = new DataSet();

                sqlconnection = new SqlConnection(stConexion);
                sqlconnection.Open();

                sqlcomand = new SqlCommand("spConsultarPrueba", sqlconnection);
                sqlcomand.CommandType = CommandType.StoredProcedure;

                sqlcomand.Parameters.Add(new SqlParameter("@id", id));

                sqlcomand.ExecuteNonQuery();
                sqladapter = new SqlDataAdapter(sqlcomand);
                sqladapter.Fill(dsconsulta);

                return dsconsulta;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        public string stInsertarPruebas(string name, int age)
        {
            try
            {


                sqlconnection = new SqlConnection(stConexion);
                sqlconnection.Open();

                sqlcomand = new SqlCommand("spInsertarPrueba", sqlconnection);
                sqlcomand.CommandType = CommandType.StoredProcedure;

                sqlcomand.Parameters.Add(new SqlParameter("@name", name));
                sqlcomand.Parameters.Add(new SqlParameter("@age", age));

                sqlparameter = new SqlParameter();
                sqlparameter.ParameterName = "@mensaje";
                sqlparameter.SqlDbType = SqlDbType.VarChar;
                sqlparameter.Size = 100;
                sqlparameter.Direction = ParameterDirection.Output;

                sqlcomand.Parameters.Add(sqlparameter);
                sqlcomand.ExecuteNonQuery();

                return sqlparameter.Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        public string stModificarPruebas(string id, string name, int age)
        {
            try
            {


                sqlconnection = new SqlConnection(stConexion);
                sqlconnection.Open();

                sqlcomand = new SqlCommand("spModificarClientes", sqlconnection);
                sqlcomand.CommandType = CommandType.StoredProcedure;

                sqlcomand.Parameters.Add(new SqlParameter("@id", id));
                sqlcomand.Parameters.Add(new SqlParameter("@nombre", name));
                sqlcomand.Parameters.Add(new SqlParameter("@apellidos", age));

                sqlparameter = new SqlParameter();
                sqlparameter.ParameterName = "@mensaje";
                sqlparameter.SqlDbType = SqlDbType.VarChar;
                sqlparameter.Size = 100;
                sqlparameter.Direction = ParameterDirection.Output;

                sqlcomand.Parameters.Add(sqlparameter);
                sqlcomand.ExecuteNonQuery();

                return sqlparameter.Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlconnection.Close();
            }
        }
        public string stEliminarPruebas(string id)
        {
            try
            {


                sqlconnection = new SqlConnection(stConexion);
                sqlconnection.Open();

                sqlcomand = new SqlCommand("spEliminarPrueba", sqlconnection);
                sqlcomand.CommandType = CommandType.StoredProcedure;

                sqlcomand.Parameters.Add(new SqlParameter("@id", id));

                sqlparameter = new SqlParameter();
                sqlparameter.ParameterName = "@mensaje";
                sqlparameter.SqlDbType = SqlDbType.VarChar;
                sqlparameter.Size = 100;
                sqlparameter.Direction = ParameterDirection.Output;

                sqlcomand.Parameters.Add(sqlparameter);
                sqlcomand.ExecuteNonQuery();

                return sqlparameter.Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlconnection.Close();
            }
        }
    }
}
