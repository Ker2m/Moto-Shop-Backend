using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Infrastructure.Data.Postgres.Repositories;

public class EkipmanRepository : Repository<Ekipman, int>, IEkipmanRepository
{
	public EkipmanRepository(PostgresContext postgresContext) : base(postgresContext)
	{
	}

	public async Task<IList<Ekipman>> GetAllAsync(Expression<Func<Ekipman, bool>>? filter = null)
	{
		var ekipmen = PostgresContext.Set<Ekipman>();
		return filter == null
			? await ekipmen.ToListAsync()
			: await ekipmen.Where(filter)
			.ToListAsync();
	}

	public Task<IList<Ekipman>> GetByEkipmanIdAsync()
	{
		throw new NotImplementedException();
	}
}