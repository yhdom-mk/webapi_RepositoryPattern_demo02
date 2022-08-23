using webapi_RepositoryPattern_demo02.Contracts;

namespace webapi_RepositoryPattern_demo02.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationContext _applicationContext;
        private IAlbumRepository _albumRepository;
        private ITuneRepository _tuneRepository;

        public RepositoryManager(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IAlbumRepository Album
        {
            get
            {
                if(_albumRepository == null)
                {
                    _albumRepository = new AlbumRepository(_applicationContext);
                    return _albumRepository;
                }
            }
        }

        public ITuneRepository Tune
        {
            get
            {
                if(_tuneRepository == null)
                {
                    _tuneRepository = new TuneRepository(_applicationContext);
                    return _tuneRepository;
                }
            }
        }

        public void Save() => _applicationContext.SaveChanges();
    }
}
