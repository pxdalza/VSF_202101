using CRUD_PRODUCTO_ADO.BL.BE;
using CRUD_PRODUCTO_ADO.FL.UTILITY;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.DL.DC
{
    public class UserDC : IDefaultDC<UserBE>
    {

        private String connectionString = ConfigurationManager.ConnectionStrings["BDAlmacen"].ConnectionString;

        public bool Actualizar(UserBE obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(UserBE obj)
        {
            throw new NotImplementedException();
        }

        public List<UserBE> Listar()
        {
            throw new NotImplementedException();
        }

        public UserBE ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
        public UserBE Login(String username, String password)
        {
            UserBE user = null;

            try
            {
                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_Login", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 600;
                    var pass = PasswordSC.PasswordEncriptarSHA512(password);
                    SQLHelper.AddParam(ref cmd, "@username", ParameterDirection.Input, SqlDbType.VarChar, 250, username);
                    SQLHelper.AddParam(ref cmd, "@password", ParameterDirection.Input, SqlDbType.VarChar, 250, pass);

                    cnx.Open();

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            user = ParseUser(dr);
                        }
                        cnx.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return user;
        }

        private UserBE ParseUser(IDataReader dr)
        {

            try
            {
                UserBE user = new UserBE();
                user.UserID = dr.GetInt32(dr.GetOrdinal("UserId"));
                user.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                user.Apellido = dr.GetString(dr.GetOrdinal("Apellido"));
                user.Username = dr.GetString(dr.GetOrdinal("Username"));
                user.Password = dr.GetString(dr.GetOrdinal("Password"));
                user.Estado = dr.GetString(dr.GetOrdinal("Estado")).ToCharArray()[0];

                return user;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
