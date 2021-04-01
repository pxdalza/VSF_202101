using CRUD_PRODUCTO_ADO.BL.BE;
using CRUD_PRODUCTO_ADO.DL.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.BL.BC
{
    public class CategoriaBC : IDefaultBC<CategoriaProductoBE>
    {
        CategoriaDC categoriaDC = new CategoriaDC();
        public bool Actualizar(CategoriaProductoBE obj)
        {
            bool actualizar = false;

            try
            {
                actualizar = categoriaDC.Actualizar(obj);
            }
            catch (Exception)
            {
                throw;
            }

            return actualizar;

        }

        public bool Eliminar(int id)
        {
            bool eliminado = false;

            try
            {
                eliminado = categoriaDC.Eliminar(id);
            }
            catch (Exception)
            {
                throw;
            }

            return eliminado;
        }

        public bool Insertar(CategoriaProductoBE obj)
        {
            bool insertado = false;

            try
            {
                insertado = categoriaDC.Insertar(obj);
            }
            catch (Exception)
            {
                throw;
            }

            return insertado;
        }

        public List<CategoriaProductoBE> Listar()
        {
            List<CategoriaProductoBE> categorias = new List<CategoriaProductoBE>();

            try
            {
                categorias = categoriaDC.Listar();
            }
            catch (Exception)
            {
                throw;
            }

            return categorias;
        }

        public CategoriaProductoBE ObtenerPorId(int id)
        {
            CategoriaProductoBE categoria = new CategoriaProductoBE();

            try
            {
                categoria = categoriaDC.ObtenerPorId(id);
            }
            catch (Exception)
            {
                throw;
            }

            return categoria;
        }
    }
}
