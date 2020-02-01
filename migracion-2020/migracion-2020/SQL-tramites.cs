using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_tramites
	{
		SQL_Conexion conectar = new SQL_Conexion();
		public void Ingresar_Transacciones(string nom, string cui	, string fecha)
		{

			string sql = "INSERT INTO transacciones(nombre_tramite,cui,fecha_apertura_transaccion,estado_transaccion)" +
				"  VALUES ('" + nom+"','"+cui+"','"+fecha+"','Activado');";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
	}
}
