using CRUD_PRODUCTO_ADO.BL.BE;
using CRUD_PRODUCTO_ADO.DL.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.BL.BC
{
    public class UserBC : IDefaultBC<UserBE>
    {
        UserDC userDC = new UserDC();

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
            //comentario

            UserBE user = null;

            try
            {
                user = userDC.Login(username, password);
            }
            catch (Exception)
            {
                throw;
            }

            return user;

        }
    }
}
