using System;
using System.Windows.Forms;
using abm.models;
using abm.service;

namespace ColeccionMusica
{
    public partial class ColeccionMusica : Form
    {
        private void GetAlbums()
        {
            grdAlbums.DataSource = dataAlbumService.GetAlbums();
        }
        public ColeccionMusica()
        {
            InitializeComponent();
            GetAlbums();
            btnEditar.Visible = false;
            btnCancelar.Visible = false;
        }

        int idUpdate = 0;

        DataAlbumService dataAlbumService = new DataAlbumService();
        private string tipoMedio = string.Empty;
        
        private void rbtnCD_CheckedChanged(object sender, EventArgs e)
        {
            tipoMedio = "CD";
        }

        private void rbtnCDDoble_CheckedChanged(object sender, EventArgs e)
        {
            tipoMedio = "CD Doble";
        }

        private void rbtnCassette_CheckedChanged(object sender, EventArgs e)
        {
            tipoMedio = "Cassette";
        }

        private void rbtnVinilo_CheckedChanged(object sender, EventArgs e)
        {
            tipoMedio = "Vinilo";
        }

        private void btnIngresarAlbum_Click(object sender, EventArgs e) //aca
        {
            if (txtNombreAlbum.Text == "" || txtNombreArtista.Text == "" || tipoMedio == "")
            {
                MessageBox.Show("Es obligatorio completar los datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataAlbum ingresarAlbum = new DataAlbum();
            ingresarAlbum.idAlbum = idUpdate;
            ingresarAlbum.nombreAlbum = txtNombreAlbum.Text;
            ingresarAlbum.nombreArtista = txtNombreArtista.Text;
            ingresarAlbum.tipoMedio = tipoMedio;

            bool resultado = dataAlbumService.IngresarAlbum(ingresarAlbum);

            if (resultado)
            {
                MessageBox.Show("Album Ingresado Correctamente.");
                GetAlbums();
                txtNombreAlbum.Clear();
                txtNombreArtista.Clear();
            }
            else 
            {
                MessageBox.Show("Ocurrio un problema al intentar ingresar el album", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombreAlbum.Text == "" || txtNombreArtista.Text == "" || tipoMedio == "")
            {
                MessageBox.Show("Es obligatorio completar los datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataAlbum ingresarAlbum = new DataAlbum();
            ingresarAlbum.idAlbum = idUpdate;
            ingresarAlbum.nombreAlbum = txtNombreAlbum.Text;
            ingresarAlbum.nombreArtista = txtNombreArtista.Text;
            ingresarAlbum.tipoMedio = tipoMedio;

            bool resultado = dataAlbumService.EditAlbum(ingresarAlbum);

            if (resultado)
            {
                MessageBox.Show("Album Editado Correctamente.");
                GetAlbums();
                txtNombreAlbum.Clear();
                txtNombreArtista.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al intentar editar el album", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnEditar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void grdAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Visible = true;
            btnCancelar.Visible = true;
            DataGridViewRow row = grdAlbums.Rows[e.RowIndex];

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                idUpdate = Convert.ToInt32(row.Cells["idAlbum"].Value);
                txtNombreAlbum.Text = row.Cells["nombreAlbum"].Value.ToString();
                txtNombreArtista.Text = row.Cells["nombreArtista"].Value.ToString();
                tipoMedio = row.Cells["tipoMedio"].Value.ToString();
            }

            if (e.RowIndex >=0 && e.ColumnIndex == 1)
            {
                string selectedId = row.Cells["idAlbum"].Value.ToString();
                bool resultado = dataAlbumService.DeleteAlbum(Convert.ToInt32(selectedId));

                if (resultado)
                {
                    MessageBox.Show("Album eliminado correctamente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    GetAlbums();
                    txtNombreAlbum.Clear();
                    txtNombreArtista.Clear();
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al intentar eliminar el album", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            btnCancelar.Visible = false;
        }

    }
}
