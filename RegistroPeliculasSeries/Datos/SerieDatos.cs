using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;
using RegistroPeliculasSeries.Modelos;

namespace RegistroPeliculasSeries.Datos
{
    class SerieDatos
    {
        public Boolean Agregar(Serie serie)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                string nombre = serie.Nombre;
                string comentario = serie.Comentario;
                int ultima_temporada = serie.Ultima_temporada;
                int ultimo_capitulo = serie.Ultimo_capitulo;
                int estado = serie.Estado;
                string fecha_final_vista = serie.Fecha_final_vista;

                var query = new SQLiteCommand("INSERT INTO series(nombre, comentario, ultima_temporada, ultimo_capitulo, estado, fecha_final_vista) VALUES (@p0, @p1, @p2, @p3, @p4, @p5)", conexion.conexion);

                query.Parameters.AddWithValue("@p0", nombre);
                query.Parameters.AddWithValue("@p1", comentario);
                query.Parameters.AddWithValue("@p2", ultima_temporada);
                query.Parameters.AddWithValue("@p3", ultimo_capitulo);
                query.Parameters.AddWithValue("@p4", estado);
                query.Parameters.AddWithValue("@p5", fecha_final_vista);

                query.ExecuteNonQuery();

                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conexion.cerrar();

            return respuesta;
        }

        public Boolean Editar(Serie serie)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                int id_serie = serie.Id_serie;
                string nombre = serie.Nombre;
                string comentario = serie.Comentario;
                int ultima_temporada = serie.Ultima_temporada;
                int ultimo_capitulo = serie.Ultimo_capitulo;
                int estado = serie.Estado;
                string fecha_final_vista = serie.Fecha_final_vista;

                var query = new SQLiteCommand("UPDATE series SET nombre = @p0, comentario = @p1, ultima_temporada = @p3, ultimo_capitulo = @p4, estado = @p5, fecha_final_vista = @p6 WHERE id_serie = @p7", conexion.conexion);

                query.Parameters.AddWithValue("@p0", nombre);
                query.Parameters.AddWithValue("@p1", comentario);
                query.Parameters.AddWithValue("@p2", estado);
                query.Parameters.AddWithValue("@p3", ultima_temporada);
                query.Parameters.AddWithValue("@p4", ultimo_capitulo);
                query.Parameters.AddWithValue("@p5", estado);
                query.Parameters.AddWithValue("@p6", fecha_final_vista);
                query.Parameters.AddWithValue("@p7", id_serie);

                query.ExecuteNonQuery();

                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conexion.cerrar();

            return respuesta;
        }

        public Boolean Borrar(int id_serie)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                var query = new SQLiteCommand("DELETE FROM series where id_serie = @p0", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_serie);

                query.ExecuteNonQuery();

                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conexion.cerrar();

            return respuesta;
        }

        public ArrayList Listar(string patron)
        {
            ArrayList lista = new ArrayList();
            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT id_serie, nombre, comentario, ultima_temporada, ultimo_capitulo, estado, fecha_final_vista FROM series WHERE nombre LIKE @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", "%" + patron + "%");

            var reader = query.ExecuteReader();
            while (reader.Read())
            {
                Serie serie = new Serie();
                if (!reader.IsDBNull(0))
                {
                    serie.Id_serie = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    serie.Nombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    serie.Comentario = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    serie.Ultima_temporada = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    serie.Ultimo_capitulo = reader.GetInt32(4);
                }
                if (!reader.IsDBNull(5))
                {
                    serie.Estado = reader.GetInt32(5);
                }
                if (!reader.IsDBNull(6))
                {
                    serie.Fecha_final_vista = reader.GetString(6);
                }
                lista.Add(serie);
            }
            reader.Close();
            conexion.cerrar();
            return lista;
        }

        public Serie Cargar(int id_serie)
        {
            Serie serie = new Serie();
            Conexion conexion = new Conexion();
            conexion.abrir();

            var query = new SQLiteCommand("SELECT id_serie, nombre, comentario, ultima_temporada, ultimo_capitulo, estado, fecha_final_vista FROM series WHERE id_serie = @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", id_serie);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    serie.Id_serie = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    serie.Nombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    serie.Comentario = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    serie.Ultima_temporada = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    serie.Ultimo_capitulo = reader.GetInt32(4);
                }
                if (!reader.IsDBNull(5))
                {
                    serie.Estado = reader.GetInt32(5);
                }
                if (!reader.IsDBNull(6))
                {
                    serie.Fecha_final_vista = reader.GetString(6);
                }
            }
            reader.Close();
            conexion.cerrar();
            return serie;
        }

        public bool comprobar_existencia_crear(string nombre)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT COUNT(*) FROM series WHERE nombre = @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", nombre);
            var result = query.ExecuteScalar().ToString();
            int count = Convert.ToInt32(result);
            if (count >= 1)
            {
                respuesta = true;
            }
            conexion.cerrar();

            return respuesta;
        }

        public bool comprobar_existencia_editar(int id_serie, string nombre)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT COUNT(*) FROM series WHERE nombre = @p0 AND id_serie != @p1", conexion.conexion);
            query.Parameters.AddWithValue("@p0", nombre);
            query.Parameters.AddWithValue("@p1", id_serie);
            var result = query.ExecuteScalar().ToString();
            int count = Convert.ToInt32(result);
            if (count >= 1)
            {
                respuesta = true;
            }
            conexion.cerrar();

            return respuesta;
        }

    }
}
