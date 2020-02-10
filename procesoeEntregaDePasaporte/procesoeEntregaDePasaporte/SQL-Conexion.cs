﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace procesoeEntregaDePasaporte
{
	class SQL_Conexion
	{

		public OdbcConnection conexion()
		{
			OdbcConnection conn = new OdbcConnection("Dsn=GCP");// creacion de la conexion via ODBC
			try
			{
				conn.Open();
			}
			catch (OdbcException)
			{
				Console.WriteLine("No Conectó");
			}
			return conn;
		}

	}
}
