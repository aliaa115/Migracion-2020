using System;
using System.Data.Odbc;

namespace procesoeEntregaDePasaporte
{
    class SQL_Cliente
    {
        public string nombres_dpi;
        public string apellidos_dpi;
        public DateTime fecha_nacimiento_dpi;
        public string estado_civil_dpi;
        public string nacionalidad_dpi;
        public string sexo_dpi;
        public string estado_dpi;

        SQL_Conexion conectar = new SQL_Conexion();
        public void obtenerCliente(string cui)
        {
            OdbcConnection conn = conectar.conexion();
            var resultado = conectar.conexion();
            OdbcCommand comando = conn.CreateCommand();
            OdbcTransaction transaccion = conn.BeginTransaction();
            OdbcDataReader reader;

            string sql = "SELECT nombres_dpi, apellidos_dpi, fecha_nacimiento_dpi, estado_civil_dpi, nacionalidad_dpi, sexo_dpi, estado_dpi " +
                "from dpis " +
                "where cui = '" + cui + "';";

            comando.Transaction = transaccion;
            comando.CommandText = sql;

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                nombres_dpi = reader.GetString(0);
                apellidos_dpi = reader.GetString(1);
                fecha_nacimiento_dpi = reader.GetDate(2);
                estado_civil_dpi = reader.GetString(3);
                nacionalidad_dpi = reader.GetString(4);
                sexo_dpi = reader.GetString(5);
                estado_dpi = reader.GetString(6);
            }

        }

        public string getNombres_dpi()
        {
            return nombres_dpi;
        }
        public string getApellidos_dpi()
        {
            return apellidos_dpi;
        }
        public DateTime getFecha_nacimiento_dpi()
        {
            return fecha_nacimiento_dpi;
        }
        public string getEstado_civil_dpi()
        {
            return estado_civil_dpi;
        }
        public string getNacionalidad_dpi()
        {
            return nacionalidad_dpi;
        }
        public string getSexo_dpi()
        {
            return sexo_dpi;
        }
        public string getEstado_dpi()
        {
            return estado_dpi;
        }
    }
}
