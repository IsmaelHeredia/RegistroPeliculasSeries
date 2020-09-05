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

namespace RegistroPeliculasSeries.Formularios.Series
{
    public partial class FormSeries : Telerik.WinControls.UI.RadForm
    {
        public string basededatos;
        public string titulo;
        FormAgregarSerie formAgregarSerie = new FormAgregarSerie(null);
        FormEditarSerie formEditarSerie = new FormEditarSerie(null, 0);

        public FormSeries()
        {
            InitializeComponent();
            basededatos = System.Configuration.ConfigurationManager.AppSettings["basededatos"];
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            miEditar.Click += miEditar_Click;
            miEliminar.Click += miEliminar_Click;
            miRecargarLista.Click += miRecargarLista_Click;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        public void cargarSeries()
        {
            lvSeries.Items.Clear();
            if (File.Exists(Path.GetFullPath(basededatos)))
            {
                SerieDatos serieDatos = new SerieDatos();

                ArrayList listaSeries = serieDatos.Listar(txtNombre.Text);
                foreach (Serie serie in listaSeries)
                {
                    int id_serie = serie.Id_serie;
                    string nombre = serie.Nombre;
                    string comentario = serie.Comentario;
                    int ultima_temporada = serie.Ultima_temporada;
                    int ultimo_capitulo = serie.Ultimo_capitulo;
                    int estado = serie.Estado;
                    string fecha_vista = serie.Fecha_final_vista;
                    string ultimo_episodio = Convert.ToString(ultima_temporada) + "-" + Convert.ToString(ultimo_capitulo);

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
                    item.SubItems.Add(id_serie);
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(comentario);
                    item.SubItems.Add(ultimo_episodio);
                    item.SubItems.Add(nombre_estado);
                    item.SubItems.Add(fecha_vista);
                    lvSeries.Items.Add(item);
                }
                gbSeries.Text = "Series : " + lvSeries.Items.Count + " encontradas";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!formAgregarSerie.Visible)
            {
                formAgregarSerie = new FormAgregarSerie(this);
                formAgregarSerie.Show();
            }
        }

        private void miRecargarLista_Click(object sender, EventArgs e)
        {
            cargarSeries();
        }

        private void miEditar_Click(object sender, EventArgs e)
        {
            if (!formEditarSerie.Visible)
            {
                var id_serie = Convert.ToInt32(lvSeries.SelectedItem[0]);
                formEditarSerie = new FormEditarSerie(this, id_serie);
                formEditarSerie.Show();
            }
        }

        private void miEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Esta seguro de borrar la serie ?", titulo, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                var id_serie = Convert.ToInt32(lvSeries.SelectedItem[0]);
                SerieDatos serieDatos = new SerieDatos();
                if (serieDatos.Borrar(id_serie))
                {
                    RadMessageBox.Show("Serie eliminada", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error borrando la serie", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                cargarSeries();
            }
        }

        private void FormSeries_Load(object sender, EventArgs e)
        {
            cargarSeries();
        }

        private void lvSeries_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvSeries.SelectedIndex > -1)
                {
                    cmOpciones.Show(Cursor.Position);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            cargarSeries();
        }
    }
}
