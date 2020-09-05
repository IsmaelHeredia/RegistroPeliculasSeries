namespace RegistroPeliculasSeries.Formularios.Peliculas
{
    partial class FormAgregarPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarPelicula));
            this.gbDatos = new Telerik.WinControls.UI.RadGroupBox();
            this.dtpFechaVista = new Telerik.WinControls.UI.RadDateTimePicker();
            this.cbEstado = new Telerik.WinControls.UI.RadCheckBox();
            this.txtComentario = new Telerik.WinControls.UI.RadTextBox();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.lblFecha = new Telerik.WinControls.UI.RadLabel();
            this.lblComentario = new Telerik.WinControls.UI.RadLabel();
            this.lblNombre = new Telerik.WinControls.UI.RadLabel();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatos)).BeginInit();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComentario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbDatos.Controls.Add(this.dtpFechaVista);
            this.gbDatos.Controls.Add(this.cbEstado);
            this.gbDatos.Controls.Add(this.txtComentario);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblFecha);
            this.gbDatos.Controls.Add(this.lblComentario);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.HeaderText = "Datos";
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(309, 196);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.Text = "Datos";
            this.gbDatos.ThemeName = "TelerikMetro";
            // 
            // dtpFechaVista
            // 
            this.dtpFechaVista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVista.Location = new System.Drawing.Point(97, 156);
            this.dtpFechaVista.Name = "dtpFechaVista";
            this.dtpFechaVista.Size = new System.Drawing.Size(195, 24);
            this.dtpFechaVista.TabIndex = 7;
            this.dtpFechaVista.TabStop = false;
            this.dtpFechaVista.Text = "27/08/2020";
            this.dtpFechaVista.ThemeName = "TelerikMetro";
            this.dtpFechaVista.Value = new System.DateTime(2020, 8, 27, 15, 54, 46, 55);
            // 
            // cbEstado
            // 
            this.cbEstado.Location = new System.Drawing.Point(19, 116);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(145, 19);
            this.cbEstado.TabIndex = 6;
            this.cbEstado.Text = "La pelicula ya fue vista";
            this.cbEstado.ThemeName = "TelerikMetro";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(97, 75);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(195, 24);
            this.txtComentario.TabIndex = 5;
            this.txtComentario.ThemeName = "TelerikMetro";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 24);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.ThemeName = "TelerikMetro";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(19, 157);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(73, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha vista : ";
            this.lblFecha.ThemeName = "TelerikMetro";
            // 
            // lblComentario
            // 
            this.lblComentario.Location = new System.Drawing.Point(19, 75);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(74, 16);
            this.lblComentario.TabIndex = 1;
            this.lblComentario.Text = "Comentario : ";
            this.lblComentario.ThemeName = "TelerikMetro";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(19, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre : ";
            this.lblNombre.ThemeName = "TelerikMetro";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(89, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 24);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.ThemeName = "TelerikMetro";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormAgregarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 262);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAgregarPelicula";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Agregar pelicula";
            this.ThemeName = "TelerikMetro";
            ((System.ComponentModel.ISupportInitialize)(this.gbDatos)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblComentario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbDatos;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadLabel lblFecha;
        private Telerik.WinControls.UI.RadLabel lblComentario;
        private Telerik.WinControls.UI.RadLabel lblNombre;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFechaVista;
        private Telerik.WinControls.UI.RadCheckBox cbEstado;
        private Telerik.WinControls.UI.RadTextBox txtComentario;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
    }
}
