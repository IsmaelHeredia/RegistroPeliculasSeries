using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;
using RegistroPeliculasSeries.Modelos;

namespace RegistroPeliculasSeries.Datos
{
    class PeliculaDatos
    {
        public Boolean Agregar(Pelicula pelicula)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                string nombre = pelicula.Nombre;
                string comentario = pelicula.Comentario;
                int estado = pelicula.Estado;
                string fecha_vista = pelicula.Fecha_vista;

                var query = new SQLiteCommand("INSERT INTO peliculas(nombre, comentario, estado, fecha_vista) VALUES (@p0, @p1, @p2, @p3)", conexion.conexion);

                query.Parameters.AddWithValue("@p0", nombre);
                query.Parameters.AddWithValue("@p1", comentario);
                query.Parameters.AddWithValue("@p2", estado);
                query.Parameters.AddWithValue("@p3", fecha_vista);

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

        public Boolean Editar(Pelicula pelicula)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                int id_pelicula = pelicula.Id_pelicula;
                string nombre = pelicula.Nombre;
                string comentario = pelicula.Comentario;
                int estado = pelicula.Estado;
                string fecha_vista = pelicula.Fecha_vista;

                var query = new SQLiteCommand("UPDATE peliculas SET nombre = @p0, comentario = @p1, estado = @p2, fecha_vista = @p3 WHERE id_pelicula = @p4", conexion.conexion);

                query.Parameters.AddWithValue("@p0", nombre);
                query.Parameters.AddWithValue("@p1", comentario);
                query.Parameters.AddWithValue("@p2", estado);
                query.Parameters.AddWithValue("@p3", fecha_vista);
                query.Parameters.AddWithValue("@p4", id_pelicula);

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

        public Boolean Borrar(int id_pelicula)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();

            try
            {
                var query = new SQLiteCommand("DELETE FROM peliculas where id_pelicula = @p0", conexion.conexion);

                query.Parameters.AddWithValue("@p0", id_pelicula);

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
            var query = new SQLiteCommand("SELECT id_pelicula, nombre, comentario, estado, fecha_vista FROM peliculas WHERE nombre LIKE @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", "%" + patron + "%");

            var reader = query.ExecuteReader();
            while (reader.Read())
            {
                Pelicula pelicula = new Pelicula();
                if (!reader.IsDBNull(0))
                {
                    pelicula.Id_pelicula = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    pelicula.Nombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    pelicula.Comentario = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    pelicula.Estado = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    pelicula.Fecha_vista = reader.GetString(4);
                }
                lista.Add(pelicula);
            }
            reader.Close();
            conexion.cerrar();
            return lista;
        }

        public Pelicula Cargar(int id_pelicula)
        {
            Pelicula pelicula = new Pelicula();
            Conexion conexion = new Conexion();
            conexion.abrir();

            var query = new SQLiteCommand("SELECT id_pelicula, nombre, comentario, estado, fecha_vista FROM peliculas WHERE id_pelicula = @p0", conexion.conexion);
            query.Parameters.AddWithValue("@p0", id_pelicula);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    pelicula.Id_pelicula = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    pelicula.Nombre = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    pelicula.Comentario = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    pelicula.Estado = reader.GetInt32(3);
                }
                if (!reader.IsDBNull(4))
                {
                    pelicula.Fecha_vista = reader.GetString(4);
                }
            }
            reader.Close();
            conexion.cerrar();
            return pelicula;
        }

        public bool comprobar_existencia_crear(string nombre)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT COUNT(*) FROM peliculas WHERE nombre = @p0", conexion.conexion);
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

        public bool comprobar_existencia_editar(int id_pelicula, string nombre)
        {
            Boolean respuesta = false;

            Conexion conexion = new Conexion();
            conexion.abrir();
            var query = new SQLiteCommand("SELECT COUNT(*) FROM peliculas WHERE nombre = @p0 AND id_pelicula != @p1", conexion.conexion);
            query.Parameters.AddWithValue("@p0", nombre);
            query.Parameters.AddWithValue("@p1", id_pelicula);
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
