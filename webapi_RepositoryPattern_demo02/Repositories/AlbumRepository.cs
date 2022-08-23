using webapi_RepositoryPattern_demo02.Contracts;
using webapi_RepositoryPattern_demo02.Models;

namespace webapi_RepositoryPattern_demo02.Repositories
{
    public class AlbumRepository : RepositoryBase<Album>, IAlbumRepository
    {
        public void CreateAlbum(Album album)
        {
            Create(album);
        }

        public IEnumerable<Album> GetAllAlbums(bool trackChanges)
        {
            GetAll(trackChanges)
                .OrderBy(x => x.Name)
                .ToList();
        }
    }
}
