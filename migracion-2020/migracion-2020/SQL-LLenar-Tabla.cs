using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_LLenar_Tabla
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public OdbcDataAdapter llenaTbl(string tabla)// metodo  que obtinene el contenio de una tabla
		{
			
			string sql = "SELECT id_transaccion AS 'Numero Transaccion', nombre_tramite,fecha_apertura_transaccion FROM " + tabla + " ;";
			//SELECT * FROM tbl_bodega WHERE estado=1 ORDER BY kbodega DESC
			OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conectar.conexion());
			return dataTable;
		}
	}
}
