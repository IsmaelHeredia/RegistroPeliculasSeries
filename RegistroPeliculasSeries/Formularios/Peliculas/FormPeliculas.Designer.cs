namespace RegistroPeliculasSeries.Formularios.Peliculas
{
    partial class FormPeliculas
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "ID");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn7 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Nombre");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn8 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Comentario");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn9 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Estado");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn10 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Fecha visto");
            this.gbPeliculas = new Telerik.WinControls.UI.RadGroupBox();
            this.lvPeliculas = new Telerik.WinControls.UI.RadListView();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.lblNombre = new Telerik.WinControls.UI.RadLabel();
            this.btnAgregar = new Telerik.WinControls.UI.RadButton();
            this.cmOpciones = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.miRecargarLista = new Telerik.WinControls.UI.RadMenuItem();
            this.miEditar = new Telerik.WinControls.UI.RadMenuItem();
            this.miEliminar = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeliculas)).BeginInit();
            this.gbPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPeliculas
            // 
            this.gbPeliculas.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbPeliculas.Controls.Add(this.lvPeliculas);
            this.gbPeliculas.Controls.Add(this.txtNombre);
            this.gbPeliculas.Controls.Add(this.lblNombre);
            this.gbPeliculas.HeaderText = "Películas";
            this.gbPeliculas.Location = new System.Drawing.Point(12, 12);
            this.gbPeliculas.Name = "gbPeliculas";
            this.gbPeliculas.Size = new System.Drawing.Size(433, 287);
            this.gbPeliculas.TabIndex = 0;
            this.gbPeliculas.Text = "Películas";
            this.gbPeliculas.ThemeName = "TelerikMetro";
            // 
            // lvPeliculas
            // 
            listViewDetailColumn6.HeaderText = "ID";
            listViewDetailColumn6.Visible = false;
            listViewDetailColumn7.HeaderText = "Nombre";
            listViewDetailColumn8.HeaderText = "Comentario";
            listViewDetailColumn9.HeaderText = "Estado";
            listViewDetailColumn10.HeaderText = "Fecha visto";
            this.lvPeliculas.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn6,
            listViewDetailColumn7,
            listViewDetailColumn8,
            listViewDetailColumn9,
            listViewDetailColumn10});
            this.lvPeliculas.EnableColumnSort = true;
            this.lvPeliculas.EnableSorting = true;
            this.lvPeliculas.ItemSpacing = -1;
            this.lvPeliculas.Location = new System.Drawing.Point(19, 74);
            this.lvPeliculas.Name = "lvPeliculas";
            this.lvPeliculas.Size = new System.Drawing.Size(394, 191);
            this.lvPeliculas.TabIndex = 2;
            this.lvPeliculas.Text = "lvPeliculas";
            this.lvPeliculas.ThemeName = "TelerikMetro";
            this.lvPeliculas.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lvPeliculas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvPeliculas_MouseClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 24);
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
            this.btnAgregar.Size = new System.Drawing.Size(155, 24);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar nueva película";
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
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 359);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPeliculas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Películas";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbPeliculas)).EndInit();
            this.gbPeliculas.ResumeLayout(false);
            this.gbPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbPeliculas;
        private Telerik.WinControls.UI.RadButton btnAgregar;
        private Telerik.WinControls.UI.RadListView lvPeliculas;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private Telerik.WinControls.UI.RadLabel lblNombre;
        private Telerik.WinControls.UI.RadContextMenu cmOpciones;
        private Telerik.WinControls.UI.RadMenuItem miEditar;
        private Telerik.WinControls.UI.RadMenuItem miEliminar;
        private Telerik.WinControls.UI.RadMenuItem miRecargarLista;
    }
}
