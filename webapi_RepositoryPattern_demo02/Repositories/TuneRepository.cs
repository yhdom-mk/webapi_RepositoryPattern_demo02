using webapi_RepositoryPattern_demo02.Contracts;
using webapi_RepositoryPattern_demo02.Models;

namespace webapi_RepositoryPattern_demo02.Repositories
{
    public class TuneRepository : RepositoryBase<Tune>, ITuneRepository
    {
        public void CreateTune(Tune tune)
        {
            Create(tune);
        }

        public IEnumerable<Tune> GetAllTunes(bool trackChanges)
        {
            GetAll(trackChanges)
                .OrderBy(x => x.Name)
                .ToList();
        }
    }
}
