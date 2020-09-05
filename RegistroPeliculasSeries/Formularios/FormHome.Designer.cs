namespace RegistroPeliculasSeries
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.telerikMetroTheme = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.lblTipo = new Telerik.WinControls.UI.RadLabel();
            this.btnPeliculas = new Telerik.WinControls.UI.RadButton();
            this.btnSeries = new Telerik.WinControls.UI.RadButton();
            this.lblCopyright = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCopyright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(80, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(151, 18);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Seleccione el tipo de registro";
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Location = new System.Drawing.Point(36, 85);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(110, 24);
            this.btnPeliculas.TabIndex = 1;
            this.btnPeliculas.Text = "Películas";
            this.btnPeliculas.ThemeName = "TelerikMetro";
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // btnSeries
            // 
            this.btnSeries.Location = new System.Drawing.Point(164, 85);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(110, 24);
            this.btnSeries.TabIndex = 2;
            this.btnSeries.Text = "Series";
            this.btnSeries.ThemeName = "TelerikMetro";
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(24, 159);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(266, 25);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright © Ismael Heredia 2020";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 196);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.btnPeliculas);
            this.Controls.Add(this.lblTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Registro de peliculas y series 1.0";
            this.ThemeName = "TelerikMetro";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCopyright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme;
        private Telerik.WinControls.UI.RadLabel lblTipo;
        private Telerik.WinControls.UI.RadButton btnPeliculas;
        private Telerik.WinControls.UI.RadButton btnSeries;
        private Telerik.WinControls.UI.RadLabel lblCopyright;
    }
}