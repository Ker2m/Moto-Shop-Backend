using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
	public class MotorCreateDto
	{
		public string Marka { get; set; } = default!;
		public string Model { get; set; } = default!;
		public string Resim { get; set; } = default!;
		public int Fiyat { get; set; } = default!;
		public int Yil { get; set; } = default!;
		public int Km { get; set; } = default!;

		public string Renk { get; set; } = default!;

		public string YakitTipi { get; set; } = default!;
		public int Motor_Hacmi { get; set; } = default!;
		public int Motor_Gucu { get; set; } = default!;
		public string Vites { get; set; } = default!;
		public string Durumu { get; set; } = default!;
	}
}
