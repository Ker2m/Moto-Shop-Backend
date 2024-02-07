using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Infrastructure.Data.Postgres.Repositories;

public class MotorRepository : Repository<Motor, int>, IMotorRepository
{
	public MotorRepository(PostgresContext postgresContext) : base(postgresContext)
	{
	}

	public async Task<IList<Motor>> GetAllAsync(Expression<Func<Motor, bool>>? filter = null)
	{
		var motors = PostgresContext.Set<Motor>();
		return filter == null
			? await motors.ToListAsync()
			: await motors.Where(filter)
			.ToListAsync();
	}

	public Task<IList<Motor>> GetByMotorIdAsync()
	{
		throw new NotImplementedException();
	}
}