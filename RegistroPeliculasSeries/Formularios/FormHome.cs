// Registro de películas y series 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RegistroPeliculasSeries.Formularios.Peliculas;
using RegistroPeliculasSeries.Formularios.Series;
using System.IO;
using System.Configuration;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using RegistroPeliculasSeries.Datos;

namespace RegistroPeliculasSeries
{
    public partial class FormHome : Telerik.WinControls.UI.RadForm
    {
        public string basededatos;
        public string titulo;

        FormPeliculas formPeliculas = new FormPeliculas();
        FormSeries formSeries = new FormSeries();

        public FormHome()
        {
            InitializeComponent();
            basededatos = System.Configuration.ConfigurationManager.AppSettings["basededatos"];
            titulo = System.Configuration.ConfigurationManager.AppSettings["titulo_programa"];
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            if (!formPeliculas.Visible)
            {
                formPeliculas = new FormPeliculas();
                formPeliculas.Show();
            }
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            if (!formSeries.Visible)
            {
                formSeries = new FormSeries();
                formSeries.Show();
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            if (!File.Exists(Path.GetFullPath(basededatos)))
            {
                datos.crearBD();
                RadMessageBox.Show("Configuración finalizada", titulo, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
