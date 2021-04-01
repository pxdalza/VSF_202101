using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.FL.UTILITY
{
    public static class SQLHelper
    {
        public static void AddParam(ref SqlCommand cmd, String nombreParametro, ParameterDirection direccionParametro,
            SqlDbType tipoParametro, int tamanio, object datoParametro)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = nombreParametro;
            param.Direction = direccionParametro;
            param.SqlDbType = tipoParametro;
            param.Size = tamanio;
            param.Value = datoParametro;

            cmd.Parameters.Add(param);
        }

        public static void AddParam(ref SqlCommand cmd, String nombreParametro, ParameterDirection direccionParametro,
            SqlDbType tipoParametro, object datoParametro)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = nombreParametro;
            param.Direction = direccionParametro;
            param.SqlDbType = tipoParametro;
            param.Value = datoParametro;

            cmd.Parameters.Add(param);

        }

        public static void AddParam(ref SqlCommand cmd, String nombreParametro, ParameterDirection direccionParametro,
            SqlDbType tipoParametro, byte precision, byte escala, object datoParametro)
        {
            SqlParameter param = new SqlParameter();
            param.ParameterName = nombreParametro;
            param.Direction = direccionParametro;
            param.SqlDbType = tipoParametro;
            param.Precision = precision;
            param.Scale = escala;
            param.Value = datoParametro;

            cmd.Parameters.Add(param);
        }

    }
}
