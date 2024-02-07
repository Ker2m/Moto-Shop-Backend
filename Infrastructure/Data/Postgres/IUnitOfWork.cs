using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }

    IMotorRepository Motor { get; }
    IEkipmanRepository Ekipman { get; }
    IContactRepository Contact { get; }

    Task<int> CommitAsync();
}