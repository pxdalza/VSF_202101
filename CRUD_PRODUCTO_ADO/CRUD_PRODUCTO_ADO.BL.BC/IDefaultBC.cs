using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.BL.BC
{
    interface IDefaultBC<T>
    {
        List<T> Listar();
        T ObtenerPorId(int id);
        bool Insertar(T obj);
        bool Actualizar(T obj);
        bool Eliminar(int id);
    }
}
