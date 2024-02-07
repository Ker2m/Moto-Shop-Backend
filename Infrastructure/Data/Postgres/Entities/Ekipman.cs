using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
	public class Ekipman : Entity<int>
	{
		public string Marka { get; set; } = default!;
		public int Fiyat { get; set; } = default!;
		public string Özellikler { get; set; } = default!;

	}
}
