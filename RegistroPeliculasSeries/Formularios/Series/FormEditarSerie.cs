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
using System.Text.RegularExpressions;

namespace RegistroPeliculasSeries.Formularios.Series
{
    public partial class FormEditarSerie : Telerik.WinControls.UI.RadForm
    {
        public string titulo;
        public int id_serie;
        public FormSeries formSeries;

        public FormEditarSerie(FormSeries formSeries_recibido, int id_serie_recibido)
        {
            InitializeComponent();
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            id_serie = id_serie_recibido;
            formSeries = formSeries_recibido;
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string comentario = txtComentario.Text;

            int ultima_temporada = 0;
            int ultimo_capitulo = 0;

            if (txtUltimaTemporadaVista.Text != "" && (Regex.IsMatch(txtUltimaTemporadaVista.Text.Trim(), @"[0-9]")))
            {
                ultima_temporada = Convert.ToInt32(txtUltimaTemporadaVista.Text);
            }

            if (txtUltimoCapituloVisto.Text != "" && (Regex.IsMatch(txtUltimoCapituloVisto.Text.Trim(), @"[0-9]")))
            {
                ultimo_capitulo = Convert.ToInt32(txtUltimoCapituloVisto.Text);
            }

            bool estado = cbEstado.Checked;
            string fecha_terminada_vista = dtpFechaTerminadaVista.Text;

            if (nombre != "" && ultima_temporada != 0 && ultimo_capitulo != 0)
            {
                SerieDatos serieDatos = new SerieDatos();

                Serie serie = new Serie();

                serie.Id_serie = id_serie;
                serie.Nombre = nombre;

                if (comentario != "")
                {
                    serie.Comentario = comentario;
                }
                else
                {
                    serie.Comentario = "...";
                }

                serie.Ultima_temporada = ultima_temporada;
                serie.Ultimo_capitulo = ultimo_capitulo;

                if (estado == true)
                {
                    serie.Estado = 1;
                }
                else
                {
                    serie.Estado = 0;
                }

                serie.Fecha_final_vista = fecha_terminada_vista;

                if (serieDatos.comprobar_existencia_editar(id_serie, nombre))
                {
                    RadMessageBox.Show("El nombre ya existe", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (serieDatos.Editar(serie))
                    {
                        RadMessageBox.Show("La serie fue editada correctamente", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                        formSeries.cargarSeries();
                        FormEditarSerie.ActiveForm.Close();
                    }
                    else
                    {
                        RadMessageBox.Show("Error editando la serie", titulo, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                RadMessageBox.Show("Complete los datos de la serie", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormEditarSerie_Load(object sender, EventArgs e)
        {
            SerieDatos serieDatos = new SerieDatos();
            Serie serie = serieDatos.Cargar(id_serie);

            string nombre = serie.Nombre;
            string comentario = serie.Comentario;
            int ultima_temporada = serie.Ultima_temporada;
            int ultimo_capitulo = serie.Ultimo_capitulo;
            int estado = serie.Estado;
            string fecha_terminada_vista = serie.Fecha_final_vista;

            txtNombre.Text = nombre;
            txtComentario.Text = comentario;
            txtUltimaTemporadaVista.Text = Convert.ToString(ultima_temporada);
            txtUltimoCapituloVisto.Text = Convert.ToString(ultimo_capitulo);

            if (estado == 1)
            {
                cbEstado.Checked = true;
            }

            dtpFechaTerminadaVista.Text = fecha_terminada_vista;
        }
    }
}
