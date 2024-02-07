using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
	public interface IEkipmanRepository : IRepository<Ekipman,int>
	{
		Task<IList<Ekipman>> GetByEkipmanIdAsync();
	}
}

