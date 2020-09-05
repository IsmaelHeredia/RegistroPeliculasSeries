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
using System.IO;
using RegistroPeliculasSeries.Modelos;
using RegistroPeliculasSeries.Datos;

namespace RegistroPeliculasSeries.Formularios.Peliculas
{
    public partial class FormPeliculas : Telerik.WinControls.UI.RadForm
    {
        public string basededatos;
        public string titulo;
        FormAgregarPelicula formAgregarPelicula = new FormAgregarPelicula(null);
        FormEditarPelicula formEditarPelicula = new FormEditarPelicula(null, 0);

        public FormPeliculas()
        {
            InitializeComponent();
            basededatos = System.Configuration.ConfigurationManager.AppSettings["basededatos"];
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            miEditar.Click += miEditar_Click;
            miEliminar.Click += miEliminar_Click;
            miRecargarLista.Click += miRecargarLista_Click;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        public void cargarPeliculas()
        {
            lvPeliculas.Items.Clear();
            if (File.Exists(Path.GetFullPath(basededatos)))
            {
                PeliculaDatos peliculaDatos = new PeliculaDatos();

                ArrayList listaPeliculas = peliculaDatos.Listar(txtNombre.Text);
                foreach (Pelicula pelicula in listaPeliculas)
                {
                    int id_pelicula = pelicula.Id_pelicula;
                    string nombre = pelicula.Nombre;
                    string comentario = pelicula.Comentario;
                    int estado = pelicula.Estado;
                    string fecha_vista = pelicula.Fecha_vista;

                    string nombre_estado = "";

                    if (estado == 1)
                    {
                        nombre_estado = "Terminada";
                    }
                    else
                    {
                        nombre_estado = "Sin terminar";
                    }

                    ListViewDataItem item = new ListViewDataItem();
                    item.SubItems.Add(id_pelicula);
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(comentario);
                    item.SubItems.Add(nombre_estado);
                    item.SubItems.Add(fecha_vista);
                    lvPeliculas.Items.Add(item);
                }
                gbPeliculas.Text = "Peliculas : " + lvPeliculas.Items.Count + " encontradas";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!formAgregarPelicula.Visible)
            {
                formAgregarPelicula = new FormAgregarPelicula(this);
                formAgregarPelicula.Show();
            }
        }

        private void miRecargarLista_Click(object sender, EventArgs e)
        {
            cargarPeliculas();
        }

        private void miEditar_Click(object sender, EventArgs e)
        {
            if (!formEditarPelicula.Visible)
            {
                var id_pelicula = Convert.ToInt32(lvPeliculas.SelectedItem[0]);
                formEditarPelicula = new FormEditarPelicula(this, id_pelicula);
                formEditarPelicula.Show();
            }
        }

        private void miEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Esta seguro de borrar la película ?", titulo, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                var id_pelicula = Convert.ToInt32(lvPeliculas.SelectedItem[0]);
                PeliculaDatos peliculaDatos = new PeliculaDatos();
                if (peliculaDatos.Borrar(id_pelicula))
                {
                    RadMessageBox.Show("Película eliminada", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error borrando la película", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                cargarPeliculas();
            }
        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            cargarPeliculas();
        }

        private void lvPeliculas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvPeliculas.SelectedIndex > -1)
                {
                    cmOpciones.Show(Cursor.Position);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            cargarPeliculas();
        }
    }
}
