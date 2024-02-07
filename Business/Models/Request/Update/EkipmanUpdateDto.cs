using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
	public class EkipmanUpdateDto
	{
		public string Marka { get; set; } = default!;
		public int Fiyat { get; set; } = default!;
		public string Özellikler { get; set; } = default!;
	}
}
