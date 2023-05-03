using CRUDMongo.Models;

namespace CRUDMongo.Repositories
{
    public interface IAlbumColletion
    {
        void InsertAlbum(Album album);
        void UpdateAlbum(Album album);
        void DeleteAlbum(string id);
        List<Album> GetAllAlbums();
        Album GetAlbumById(string id);

    }
}
