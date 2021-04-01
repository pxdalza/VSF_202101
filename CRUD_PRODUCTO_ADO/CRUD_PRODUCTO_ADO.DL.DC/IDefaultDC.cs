using System.Collections.Generic;

namespace CRUD_PRODUCTO_ADO.DL.DC
{
    public interface IDefaultDC<T>
    {

        List<T> Listar();
        T ObtenerPorId(int id);
        bool Insertar(T obj);
        bool Actualizar(T obj);
        bool Eliminar(int id);

    }
}
