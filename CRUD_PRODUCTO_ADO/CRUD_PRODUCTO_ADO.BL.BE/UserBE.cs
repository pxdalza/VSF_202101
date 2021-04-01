using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.BL.BE
{
    public class UserBE
    {
        public int UserID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public char Estado { get; set; }
    }
}
