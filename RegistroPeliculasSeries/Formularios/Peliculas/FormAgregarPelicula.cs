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
    public partial class FormAgregarPelicula : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public FormPeliculas formPeliculas;

        public FormAgregarPelicula(FormPeliculas formPeliculas_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
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

                if (peliculaDatos.comprobar_existencia_crear(nombre))
                {
                    RadMessageBox.Show("La película ya existe", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (peliculaDatos.Agregar(pelicula))
                    {
                        RadMessageBox.Show("La película fue creada correctamente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        formPeliculas.cargarPeliculas();
                        FormAgregarPelicula.ActiveForm.Close();
                    }
                    else
                    {
                        RadMessageBox.Show("Error creando la película", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                RadMessageBox.Show("Complete los datos de la película", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
