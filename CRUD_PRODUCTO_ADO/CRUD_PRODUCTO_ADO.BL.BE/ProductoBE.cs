using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.BL.BE
{
    public class ProductoBE
    {
        public int ProductoId {get;set;}
        public int CategoriaId {get;set;}
        public String Nombre { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }
        public char Estado { get; set; }

    }
}
