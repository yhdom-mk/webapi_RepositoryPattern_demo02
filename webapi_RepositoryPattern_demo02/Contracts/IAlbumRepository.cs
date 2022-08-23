using webapi_RepositoryPattern_demo02.Models;

namespace webapi_RepositoryPattern_demo02.Contracts
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAllAlbums(bool trackChanges);
        void CreateAlbum(Album album);
    }
}
