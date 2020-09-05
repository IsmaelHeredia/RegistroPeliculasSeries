// Registro de películas y series 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using RegistroPeliculasSeries.Modelos;
using RegistroPeliculasSeries.Datos;

namespace RegistroPeliculasSeries.Formularios.Peliculas
{

    public partial class FormEditarPelicula : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public int id_pelicula;
        public FormPeliculas formPeliculas;

        public FormEditarPelicula(FormPeliculas formPeliculas_recibido, int id_pelicula_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            id_pelicula = id_pelicula_recibido;
            formPeliculas = formPeliculas_recibido;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string comentario = txtComentario.Text;
            bool estado = cbEstado.Checked;
            string fecha_vista = dtpFechaVista.Text;

            if (nombre != "")
            {
                PeliculaDatos peliculaDatos = new PeliculaDatos();

                Pelicula pelicula = new Pelicula();

                pelicula.Id_pelicula = id_pelicula;
                pelicula.Nombre = nombre;

                if (comentario != "")
                {
                    pelicula.Comentario = comentario;
                }
                else
                {
                    pelicula.Comentario = "...";
                }

                if (estado == true)
                {
                    pelicula.Estado = 1;
                }
                else
                {
                    pelicula.Estado = 0;
                }

                pelicula.Fecha_vista = fecha_vista;

                if (peliculaDatos.comprobar_existencia_editar(id_pelicula, nombre))
                {
                    RadMessageBox.Show("El nombre ya existe", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (peliculaDatos.Editar(pelicula))
                    {
                        RadMessageBox.Show("La película fue editada correctamente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        formPeliculas.cargarPeliculas();
                        FormEditarPelicula.ActiveForm.Close();
                    }
                    else
                    {
                        RadMessageBox.Show("Error editando la película", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                RadMessageBox.Show("Complete los datos de la película", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormEditarPelicula_Load(object sender, EventArgs e)
        {
            PeliculaDatos peliculaDatos = new PeliculaDatos();
            Pelicula pelicula = peliculaDatos.Cargar(id_pelicula);

            string nombre = pelicula.Nombre;
            string comentario = pelicula.Comentario;
            int estado = pelicula.Estado;
            string fecha_vista = pelicula.Fecha_vista;

            txtNombre.Text = nombre;
            txtComentario.Text = pelicula.Comentario;

            if (estado == 1)
            {
                cbEstado.Checked = true;
            }

            dtpFechaVista.Text = fecha_vista;
        }
    }
}
