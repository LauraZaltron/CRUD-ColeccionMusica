using abm.models;
using ColeccionMusica.Services.Handlers;
using System.Data;

namespace abm.service
{
    public class DataAlbumService
    {
        public DataTable GetAlbums() {
            string query = "select * from dataAlbum";
            return SqliteHandler.GetDataTable(query);
        }
        public bool IngresarAlbum(DataAlbum album) {
            string query = $"insert into dataAlbum values (null, '{album.nombreAlbum}','{album.nombreArtista}','{album.tipoMedio}')";
            return SqliteHandler.ExecQuery(query);
        }
        public bool DeleteAlbum(int id) {
            string query = "delete from dataAlbum where idAlbum = " + id;
            return SqliteHandler.ExecQuery(query);
        }
        public bool EditAlbum(DataAlbum album) {
            string query = $"update dataAlbum set nombreAlbum = '{album.nombreAlbum}', nombreArtista = '{album.nombreArtista}', tipoMedio = '{album.tipoMedio}' where idAlbum = " + album.idAlbum;
            return SqliteHandler.ExecQuery(query);
        }
    }
}
