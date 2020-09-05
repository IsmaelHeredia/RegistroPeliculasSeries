using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroPeliculasSeries.Modelos
{
    class Serie
    {
        int id_serie;
        string nombre;
        string comentario;
        int ultima_temporada;
        int ultimo_capitulo;
        int estado;
        string fecha_final_vista;

        public int Id_serie
        {
            get
            {
                return id_serie;
            }

            set
            {
                id_serie = value;
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

        public int Ultima_temporada
        {
            get
            {
                return ultima_temporada;
            }

            set
            {
                ultima_temporada = value;
            }
        }

        public int Ultimo_capitulo
        {
            get
            {
                return ultimo_capitulo;
            }

            set
            {
                ultimo_capitulo = value;
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

        public string Fecha_final_vista
        {
            get
            {
                return fecha_final_vista;
            }

            set
            {
                fecha_final_vista = value;
            }
        }
    }
}
