namespace webapi_RepositoryPattern_demo02.Contracts
{
    public interface IRepositoryManager
    {
        IAlbumRepository Album { get; }
        ITuneRepository Tune { get; }
        void Save();
    }
}
