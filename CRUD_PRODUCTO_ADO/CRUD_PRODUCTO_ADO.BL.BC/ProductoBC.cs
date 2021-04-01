using CRUD_PRODUCTO_ADO.BL.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.BL.BC
{
    public class ProductoBC : IDefaultBC<ProductoBE>
    {
        public bool Actualizar(ProductoBE obj)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(ProductoBE obj)
        {
            throw new NotImplementedException();
        }

        public List<ProductoBE> Listar()
        {
            throw new NotImplementedException();
        }

        public ProductoBE ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
