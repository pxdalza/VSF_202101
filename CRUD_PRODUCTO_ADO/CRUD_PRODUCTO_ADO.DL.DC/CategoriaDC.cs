using CRUD_PRODUCTO_ADO.BL.BE;
using CRUD_PRODUCTO_ADO.FL.UTILITY;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.DL.DC
{
    public class CategoriaDC : IDefaultDC<CategoriaProductoBE>
    {
        private String connectionString = ConfigurationManager.ConnectionStrings["BDAlmacen"].ConnectionString;

        public bool Actualizar(CategoriaProductoBE obj)
        {
            bool actualizado = false;
            SqlConnection cnx = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("USP_ActualizarCategoriaProducto", cnx);
            try
            {
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 600;

                //Agregar los parametros de la tabla
                SQLHelper.AddParam(ref cmd, "@CategoriaId", ParameterDirection.Input, SqlDbType.Int, 250, obj.CategoriaId);
                SQLHelper.AddParam(ref cmd, "@Nombre", ParameterDirection.Input, SqlDbType.VarChar, 250, obj.Nombre);

                //Abrimos conexion a BD
                cnx.Open();
                //Ejecutamos el comando del storedProcedure
                cmd.ExecuteNonQuery();

                actualizado = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally 
            {

                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cnx.Dispose();
                cmd.Dispose();
            }

            return actualizado;
        }

        public bool Eliminar(int id)
        {
            bool eliminado = false;

            try
            {

                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_EliminarCategoriaProducto", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;

                    SQLHelper.AddParam(ref cmd, "@CategoriaID", ParameterDirection.Input, SqlDbType.Int, id);

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    eliminado = true;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return eliminado;

        }

        public bool Insertar(CategoriaProductoBE obj)
        {

            bool registrado = false;

            try
            {

                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_InsertarCategoriaProducto", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;

                    SQLHelper.AddParam(ref cmd, "@Nombre", ParameterDirection.Input, SqlDbType.VarChar, 250, obj.Nombre);

                    cnx.Open();
                    cmd.ExecuteNonQuery();

                    registrado = true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return registrado;

        }

        public List<CategoriaProductoBE> Listar()
        {
            List<CategoriaProductoBE> categorias = new List<CategoriaProductoBE>();

            try
            {
                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_ListarCategoriaProducto", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;

                    cnx.Open();

                    //Creamos nuestro Data Reader que se encarga de leer la informacion
                    //que viene de base de datos
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var categoria = ParseCategoriaProducto(dr);
                            categorias.Add(categoria);
                        }
                        cnx.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return categorias;
        }

        public CategoriaProductoBE ObtenerPorId(int id)
        {
            CategoriaProductoBE categoria = new CategoriaProductoBE();

            try
            {

                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_ObtenerCategoriaProducto", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;
                    SQLHelper.AddParam(ref cmd, "@CategoriaID", ParameterDirection.Input, SqlDbType.Int, id);

                    cnx.Open();

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            categoria = ParseCategoriaProducto(dr);
                        }
                        cnx.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return categoria;
        }

        private CategoriaProductoBE ParseCategoriaProducto(IDataReader dr) 
        {

            try
            {
                CategoriaProductoBE categoriaProductoBE = new CategoriaProductoBE();
                categoriaProductoBE.CategoriaId = dr.GetInt32(dr.GetOrdinal("CategoriaId"));
                categoriaProductoBE.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));

                return categoriaProductoBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
