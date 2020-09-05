using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace RegistroPeliculasSeries.Datos
{
    class AccesoDatos
    {
        public AccesoDatos()
        {
        }

        public Boolean crearBD()
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                string sql_crear_tabla_peliculas = "CREATE TABLE IF NOT EXISTS peliculas(id_pelicula integer PRIMARY KEY autoincrement,nombre nvarchar(100),comentario nvarchar(100),estado integer, fecha_vista nvarchar(100));";

                SQLiteCommand cmd_crear_tabla_peliculas = new SQLiteCommand(sql_crear_tabla_peliculas, conexion.conexion);
                cmd_crear_tabla_peliculas.ExecuteNonQuery();

                string sql_crear_tabla_series = "CREATE TABLE IF NOT EXISTS series(id_serie integer PRIMARY KEY autoincrement,nombre nvarchar(100),comentario nvarchar(100),ultima_temporada integer, ultimo_capitulo integer, estado integer, fecha_final_vista nvarchar(100));";

                SQLiteCommand cmd_crear_tabla_series = new SQLiteCommand(sql_crear_tabla_series, conexion.conexion);
                cmd_crear_tabla_series.ExecuteNonQuery();

                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return respuesta;
        }
    }
}
