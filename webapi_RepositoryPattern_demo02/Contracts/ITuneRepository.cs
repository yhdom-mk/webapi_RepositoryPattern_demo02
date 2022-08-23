using webapi_RepositoryPattern_demo02.Models;

namespace webapi_RepositoryPattern_demo02.Contracts
{
    public interface ITuneRepository
    {
        IEnumerable<Tune> GetAllTunes(bool trackChanges);
        void CreateTune(Tune tune);
    }
}
