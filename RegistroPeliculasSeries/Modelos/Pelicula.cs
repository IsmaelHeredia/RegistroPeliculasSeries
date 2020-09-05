using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroPeliculasSeries.Modelos
{
    class Pelicula
    {
        int id_pelicula;
        string nombre;
        string comentario;
        int estado;
        string fecha_vista;

        public int Id_pelicula
        {
            get
            {
                return id_pelicula;
            }

            set
            {
                id_pelicula = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Comentario
        {
            get
            {
                return comentario;
            }

            set
            {
                comentario = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Fecha_vista
        {
            get
            {
                return fecha_vista;
            }

            set
            {
                fecha_vista = value;
            }
        }
    }
}
