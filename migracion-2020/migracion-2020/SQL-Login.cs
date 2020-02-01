using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migracion_2020
{
	class SQL_Login
	{
		SQL_Conexion conectar = new SQL_Conexion();

		public Boolean ConsultarUsuario(string cui, string pass)
		{
		
			string sql = "SELECT estado_usuario FROM usuarios WHERE cui='"+cui+"' AND password_usuario=MD5('"+pass+"');";
			bool respuesta = false;
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows && reader.GetValue(0).ToString()=="Activo")
			{
				respuesta = true;
			}
			else
			{
				respuesta = false;
			}
			return respuesta;
		}


		public string ConsultarTelUsuario(string cui)
		{

			string sql = "SELECT telefono_usuario FROM usuarios WHERE cui='" + cui + "';";
			string respuesta = "";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				respuesta = reader.GetValue(0).ToString();
			}
			else
			{
				respuesta ="0";
			}
			return respuesta;
		}
	}
}
