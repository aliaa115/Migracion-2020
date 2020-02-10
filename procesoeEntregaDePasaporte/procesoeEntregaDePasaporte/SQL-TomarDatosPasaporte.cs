using System;
using System.Data.Odbc;

namespace procesoeEntregaDePasaporte
{
    public class SQL_TomarDatosPasaporte
    {
        public int id_pas;
        public int id_foto;
        public int id_firma;
        public DateTime emision;
        public DateTime vencimiento;

        SQL_Conexion conectar = new SQL_Conexion();
        public void obtenerPasaporte(string cui)
        {
            OdbcConnection conn = conectar.conexion();
            var resultado = conectar.conexion();
            OdbcCommand comando = conn.CreateCommand();
            OdbcTransaction transaccion = conn.BeginTransaction();
            OdbcDataReader reader;

            string sql = "SELECT id_pasaporte, id_fotografia, id_firma, fecha_emision_pasaporte, fecha_vencimiento_pasaporte " +
                "from pasaportes " +
                "where cui = '"+cui+"' and estado_pasaporte = 'activo';";

            comando.Transaction = transaccion;
            comando.CommandText = sql;

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                id_pas = reader.GetInt32(0);
                id_foto = reader.GetInt32(1);
                id_firma = reader.GetInt32(2);
                emision = reader.GetDate(3);
                vencimiento = reader.GetDate(4);
            }

        }

        public int getIdPasaporte()
        {
            return id_pas;
        }

    }
}
