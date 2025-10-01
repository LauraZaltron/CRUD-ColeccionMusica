
namespace ColeccionMusica
{
    partial class ColeccionMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColeccionMusica));
            this.txtNombreAlbum = new System.Windows.Forms.TextBox();
            this.txtNombreArtista = new System.Windows.Forms.TextBox();
            this.lblNombreArtista = new System.Windows.Forms.Label();
            this.lblNombreAlbum = new System.Windows.Forms.Label();
            this.rbtnCD = new System.Windows.Forms.RadioButton();
            this.rbtnCDDoble = new System.Windows.Forms.RadioButton();
            this.rbtnCassette = new System.Windows.Forms.RadioButton();
            this.rbtnVinilo = new System.Windows.Forms.RadioButton();
            this.btnIngresarAlbum = new System.Windows.Forms.Button();
            this.grdAlbums = new System.Windows.Forms.DataGridView();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlbums)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreAlbum
            // 
            this.txtNombreAlbum.Location = new System.Drawing.Point(56, 48);
            this.txtNombreAlbum.Name = "txtNombreAlbum";
            this.txtNombreAlbum.Size = new System.Drawing.Size(229, 20);
            this.txtNombreAlbum.TabIndex = 0;
            // 
            // txtNombreArtista
            // 
            this.txtNombreArtista.Location = new System.Drawing.Point(56, 133);
            this.txtNombreArtista.Name = "txtNombreArtista";
            this.txtNombreArtista.Size = new System.Drawing.Size(229, 20);
            this.txtNombreArtista.TabIndex = 1;
            // 
            // lblNombreArtista
            // 
            this.lblNombreArtista.AutoSize = true;
            this.lblNombreArtista.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArtista.Location = new System.Drawing.Point(51, 106);
            this.lblNombreArtista.Name = "lblNombreArtista";
            this.lblNombreArtista.Size = new System.Drawing.Size(159, 26);
            this.lblNombreArtista.TabIndex = 2;
            this.lblNombreArtista.Text = "Nombre Artista";
            // 
            // lblNombreAlbum
            // 
            this.lblNombreAlbum.AutoSize = true;
            this.lblNombreAlbum.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlbum.Location = new System.Drawing.Point(51, 21);
            this.lblNombreAlbum.Name = "lblNombreAlbum";
            this.lblNombreAlbum.Size = new System.Drawing.Size(198, 26);
            this.lblNombreAlbum.TabIndex = 3;
            this.lblNombreAlbum.Text = "Nombre del Album";
            // 
            // rbtnCD
            // 
            this.rbtnCD.AutoSize = true;
            this.rbtnCD.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCD.Location = new System.Drawing.Point(378, 17);
            this.rbtnCD.Name = "rbtnCD";
            this.rbtnCD.Size = new System.Drawing.Size(60, 30);
            this.rbtnCD.TabIndex = 4;
            this.rbtnCD.TabStop = true;
            this.rbtnCD.Text = "CD";
            this.rbtnCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCD.UseVisualStyleBackColor = true;
            this.rbtnCD.CheckedChanged += new System.EventHandler(this.rbtnCD_CheckedChanged);
            // 
            // rbtnCDDoble
            // 
            this.rbtnCDDoble.AutoSize = true;
            this.rbtnCDDoble.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCDDoble.Location = new System.Drawing.Point(378, 125);
            this.rbtnCDDoble.Name = "rbtnCDDoble";
            this.rbtnCDDoble.Size = new System.Drawing.Size(127, 30);
            this.rbtnCDDoble.TabIndex = 5;
            this.rbtnCDDoble.TabStop = true;
            this.rbtnCDDoble.Text = "CD Doble";
            this.rbtnCDDoble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCDDoble.UseVisualStyleBackColor = true;
            this.rbtnCDDoble.CheckedChanged += new System.EventHandler(this.rbtnCDDoble_CheckedChanged);
            // 
            // rbtnCassette
            // 
            this.rbtnCassette.AutoSize = true;
            this.rbtnCassette.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCassette.Location = new System.Drawing.Point(377, 53);
            this.rbtnCassette.Name = "rbtnCassette";
            this.rbtnCassette.Size = new System.Drawing.Size(115, 30);
            this.rbtnCassette.TabIndex = 6;
            this.rbtnCassette.TabStop = true;
            this.rbtnCassette.Text = "Cassette";
            this.rbtnCassette.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCassette.UseVisualStyleBackColor = true;
            this.rbtnCassette.CheckedChanged += new System.EventHandler(this.rbtnCassette_CheckedChanged);
            // 
            // rbtnVinilo
            // 
            this.rbtnVinilo.AutoSize = true;
            this.rbtnVinilo.Font = new System.Drawing.Font("OpenSymbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVinilo.Location = new System.Drawing.Point(377, 89);
            this.rbtnVinilo.Name = "rbtnVinilo";
            this.rbtnVinilo.Size = new System.Drawing.Size(83, 30);
            this.rbtnVinilo.TabIndex = 7;
            this.rbtnVinilo.TabStop = true;
            this.rbtnVinilo.Text = "Vinilo";
            this.rbtnVinilo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnVinilo.UseVisualStyleBackColor = true;
            this.rbtnVinilo.CheckedChanged += new System.EventHandler(this.rbtnVinilo_CheckedChanged);
            // 
            // btnIngresarAlbum
            // 
            this.btnIngresarAlbum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngresarAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarAlbum.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAlbum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresarAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarAlbum.Location = new System.Drawing.Point(593, 68);
            this.btnIngresarAlbum.Name = "btnIngresarAlbum";
            this.btnIngresarAlbum.Size = new System.Drawing.Size(147, 34);
            this.btnIngresarAlbum.TabIndex = 9;
            this.btnIngresarAlbum.Text = "Ingresar Album";
            this.btnIngresarAlbum.UseVisualStyleBackColor = false;
            this.btnIngresarAlbum.Click += new System.EventHandler(this.btnIngresarAlbum_Click);
            // 
            // grdAlbums
            // 
            this.grdAlbums.AllowUserToAddRows = false;
            this.grdAlbums.AllowUserToDeleteRows = false;
            this.grdAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAlbums.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdAlbums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAlbums.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEditar,
            this.colEliminar});
            this.grdAlbums.GridColor = System.Drawing.SystemColors.Control;
            this.grdAlbums.Location = new System.Drawing.Point(0, 268);
            this.grdAlbums.Name = "grdAlbums";
            this.grdAlbums.ReadOnly = true;
            this.grdAlbums.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdAlbums.RowHeadersVisible = false;
            this.grdAlbums.Size = new System.Drawing.Size(768, 295);
            this.grdAlbums.TabIndex = 0;
            this.grdAlbums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlbums_CellContentClick);
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "";
            this.colEditar.Image = ((System.Drawing.Image)(resources.GetObject("colEditar.Image")));
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "";
            this.colEliminar.Image = ((System.Drawing.Image)(resources.GetObject("colEliminar.Image")));
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(593, 67);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(147, 35);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(593, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.rbtnCD);
            this.panel1.Controls.Add(this.lblNombreAlbum);
            this.panel1.Controls.Add(this.rbtnCDDoble);
            this.panel1.Controls.Add(this.txtNombreAlbum);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblNombreArtista);
            this.panel1.Controls.Add(this.rbtnVinilo);
            this.panel1.Controls.Add(this.txtNombreArtista);
            this.panel1.Controls.Add(this.rbtnCassette);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnIngresarAlbum);
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-31, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 190);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OpenSymbol", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Coleccion de Musica";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ColeccionMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(768, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdAlbums);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColeccionMusica";
            this.Text = "Coleccion Personal de Musica";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            ((System.ComponentModel.ISupportInitialize)(this.grdAlbums)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreAlbum;
        private System.Windows.Forms.TextBox txtNombreArtista;
        private System.Windows.Forms.Label lblNombreArtista;
        private System.Windows.Forms.Label lblNombreAlbum;
        private System.Windows.Forms.RadioButton rbtnCD;
        private System.Windows.Forms.RadioButton rbtnCDDoble;
        private System.Windows.Forms.RadioButton rbtnCassette;
        private System.Windows.Forms.RadioButton rbtnVinilo;
        private System.Windows.Forms.Button btnIngresarAlbum;
        private System.Windows.Forms.DataGridView grdAlbums;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colEliminar;
        private System.Windows.Forms.Label label1;
    }
}

