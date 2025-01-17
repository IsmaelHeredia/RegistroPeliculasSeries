﻿namespace RegistroPeliculasSeries.Formularios.Series
{
    partial class FormSeries
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "ID");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Nombre");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Comentario");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Último episodio");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Estado");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Fecha final vista");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeries));
            this.gbSeries = new Telerik.WinControls.UI.RadGroupBox();
            this.lvSeries = new Telerik.WinControls.UI.RadListView();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.lblNombre = new Telerik.WinControls.UI.RadLabel();
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.cmOpciones = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.miRecargarLista = new Telerik.WinControls.UI.RadMenuItem();
            this.miEditar = new Telerik.WinControls.UI.RadMenuItem();
            this.miEliminar = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gbSeries)).BeginInit();
            this.gbSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSeries
            // 
            this.gbSeries.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbSeries.Controls.Add(this.lvSeries);
            this.gbSeries.Controls.Add(this.txtNombre);
            this.gbSeries.Controls.Add(this.lblNombre);
            this.gbSeries.HeaderText = "Series";
            this.gbSeries.Location = new System.Drawing.Point(12, 12);
            this.gbSeries.Name = "gbSeries";
            this.gbSeries.Size = new System.Drawing.Size(597, 287);
            this.gbSeries.TabIndex = 2;
            this.gbSeries.Text = "Series";
            this.gbSeries.ThemeName = "TelerikMetro";
            // 
            // lvSeries
            // 
            listViewDetailColumn1.HeaderText = "ID";
            listViewDetailColumn1.Visible = false;
            listViewDetailColumn2.HeaderText = "Nombre";
            listViewDetailColumn3.HeaderText = "Comentario";
            listViewDetailColumn4.HeaderText = "Último episodio";
            listViewDetailColumn5.HeaderText = "Estado";
            listViewDetailColumn6.HeaderText = "Fecha final vista";
            this.lvSeries.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5,
            listViewDetailColumn6});
            this.lvSeries.EnableColumnSort = true;
            this.lvSeries.EnableSorting = true;
            this.lvSeries.ItemSpacing = -1;
            this.lvSeries.Location = new System.Drawing.Point(19, 74);
            this.lvSeries.Name = "lvSeries";
            this.lvSeries.Size = new System.Drawing.Size(561, 191);
            this.lvSeries.TabIndex = 2;
            this.lvSeries.Text = "lvSeries";
            this.lvSeries.ThemeName = "TelerikMetro";
            this.lvSeries.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvSeries.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSeries_MouseClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 24);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.ThemeName = "TelerikMetro";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(19, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre : ";
            this.lblNombre.ThemeName = "TelerikMetro";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 318);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(209, 24);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar nueva serie";
            this.btnAgregar.ThemeName = "TelerikMetro";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmOpciones
            // 
            this.cmOpciones.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.miRecargarLista,
            this.miEditar,
            this.miEliminar});
            this.cmOpciones.ThemeName = "TelerikMetro";
            // 
            // miRecargarLista
            // 
            this.miRecargarLista.Name = "miRecargarLista";
            this.miRecargarLista.Text = "Recargar lista";
            // 
            // miEditar
            // 
            this.miEditar.Name = "miEditar";
            this.miEditar.Text = "Editar";
            // 
            // miEliminar
            // 
            this.miEliminar.Name = "miEliminar";
            this.miEliminar.Text = "Eliminar";
            // 
            // FormSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 357);
            this.Controls.Add(this.gbSeries);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSeries";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Series";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbSeries)).EndInit();
            this.gbSeries.ResumeLayout(false);
            this.gbSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbSeries;
        private Telerik.WinControls.UI.RadListView lvSeries;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private Telerik.WinControls.UI.RadLabel lblNombre;
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private Telerik.WinControls.UI.RadContextMenu cmOpciones;
        private Telerik.WinControls.UI.RadMenuItem miEditar;
        private Telerik.WinControls.UI.RadMenuItem miEliminar;
        private Telerik.WinControls.UI.RadMenuItem miRecargarLista;
    }
}
